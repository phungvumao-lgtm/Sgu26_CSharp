using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ThucHanh06a
{
    public partial class QLLop : Form
    {
        // Kết nối SQL Server chạy trong Docker
        private SqlConnection conn = new SqlConnection(
            "Data Source=localhost,1433;Initial Catalog=QLSinhVien;" +
            "User ID=sa;Password=Matkhau@123;TrustServerCertificate=True;Connect Timeout=5");

        public QLLop()
        {
            InitializeComponent();

            btnThem.Click += btnThem_Click;
            btnXoa.Click += btnXoa_Click;
            btnSua.Click += btnSua_Click;
        }

        // ===== THÊM: Mã khoa, Mã lớp, Tên lớp đều bắt buộc =====
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaKhoa.Text.Trim() == "") { Loi("Mã khoa không được để trống!", txtMaKhoa); return; }
            if (txtMaLop.Text.Trim() == "") { Loi("Mã lớp không được để trống!", txtMaLop); return; }
            if (txtTenLop.Text.Trim() == "") { Loi("Tên lớp không được để trống!", txtTenLop); return; }

            ThucThi("insert into Lop(MaLop, TenLop, MaKhoa) values(@lop, @ten, @khoa)",
                "Thêm thành công!", true, true);
        }

        // ===== XÓA: chỉ cần Mã lớp =====
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaLop.Text.Trim() == "") { Loi("Mã lớp không được để trống!", txtMaLop); return; }

            ThucThi("delete from Lop where MaLop = @lop", "Xóa thành công!", false, false);
        }

        // ===== SỬA: Mã lớp bắt buộc; Mã khoa, Tên lớp phải có ít nhất 1 trường =====
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaLop.Text.Trim() == "") { Loi("Mã lớp không được để trống!", txtMaLop); return; }

            bool coKhoa = txtMaKhoa.Text.Trim() != "";
            bool coTen = txtTenLop.Text.Trim() != "";
            if (!coKhoa && !coTen)
            {
                Loi("Mã khoa, Tên lớp phải có ít nhất một trường có dữ liệu!", txtMaKhoa);
                return;
            }

            List<string> set = new List<string>();
            if (coKhoa) set.Add("MaKhoa = @khoa");
            if (coTen) set.Add("TenLop = @ten");

            ThucThi("update Lop set " + string.Join(", ", set) + " where MaLop = @lop",
                "Sửa thành công!", coKhoa, coTen);
        }

        private void Loi(string nd, TextBox t)
        {
            MessageBox.Show(nd, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            t.Focus();
            t.SelectAll();
        }

        // dungKhoa / dungTen: có truyền tham số @khoa / @ten hay không
        private void ThucThi(string sql, string thongBao, bool dungKhoa, bool dungTen)
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@lop", txtMaLop.Text.Trim());
                    if (dungKhoa) cmd.Parameters.AddWithValue("@khoa", txtMaKhoa.Text.Trim());
                    if (dungTen) cmd.Parameters.AddWithValue("@ten", txtTenLop.Text.Trim());

                    int soDong = cmd.ExecuteNonQuery();
                    if (soDong == 0)
                    {
                        MessageBox.Show(
                            "Không tìm thấy lớp có mã '" + txtMaLop.Text.Trim() + "'!",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(thongBao, "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMaKhoa.Clear();
                        txtMaLop.Clear();
                        txtTenLop.Clear();
                        txtMaKhoa.Focus();
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

        private string DichLoi(SqlException ex)
        {
            switch (ex.Number)
            {
                case 2627:
                case 2601:
                    return "Mã lớp đã tồn tại!";
                case 547:
                    if (ex.Message.Contains("DELETE"))
                        return "Không thể xóa vì lớp này đang có sinh viên!";
                    if (ex.Message.Contains("dbo.Khoa"))
                        return "Mã khoa không tồn tại!";
                    return "Dữ liệu không hợp lệ hoặc đang được dùng ở bảng khác!";
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