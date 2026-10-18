using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace ThucHanh06b
{
    public partial class SinhVienCombo : Form
    {
        private SqlConnection conn = new SqlConnection(Db.ConnStr);

        public SinhVienCombo()
        {
            InitializeComponent();

            this.Load += SinhVienCombo_Load;
            btnThem.Click += btnThem_Click;
            btnXoa.Click += btnXoa_Click;
            btnSua.Click += btnSua_Click;
        }

        // Form Load: đổ mã lớp lên ComboBox bằng SqlDataReader
        private void SinhVienCombo_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cboLop.Items.Clear();
                using (SqlCommand cmd = new SqlCommand("select MaLop from Lop order by MaLop", conn))
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                        cboLop.Items.Add(rd["MaLop"].ToString());
                }
                if (cboLop.Items.Count > 0) cboLop.SelectedIndex = 0;
            }
            catch (SqlException ex) { MessageBox.Show(Db.DichLoi(ex), "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (Exception ex) { MessageBox.Show("Thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { if (conn.State == ConnectionState.Open) conn.Close(); }
        }

        // Kiểm tra khóa chính: true = mã CHƯA tồn tại (kết nối phải đang mở)
        private bool KT_KhoaChinh(string ma)
        {
            using (SqlCommand cmd = new SqlCommand("select 1 from SinhVien where MaSinhVien = @ma", conn))
            {
                cmd.Parameters.AddWithValue("@ma", ma);
                using (SqlDataReader rd = cmd.ExecuteReader())
                    return !rd.HasRows;
            }
        }

        // Kiểm tra khóa ngoại: sinh viên đã có điểm trong bảng Diem chưa
        private bool CoDiem(string ma)
        {
            using (SqlCommand cmd = new SqlCommand("select 1 from Diem where MaSinhVien = @ma", conn))
            {
                cmd.Parameters.AddWithValue("@ma", ma);
                using (SqlDataReader rd = cmd.ExecuteReader())
                    return rd.HasRows;
            }
        }

        // ===== THÊM =====
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cboLop.SelectedIndex < 0) { Loi("Bạn phải chọn lớp!", cboLop); return; }
            if (txtMaSV.Text.Trim() == "") { Loi("Mã sinh viên không được để trống!", txtMaSV); return; }
            if (txtHoTen.Text.Trim() == "") { Loi("Họ tên không được để trống!", txtHoTen); return; }
            DateTime ngay;
            if (!DocNgay(out ngay, true)) return;
            if (!KiemTraTuoi(ngay)) return;

            try
            {
                conn.Open();

                if (!KT_KhoaChinh(txtMaSV.Text.Trim()))
                {
                    MessageBox.Show("Trùng mã sinh viên! Mã '" + txtMaSV.Text.Trim() + "' đã có trong bảng SinhVien.",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaSV.Focus();
                    txtMaSV.SelectAll();
                    return;
                }

                using (SqlCommand cmd = new SqlCommand(
                    "insert into SinhVien(MaSinhVien, HoTen, NgaySinh, MaLop) values(@ma, @ten, @ngay, @lop)", conn))
                {
                    cmd.Parameters.AddWithValue("@ma", txtMaSV.Text.Trim());
                    cmd.Parameters.AddWithValue("@ten", txtHoTen.Text.Trim());
                    cmd.Parameters.Add("@ngay", SqlDbType.Date).Value = ngay;
                    cmd.Parameters.AddWithValue("@lop", cboLop.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                }
                ThanhCong("Thêm thành công!");
            }
            catch (SqlException ex) { MessageBox.Show(Db.DichLoi(ex), "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (Exception ex) { MessageBox.Show("Thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { if (conn.State == ConnectionState.Open) conn.Close(); }
        }

        // ===== XÓA: kiểm tra khóa chính (tồn tại) và khóa ngoại (đã có điểm) =====
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text.Trim() == "") { Loi("Mã sinh viên không được để trống!", txtMaSV); return; }
            string ma = txtMaSV.Text.Trim();

            try
            {
                conn.Open();

                if (KT_KhoaChinh(ma))
                {
                    MessageBox.Show("Không tìm thấy sinh viên có mã '" + ma + "'!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaSV.Focus();
                    return;
                }
                if (CoDiem(ma))
                {
                    MessageBox.Show("Không thể xóa! Sinh viên '" + ma + "' đã có điểm trong bảng Diem.\n" +
                                    "Hãy xóa điểm của sinh viên này trước.",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlCommand cmd = new SqlCommand("delete from SinhVien where MaSinhVien = @ma", conn))
                {
                    cmd.Parameters.AddWithValue("@ma", ma);
                    cmd.ExecuteNonQuery();
                }
                ThanhCong("Xóa thành công!");
            }
            catch (SqlException ex) { MessageBox.Show(Db.DichLoi(ex), "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (Exception ex) { MessageBox.Show("Thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { if (conn.State == ConnectionState.Open) conn.Close(); }
        }

        // ===== SỬA: lớp lấy từ ComboBox; Họ tên/Ngày sinh chỉ đổi nếu có nhập =====
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text.Trim() == "") { Loi("Mã sinh viên không được để trống!", txtMaSV); return; }
            if (cboLop.SelectedIndex < 0) { Loi("Bạn phải chọn lớp!", cboLop); return; }

            bool coTen = txtHoTen.Text.Trim() != "";
            bool coNgay = mskNgaySinh.Text.Trim() != "";

            DateTime ngay = DateTime.Today;
            if (coNgay)
            {
                if (!DocNgay(out ngay, false)) return;
                if (!KiemTraTuoi(ngay)) return;
            }

            string ma = txtMaSV.Text.Trim();

            try
            {
                conn.Open();

                if (KT_KhoaChinh(ma))
                {
                    MessageBox.Show("Không tìm thấy sinh viên có mã '" + ma + "'!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaSV.Focus();
                    return;
                }

                List<string> set = new List<string>();
                set.Add("MaLop = @lop");
                if (coTen) set.Add("HoTen = @ten");
                if (coNgay) set.Add("NgaySinh = @ngay");

                using (SqlCommand cmd = new SqlCommand(
                    "update SinhVien set " + string.Join(", ", set) + " where MaSinhVien = @ma", conn))
                {
                    cmd.Parameters.AddWithValue("@ma", ma);
                    cmd.Parameters.AddWithValue("@lop", cboLop.SelectedItem.ToString());
                    if (coTen) cmd.Parameters.AddWithValue("@ten", txtHoTen.Text.Trim());
                    if (coNgay) cmd.Parameters.Add("@ngay", SqlDbType.Date).Value = ngay;
                    cmd.ExecuteNonQuery();
                }
                ThanhCong("Sửa thành công!");
            }
            catch (SqlException ex) { MessageBox.Show(Db.DichLoi(ex), "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (Exception ex) { MessageBox.Show("Thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { if (conn.State == ConnectionState.Open) conn.Close(); }
        }

        // ===== Hàm hỗ trợ =====
        private void Loi(string nd, Control c)
        {
            MessageBox.Show(nd, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            c.Focus();
        }

        private void ThanhCong(string nd)
        {
            MessageBox.Show(nd, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtMaSV.Clear();
            txtHoTen.Clear();
            mskNgaySinh.Clear();
            txtMaSV.Focus();
        }

        // Đọc ngày dd/MM/yyyy từ MaskedTextBox
        private bool DocNgay(out DateTime ngay, bool batBuoc)
        {
            ngay = DateTime.Today;
            string s = mskNgaySinh.Text.Trim();
            if (s == "")
            {
                if (batBuoc) Loi("Ngày sinh không được để trống!", mskNgaySinh);
                return !batBuoc;
            }
            if (s.Length != 8 ||
                !DateTime.TryParseExact(s, "ddMMyyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngay))
            {
                Loi("Ngày sinh không hợp lệ (định dạng dd/MM/yyyy)!", mskNgaySinh);
                return false;
            }
            if (ngay > DateTime.Today)
            {
                Loi("Ngày sinh không được lớn hơn ngày hiện tại!", mskNgaySinh);
                return false;
            }
            return true;
        }

        // Sinh viên phải từ 17 tuổi trở lên (chỉ tính theo năm sinh)
        private bool KiemTraTuoi(DateTime ngay)
        {
            int tuoi = DateTime.Today.Year - ngay.Year;
            if (tuoi < 17)
            {
                Loi("Sinh viên phải từ 17 tuổi trở lên (hiện mới " + tuoi + " tuổi)!", mskNgaySinh);
                return false;
            }
            return true;
        }
    }
}