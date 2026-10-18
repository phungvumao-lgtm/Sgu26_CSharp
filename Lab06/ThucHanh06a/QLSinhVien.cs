using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace ThucHanh06a
{
    public partial class QLSinhVien : Form
    {
        // Kết nối SQL Server chạy trong Docker
        private SqlConnection conn = new SqlConnection(
            "Data Source=localhost,1433;Initial Catalog=QLSinhVien;" +
            "User ID=sa;Password=Matkhau@123;TrustServerCertificate=True");

        public QLSinhVien()
        {
            InitializeComponent();

            btnThem.Click += btnThem_Click;
            btnXoa.Click += btnXoa_Click;
            btnSua.Click += btnSua_Click;
        }

        // ===== THÊM: cả 4 trường không được để trống =====
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaLop.Text.Trim() == "") { Loi("Mã lớp không được để trống!", txtMaLop); return; }
            if (txtMaSV.Text.Trim() == "") { Loi("Mã sinh viên không được để trống!", txtMaSV); return; }
            if (txtHoTen.Text.Trim() == "") { Loi("Họ tên không được để trống!", txtHoTen); return; }
            DateTime ngay;
            if (!DocNgay(out ngay, true)) return;

            string sql = "insert into SinhVien(MaSinhVien, HoTen, NgaySinh, MaLop) " +
                         "values(@ma, @ten, @ngay, @lop)";
            ThucThi(sql, "Thêm thành công!", cmd =>
            {
                cmd.Parameters.AddWithValue("@ma", txtMaSV.Text.Trim());
                cmd.Parameters.AddWithValue("@ten", txtHoTen.Text.Trim());
                cmd.Parameters.Add("@ngay", SqlDbType.Date).Value = ngay;
                cmd.Parameters.AddWithValue("@lop", txtMaLop.Text.Trim());
            });
        }

        // ===== XÓA: Mã SV và Họ tên không được để trống, xóa khi trùng cả hai =====
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text.Trim() == "") { Loi("Mã sinh viên không được để trống!", txtMaSV); return; }
            if (txtHoTen.Text.Trim() == "") { Loi("Họ tên không được để trống!", txtHoTen); return; }

            string sql = "delete from SinhVien where MaSinhVien = @ma and HoTen = @ten";
            ThucThi(sql, "Xóa thành công!", cmd =>
            {
                cmd.Parameters.AddWithValue("@ma", txtMaSV.Text.Trim());
                cmd.Parameters.AddWithValue("@ten", txtHoTen.Text.Trim());
            });
        }

        // ===== SỬA: Mã SV bắt buộc; trường nào có dữ liệu mới được đổi =====
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text.Trim() == "") { Loi("Mã sinh viên không được để trống!", txtMaSV); return; }

            bool coLop = txtMaLop.Text.Trim() != "";
            bool coTen = txtHoTen.Text.Trim() != "";
            bool coNgay = mskNgaySinh.Text.Trim() != "";

            if (!coLop && !coTen && !coNgay)
            {
                Loi("Mã lớp, Họ tên, Ngày sinh phải có ít nhất một trường có dữ liệu!", txtMaLop);
                return;
            }

            DateTime ngay = DateTime.Today;
            if (coNgay && !DocNgay(out ngay, false)) return;

            List<string> set = new List<string>();
            if (coLop) set.Add("MaLop = @lop");
            if (coTen) set.Add("HoTen = @ten");
            if (coNgay) set.Add("NgaySinh = @ngay");

            string sql = "update SinhVien set " + string.Join(", ", set) + " where MaSinhVien = @ma";
            ThucThi(sql, "Sửa thành công!", cmd =>
            {
                cmd.Parameters.AddWithValue("@ma", txtMaSV.Text.Trim());
                if (coLop) cmd.Parameters.AddWithValue("@lop", txtMaLop.Text.Trim());
                if (coTen) cmd.Parameters.AddWithValue("@ten", txtHoTen.Text.Trim());
                if (coNgay) cmd.Parameters.Add("@ngay", SqlDbType.Date).Value = ngay;
            });
        }

        // ===== Hàm hỗ trợ =====
        private void Loi(string nd, Control c)
        {
            MessageBox.Show(nd, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            c.Focus();
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
                !DateTime.TryParseExact(s, "ddMMyyyy", CultureInfo.InvariantCulture,
                                        DateTimeStyles.None, out ngay))
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

        private void ThucThi(string sql, string thongBao, Action<SqlCommand> thamSo)
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    thamSo(cmd);
                    int soDong = cmd.ExecuteNonQuery();
                    if (soDong == 0)
                    {
                        MessageBox.Show("Không tìm thấy sinh viên phù hợp với thông tin đã nhập!",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(thongBao, "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMaLop.Clear();
                        txtMaSV.Clear();
                        txtHoTen.Clear();
                        mskNgaySinh.Clear();
                        txtMaLop.Focus();
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                    MessageBox.Show("Mã sinh viên đã tồn tại!", "Thất bại",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (ex.Number == 547)
                    MessageBox.Show("Mã lớp không tồn tại hoặc sinh viên đang được dùng ở bảng khác!",
                        "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Thất bại: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }
    }
}