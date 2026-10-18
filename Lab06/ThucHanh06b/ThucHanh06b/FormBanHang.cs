using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ThucHanh06b
{
    public partial class FormBanHang : Form
    {
        public FormBanHang()
        {
            InitializeComponent();

            this.btnTaoHD.Click += btnTaoHD_Click;
            this.btnThem.Click += btnThem_Click;
            this.btnHuy.Click += btnHuy_Click;
            this.btnThanhToan.Click += btnThanhToan_Click;
        }

        // Hiển thị mã sản phẩm lên comboBox ("MaSP - TenSP", giá trị là MaSP)
        private void LoadSanPham_ComboBox()
        {
            using (SqlConnection conn = new SqlConnection(DbCH.ConnStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "SELECT MaSP, CAST(MaSP AS nvarchar(10)) + N' - ' + TenSP AS Hien FROM SANPHAM", conn);
                DataTable dt = new DataTable();
                using (SqlDataReader rd = cmd.ExecuteReader())
                    dt.Load(rd);

                cboSanPham.DataSource = dt;
                cboSanPham.DisplayMember = "Hien";
                cboSanPham.ValueMember = "MaSP";
            }
        }

        // Đưa form về trạng thái ban đầu (mờ các control)
        private void ResetGiaoDien()
        {
            txtMaHD.Clear();
            txtSoLuong.Clear();
            grpChiTiet.Enabled = false;
            btnThanhToan.Enabled = false;
            btnTaoHD.Enabled = true;
        }

        // Tạo hóa đơn mới
        private void btnTaoHD_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbCH.ConnStr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO HOADON(NgayTao, TinhTrangThanhToan) " +
                        "OUTPUT INSERTED.MaHD VALUES(@ngay, 0)", conn);
                    cmd.Parameters.Add("@ngay", SqlDbType.Date).Value = DateTime.Today;
                    int maHD = (int)cmd.ExecuteScalar();
                    txtMaHD.Text = maHD.ToString();
                }

                LoadSanPham_ComboBox();
                txtSoLuong.Clear();
                grpChiTiet.Enabled = true;
                btnThanhToan.Enabled = true;
                btnTaoHD.Enabled = false;
            }
            catch (SqlException ex) { MessageBox.Show(DbCH.DichLoi(ex)); }
            catch (Exception ex) { MessageBox.Show("Thất bại: " + ex.Message); }
        }

        // Thêm một dòng vào chi tiết hóa đơn + cập nhật tồn kho
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cboSanPham.SelectedValue == null)
            {
                MessageBox.Show("Bạn phải chọn " + lblMaSP.Text);
                return;
            }
            int soLuong;
            if (!int.TryParse(txtSoLuong.Text.Trim(), out soLuong) || soLuong <= 0)
            {
                MessageBox.Show(lblSoLuong.Text + " phải là số nguyên lớn hơn 0");
                txtSoLuong.Focus();
                return;
            }

            int maHD = int.Parse(txtMaHD.Text);
            int maSP = Convert.ToInt32(cboSanPham.SelectedValue);

            try
            {
                using (SqlConnection conn = new SqlConnection(DbCH.ConnStr))
                {
                    conn.Open();

                    // 1. Kiểm tra khóa chính (MaHD, MaSP) bằng SqlDataReader
                    SqlCommand cmdKT = new SqlCommand(
                        "SELECT * FROM CHITIET_HOADON WHERE MaHD = @hd AND MaSP = @sp", conn);
                    cmdKT.Parameters.Add("@hd", SqlDbType.Int).Value = maHD;
                    cmdKT.Parameters.Add("@sp", SqlDbType.Int).Value = maSP;
                    using (SqlDataReader rd = cmdKT.ExecuteReader())
                    {
                        if (rd.HasRows)
                        {
                            MessageBox.Show("Sản phẩm này đã có trong hóa đơn (trùng khóa chính)!");
                            return;
                        }
                    }

                    // 2. Kiểm tra khóa ngoại + số lượng tồn trong TONKHO hôm nay
                    SqlCommand cmdTon = new SqlCommand(
                        "SELECT SLDau + SLNhap - SLBan FROM TONKHO " +
                        "WHERE MaSP = @sp AND NgayTon = @ngay", conn);
                    cmdTon.Parameters.Add("@sp", SqlDbType.Int).Value = maSP;
                    cmdTon.Parameters.Add("@ngay", SqlDbType.Date).Value = DateTime.Today;
                    object kq = cmdTon.ExecuteScalar();
                    if (kq == null)
                    {
                        MessageBox.Show("Chưa có tồn kho hôm nay cho sản phẩm này.\n" +
                                        "Hãy chọn menu \"Tạo tồn kho\" trước khi bán hàng.");
                        return;
                    }
                    int slTon = Convert.ToInt32(kq);
                    if (soLuong > slTon)
                    {
                        MessageBox.Show("Số lượng bán vượt quá số lượng tồn (còn " + slTon + ")!");
                        txtSoLuong.Focus();
                        return;
                    }

                    // 3. Thêm chi tiết + cập nhật SLBan trong cùng 1 transaction
                    using (SqlTransaction tran = conn.BeginTransaction())
                    {
                        SqlCommand cmdThem = new SqlCommand(
                            "INSERT INTO CHITIET_HOADON(MaHD, MaSP, SoLuong) VALUES(@hd, @sp, @sl)",
                            conn, tran);
                        cmdThem.Parameters.Add("@hd", SqlDbType.Int).Value = maHD;
                        cmdThem.Parameters.Add("@sp", SqlDbType.Int).Value = maSP;
                        cmdThem.Parameters.Add("@sl", SqlDbType.Int).Value = soLuong;
                        cmdThem.ExecuteNonQuery();

                        SqlCommand cmdCapNhat = new SqlCommand(
                            "UPDATE TONKHO SET SLBan = SLBan + @sl " +
                            "WHERE MaSP = @sp AND NgayTon = @ngay", conn, tran);
                        cmdCapNhat.Parameters.Add("@sl", SqlDbType.Int).Value = soLuong;
                        cmdCapNhat.Parameters.Add("@sp", SqlDbType.Int).Value = maSP;
                        cmdCapNhat.Parameters.Add("@ngay", SqlDbType.Date).Value = DateTime.Today;
                        cmdCapNhat.ExecuteNonQuery();

                        tran.Commit();
                    }
                    MessageBox.Show("Thêm thành công");
                    txtSoLuong.Clear();
                }
            }
            catch (SqlException ex) { MessageBox.Show(DbCH.DichLoi(ex)); }
            catch (Exception ex) { MessageBox.Show("Thất bại: " + ex.Message); }
        }

        // Hủy hóa đơn: hoàn lại SLBan, xóa chi tiết và hóa đơn
        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hủy hóa đơn " + txtMaHD.Text + "?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                int maHD = int.Parse(txtMaHD.Text);
                using (SqlConnection conn = new SqlConnection(DbCH.ConnStr))
                {
                    conn.Open();
                    using (SqlTransaction tran = conn.BeginTransaction())
                    {
                        SqlCommand c1 = new SqlCommand(
                            "UPDATE t SET t.SLBan = t.SLBan - c.SoLuong " +
                            "FROM TONKHO t JOIN CHITIET_HOADON c ON c.MaSP = t.MaSP " +
                            "WHERE c.MaHD = @hd AND t.NgayTon = @ngay", conn, tran);
                        c1.Parameters.Add("@hd", SqlDbType.Int).Value = maHD;
                        c1.Parameters.Add("@ngay", SqlDbType.Date).Value = DateTime.Today;
                        c1.ExecuteNonQuery();

                        SqlCommand c2 = new SqlCommand(
                            "DELETE FROM CHITIET_HOADON WHERE MaHD = @hd", conn, tran);
                        c2.Parameters.Add("@hd", SqlDbType.Int).Value = maHD;
                        c2.ExecuteNonQuery();

                        SqlCommand c3 = new SqlCommand(
                            "DELETE FROM HOADON WHERE MaHD = @hd", conn, tran);
                        c3.Parameters.Add("@hd", SqlDbType.Int).Value = maHD;
                        c3.ExecuteNonQuery();

                        tran.Commit();
                    }
                }
                MessageBox.Show("Đã hủy hóa đơn");
                ResetGiaoDien();
            }
            catch (SqlException ex) { MessageBox.Show(DbCH.DichLoi(ex)); }
            catch (Exception ex) { MessageBox.Show("Thất bại: " + ex.Message); }
        }

        // Thanh toán: đặt tình trạng hóa đơn = 1
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                int maHD = int.Parse(txtMaHD.Text);
                using (SqlConnection conn = new SqlConnection(DbCH.ConnStr))
                {
                    conn.Open();

                    SqlCommand kt = new SqlCommand(
                        "SELECT COUNT(*) FROM CHITIET_HOADON WHERE MaHD = @hd", conn);
                    kt.Parameters.Add("@hd", SqlDbType.Int).Value = maHD;
                    if ((int)kt.ExecuteScalar() == 0)
                    {
                        MessageBox.Show("Hóa đơn chưa có sản phẩm nào!");
                        return;
                    }

                    SqlCommand cmd = new SqlCommand(
                        "UPDATE HOADON SET TinhTrangThanhToan = 1 WHERE MaHD = @hd", conn);
                    cmd.Parameters.Add("@hd", SqlDbType.Int).Value = maHD;
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Thanh toán thành công");
                ResetGiaoDien();
            }
            catch (SqlException ex) { MessageBox.Show(DbCH.DichLoi(ex)); }
            catch (Exception ex) { MessageBox.Show("Thất bại: " + ex.Message); }
        }
    }
}