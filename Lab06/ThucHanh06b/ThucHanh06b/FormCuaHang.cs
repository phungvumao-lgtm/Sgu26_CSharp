using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ThucHanh06b
{
    public partial class FormCuaHang : Form
    {
        public FormCuaHang()
        {
            InitializeComponent();

            // Gắn sự kiện tại đây (không đặt trong Designer)
            this.mnuTaoTonKho.Click += mnuTaoTonKho_Click;
            this.mnuThemSP.Click += mnuThemSP_Click;
            this.mnuBanHang.Click += mnuBanHang_Click;
        }

        // Tạo tồn kho cho ngày hiện tại
        // SLDau(hôm nay) = SLDau + SLNhap - SLBan của ngày gần nhất trước đó
        private void mnuTaoTonKho_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbCH.ConnStr))
                {
                    conn.Open();

                    SqlCommand kt = new SqlCommand(
                        "SELECT COUNT(*) FROM TONKHO WHERE NgayTon = @ngay", conn);
                    kt.Parameters.Add("@ngay", SqlDbType.Date).Value = DateTime.Today;
                    if ((int)kt.ExecuteScalar() > 0)
                    {
                        MessageBox.Show("Hôm nay đã tạo tồn kho rồi!");
                        return;
                    }

                    string sql =
                        "INSERT INTO TONKHO(MaSP, NgayTon, SLDau, SLNhap, SLBan) " +
                        "SELECT t.MaSP, @ngay, t.SLDau + t.SLNhap - t.SLBan, 0, 0 " +
                        "FROM TONKHO t " +
                        "WHERE t.NgayTon = (SELECT MAX(NgayTon) FROM TONKHO " +
                        "                   WHERE MaSP = t.MaSP AND NgayTon < @ngay)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.Add("@ngay", SqlDbType.Date).Value = DateTime.Today;
                    int n = cmd.ExecuteNonQuery();
                    MessageBox.Show("Tạo tồn kho thành công cho " + n + " sản phẩm.");
                }
            }
            catch (SqlException ex) { MessageBox.Show(DbCH.DichLoi(ex)); }
            catch (Exception ex) { MessageBox.Show("Thất bại: " + ex.Message); }
        }

        private void mnuThemSP_Click(object sender, EventArgs e)
        {
            using (FormThemSanPham f = new FormThemSanPham())
                f.ShowDialog(this);
        }

        private void mnuBanHang_Click(object sender, EventArgs e)
        {
            using (FormBanHang f = new FormBanHang())
                f.ShowDialog(this);
        }
    }
}