using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ThucHanh06b
{
    public partial class DanhSachLop : Form
    {
        public DanhSachLop()
        {
            InitializeComponent();

            btnHienThi.Click += btnHienThi_Click;
            btnThoat.Click += (s, e) => this.Close();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            // Xóa dữ liệu cũ để bấm nhiều lần không bị lặp dòng
            lvLop.Items.Clear();

            SqlConnection conn = new SqlConnection(Db.ConnStr);
            try
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(
                    "select MaLop, TenLop, MaKhoa from Lop order by MaLop", conn))
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    int stt = 1;
                    while (rd.Read())
                    {
                        ListViewItem item = new ListViewItem(stt.ToString());
                        item.SubItems.Add(rd["MaLop"].ToString());
                        item.SubItems.Add(rd["TenLop"].ToString());
                        item.SubItems.Add(rd["MaKhoa"].ToString());
                        lvLop.Items.Add(item);
                        stt++;
                    }
                }

                if (lvLop.Items.Count == 0)
                    MessageBox.Show("Bảng Lop chưa có dữ liệu!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex) { MessageBox.Show(Db.DichLoi(ex), "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (Exception ex) { MessageBox.Show("Thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { if (conn.State == ConnectionState.Open) conn.Close(); }
        }
    }
}