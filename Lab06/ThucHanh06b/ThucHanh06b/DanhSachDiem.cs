using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ThucHanh06b
{
    public partial class DanhSachDiem : Form
    {
        public DanhSachDiem()
        {
            InitializeComponent();

            this.Load += DanhSachDiem_Load;
            btnLoc.Click += btnLoc_Click;
        }

        // Form Load: đổ mã môn học (kèm 1 item trống = tất cả) và hiển thị toàn bộ điểm
        private void DanhSachDiem_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Db.ConnStr);
            try
            {
                conn.Open();
                cboMon.Items.Clear();
                cboMon.Items.Add("");   // khoảng trắng = tất cả môn học
                using (SqlCommand cmd = new SqlCommand("select MaMonHoc from MonHoc order by MaMonHoc", conn))
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                        cboMon.Items.Add(rd["MaMonHoc"].ToString());
                }
                cboMon.SelectedIndex = 0;
            }
            catch (SqlException ex) { MessageBox.Show(Db.DichLoi(ex), "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            catch (Exception ex) { MessageBox.Show("Thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            finally { if (conn.State == ConnectionState.Open) conn.Close(); }

            HienThiDiem();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            HienThiDiem();
        }

        // Hiển thị điểm lên ListView theo môn đang chọn, đồng thời tính tổng điểm
        private void HienThiDiem()
        {
            lvDiem.Items.Clear();
            txtTong.Clear();

            string maMon = cboMon.SelectedItem == null ? "" : cboMon.SelectedItem.ToString();

            string sql =
                "select sv.HoTen, sv.NgaySinh, mh.TenMonHoc, d.Diem " +
                "from Diem d " +
                "join SinhVien sv on sv.MaSinhVien = d.MaSinhVien " +
                "join MonHoc mh on mh.MaMonHoc = d.MaMonHoc ";
            if (maMon != "") sql += "where d.MaMonHoc = @mh ";
            sql += "order by sv.HoTen, mh.TenMonHoc";

            SqlConnection conn = new SqlConnection(Db.ConnStr);
            try
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (maMon != "") cmd.Parameters.AddWithValue("@mh", maMon);

                    decimal tong = 0;
                    int stt = 1;
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            decimal diem = Convert.ToDecimal(rd["Diem"]);
                            tong += diem;

                            ListViewItem item = new ListViewItem(stt.ToString());
                            item.SubItems.Add(rd["HoTen"].ToString());
                            item.SubItems.Add(Convert.ToDateTime(rd["NgaySinh"]).ToString("dd/MM/yyyy"));
                            item.SubItems.Add(rd["TenMonHoc"].ToString());
                            item.SubItems.Add(diem.ToString("0.##"));
                            lvDiem.Items.Add(item);
                            stt++;
                        }
                    }
                    txtTong.Text = tong.ToString("0.##");
                }

                if (lvDiem.Items.Count == 0)
                    MessageBox.Show("Không có điểm nào để hiển thị!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex) { MessageBox.Show(Db.DichLoi(ex), "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (Exception ex) { MessageBox.Show("Thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { if (conn.State == ConnectionState.Open) conn.Close(); }
        }
    }
}