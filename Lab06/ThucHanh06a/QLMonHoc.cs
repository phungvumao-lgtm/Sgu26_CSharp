using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ThucHanh06a
{
    public partial class QLMonHoc : Form
    {
        // Chứng thực Windows. Sửa Data Source cho đúng tên server của bạn
        // Kết nối SQL Server chạy trong Docker
        private SqlConnection conn = new SqlConnection(
            "Data Source=localhost,1433;Initial Catalog=QLSinhVien;" +
            "User ID=sa;Password=Matkhau@123;TrustServerCertificate=True");

        public QLMonHoc()
        {
            InitializeComponent();

            btnThem.Click += btnThem_Click;
            btnXoa.Click += btnXoa_Click;
            btnSua.Click += btnSua_Click;
        }

        // Thêm: Mã môn học và Tên môn học không được để trống
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraMa()) return;
            if (!KiemTraTen()) return;

            ThucThi("insert into MonHoc(MaMonHoc, TenMonHoc) values(@ma, @ten)",
                    "Thêm thành công!", true);
        }

        // Xóa: chỉ cần Mã môn học, không quan tâm Tên môn học
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!KiemTraMa()) return;

            ThucThi("delete from MonHoc where MaMonHoc = @ma",
                    "Xóa thành công!", false);
        }

        // Sửa: Mã và Tên đều không được để trống
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!KiemTraMa()) return;
            if (!KiemTraTen()) return;

            ThucThi("update MonHoc set TenMonHoc = @ten where MaMonHoc = @ma",
                    "Sửa thành công!", true);
        }

        private bool KiemTraMa()
        {
            if (txtMaMH.Text.Trim() == "")
            {
                MessageBox.Show("Mã môn học không được để trống!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaMH.Focus();
                return false;
            }
            return true;
        }

        private bool KiemTraTen()
        {
            if (txtTenMH.Text.Trim() == "")
            {
                MessageBox.Show("Tên môn học không được để trống!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenMH.Focus();
                return false;
            }
            return true;
        }

        // Dùng chung cho Thêm / Xóa / Sửa
        private void ThucThi(string sql, string thongBao, bool dungTen)
        {
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ma", txtMaMH.Text.Trim());
                    if (dungTen)
                        cmd.Parameters.AddWithValue("@ten", txtTenMH.Text.Trim());

                    int soDong = cmd.ExecuteNonQuery();
                    if (soDong == 0)
                    {
                        MessageBox.Show("Không tìm thấy môn học có mã '" + txtMaMH.Text.Trim() + "'!",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(thongBao, "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMaMH.Clear();
                        txtTenMH.Clear();
                        txtMaMH.Focus();
                    }
                }
            }
            catch (SqlException ex)
            {
                // 2627/2601: trùng khóa chính; 547: vướng khóa ngoại (môn học đã có điểm)
                if (ex.Number == 2627 || ex.Number == 2601)
                    MessageBox.Show("Mã môn học đã tồn tại!", "Thất bại",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (ex.Number == 547)
                    MessageBox.Show("Không thể xóa/sửa vì môn học này đang được dùng ở bảng khác!",
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
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
        }
    }
}