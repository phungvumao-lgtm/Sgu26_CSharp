using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ThucHanh06b
{
    public partial class FormThemSanPham : Form
    {
        public FormThemSanPham()
        {
            InitializeComponent();

            this.btnThem.Click += btnThem_Click;
            this.btnThoat.Click += btnThoat_Click;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ten = txtTenSP.Text.Trim();
            if (ten == string.Empty)
            {
                MessageBox.Show("Bạn phải nhập " + lblTenSP.Text);
                txtTenSP.Focus();
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(DbCH.ConnStr))
                {
                    conn.Open();
                    using (SqlTransaction tran = conn.BeginTransaction())
                    {
                        // 1. Thêm sản phẩm (MaSP tự tăng) và lấy mã vừa tạo
                        SqlCommand cmd = new SqlCommand(
                            "INSERT INTO SANPHAM(TenSP) OUTPUT INSERTED.MaSP VALUES(@ten)",
                            conn, tran);
                        cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 100).Value = ten;
                        int maSP = (int)cmd.ExecuteScalar();

                        // 2. Thêm dòng tồn kho hôm nay: SLDau = 0, SLNhap = 0, SLBan = 0
                        SqlCommand cmd2 = new SqlCommand(
                            "INSERT INTO TONKHO(MaSP, NgayTon, SLDau, SLNhap, SLBan) " +
                            "VALUES(@ma, @ngay, 0, 0, 0)", conn, tran);
                        cmd2.Parameters.Add("@ma", SqlDbType.Int).Value = maSP;
                        cmd2.Parameters.Add("@ngay", SqlDbType.Date).Value = DateTime.Today;
                        cmd2.ExecuteNonQuery();

                        tran.Commit();
                        MessageBox.Show("Thêm thành công. Mã sản phẩm: " + maSP);
                    }
                }
                txtTenSP.Clear();
                txtTenSP.Focus();
            }
            catch (SqlException ex) { MessageBox.Show(DbCH.DichLoi(ex)); }
            catch (Exception ex) { MessageBox.Show("Thất bại: " + ex.Message); }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}