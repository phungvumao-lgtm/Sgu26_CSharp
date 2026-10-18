using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace ThucHanh06a
{
    public partial class QLDiem : Form
    {
        // Kết nối SQL Server chạy trong Docker
        private SqlConnection conn = new SqlConnection(
            "Data Source=localhost,1433;Initial Catalog=QLSinhVien;" +
            "User ID=sa;Password=Matkhau@123;TrustServerCertificate=True;Connect Timeout=5");

        public QLDiem()
        {
            InitializeComponent();

            btnThem.Click += btnThem_Click;
            btnXoa.Click += btnXoa_Click;
            btnSua.Click += btnSua_Click;
            txtDiem.KeyPress += txtDiem_KeyPress;
        }

        // Ô Điểm: chỉ cho gõ số và đúng một dấu thập phân (. hoặc ,)
        private void txtDiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar)) return;

            bool laDauThapPhan = e.KeyChar == '.' || e.KeyChar == ',';
            if (laDauThapPhan && !txtDiem.Text.Contains(".") && !txtDiem.Text.Contains(","))
                return;

            e.Handled = true; // chặn ký tự khác
        }

        // ===== THÊM: Mã SV, Mã MH, Điểm đều bắt buộc =====
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraMa()) return;
            decimal diem;
            if (!DocDiem(out diem)) return;

            ThucThi("insert into Diem(MaSinhVien, MaMonHoc, Diem) values(@sv, @mh, @diem)",
                "Thêm thành công!", true, diem);
        }

        // ===== XÓA: chỉ cần Mã SV và Mã MH, bỏ qua ô Điểm =====
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!KiemTraMa()) return;

            ThucThi("delete from Diem where MaSinhVien = @sv and MaMonHoc = @mh",
                "Xóa thành công!", false, 0);
        }

        // ===== SỬA: Mã SV, Mã MH, Điểm đều bắt buộc =====
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!KiemTraMa()) return;
            decimal diem;
            if (!DocDiem(out diem)) return;

            ThucThi("update Diem set Diem = @diem where MaSinhVien = @sv and MaMonHoc = @mh",
                "Sửa thành công!", true, diem);
        }

        // ===== Kiểm tra dữ liệu =====
        private bool KiemTraMa()
        {
            if (txtMaSV.Text.Trim() == "")
            {
                Loi("Mã sinh viên không được để trống!", txtMaSV);
                return false;
            }
            if (txtMaMH.Text.Trim() == "")
            {
                Loi("Mã môn học không được để trống!", txtMaMH);
                return false;
            }
            return true;
        }

        private bool DocDiem(out decimal diem)
        {
            diem = 0;
            string s = txtDiem.Text.Trim().Replace(',', '.');

            if (s == "")
            {
                Loi("Điểm không được để trống!", txtDiem);
                return false;
            }
            if (!decimal.TryParse(s, NumberStyles.AllowDecimalPoint,
                                  CultureInfo.InvariantCulture, out diem))
            {
                Loi("Điểm chỉ được nhập số!", txtDiem);
                return false;
            }
            if (diem < 0 || diem > 10)
            {
                Loi("Điểm phải nằm trong khoảng từ 0 đến 10!", txtDiem);
                return false;
            }
            if (Math.Round(diem, 2) != diem)
            {
                Loi("Điểm chỉ được có tối đa 2 chữ số thập phân!", txtDiem);
                return false;
            }
            return true;
        }

        private void Loi(string nd, Control c)
        {
            MessageBox.Show(nd, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            c.Focus();
            TextBox t = c as TextBox;
            if (t != null) t.SelectAll();
        }

        // ===== Thực thi câu lệnh =====
        private void ThucThi(string sql, string thongBao, bool dungDiem, decimal diem)
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@sv", txtMaSV.Text.Trim());
                    cmd.Parameters.AddWithValue("@mh", txtMaMH.Text.Trim());
                    if (dungDiem)
                    {
                        SqlParameter p = cmd.Parameters.Add("@diem", SqlDbType.Decimal);
                        p.Precision = 4;
                        p.Scale = 2;
                        p.Value = diem;
                    }

                    int soDong = cmd.ExecuteNonQuery();
                    if (soDong == 0)
                    {
                        MessageBox.Show(
                            "Không tìm thấy điểm của sinh viên '" + txtMaSV.Text.Trim() +
                            "' ở môn '" + txtMaMH.Text.Trim() + "'!",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(thongBao, "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMaSV.Clear();
                        txtMaMH.Clear();
                        txtDiem.Clear();
                        txtMaSV.Focus();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(DichLoi(ex), "Thất bại",
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

        // Đổi lỗi SQL sang câu tiếng Việt dễ hiểu
        private string DichLoi(SqlException ex)
        {
            switch (ex.Number)
            {
                case 2627:
                case 2601:
                    return "Sinh viên này đã có điểm môn này rồi! Hãy dùng nút Sửa.";
                case 547:
                    if (ex.Message.Contains("dbo.SinhVien"))
                        return "Mã sinh viên không tồn tại!";
                    if (ex.Message.Contains("dbo.MonHoc"))
                        return "Mã môn học không tồn tại!";
                    if (ex.Message.Contains("CHECK"))
                        return "Điểm phải nằm trong khoảng từ 0 đến 10!";
                    return "Dữ liệu không hợp lệ: " + ex.Message;
                case -1:
                case 2:
                case 53:
                case 40:
                case 10061:
                    return "Không kết nối được SQL Server!\n" +
                           "Hãy mở Docker Desktop và chạy: docker start sqlserver\n" +
                           "(chờ 20-30 giây rồi thử lại).";
                case 4060:
                    return "Không mở được CSDL QLSinhVien. Hãy kiểm tra đã tạo CSDL chưa.";
                case 18456:
                    return "Sai tài khoản hoặc mật khẩu SQL Server (user sa).";
                default:
                    return "Thất bại: " + ex.Message;
            }
        }
    }
}