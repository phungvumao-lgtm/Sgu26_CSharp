using System;
using System.Windows.Forms;

namespace ThucHanh04c
{
    public partial class DocSo : Form
    {
        private readonly string[] chu =
            { "Không", "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín" };

        public DocSo()
        {
            InitializeComponent();

            btnThucHien.Click += btnThucHien_Click;
            btnXoa.Click += btnXoa_Click;
            btnThoat.Click += btnThoat_Click;
            txtSo.KeyDown += txtSo_KeyDown;
        }

 
        private string DocSoThanhChu(int n)
        {
            int tram = n / 100;
            int chuc = (n % 100) / 10;
            int donvi = n % 10;
            string kq = "";

            if (tram > 0)
            {
                kq += chu[tram] + " Trăm";
            }

            if (chuc > 1)
            {
                kq += " " + chu[chuc] + " Mươi";
                if (donvi == 1) kq += " Mốt";
                else if (donvi == 4) kq += " Tư";
                else if (donvi == 5) kq += " Lăm";
                else if (donvi > 0) kq += " " + chu[donvi];
            }
            else if (chuc == 1)
            {
                kq += " Mười";
                if (donvi == 5) kq += " Lăm";
                else if (donvi > 0) kq += " " + chu[donvi];
            }
            else 
                if (donvi > 0)
                {
                    if (tram > 0) kq += " Linh";
                    kq += " " + chu[donvi];
                }
            }

            return kq.Trim();
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            int n;
            if (txtSo.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập một số!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSo.Focus();
                return;
            }
            if (!int.TryParse(txtSo.Text.Trim(), out n))
            {
                MessageBox.Show("Dữ liệu phải là số nguyên dương!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSo.Focus();
                txtSo.SelectAll();
                return;
            }
            if (n < 1 || n > 999)
            {
                MessageBox.Show("Vui lòng nhập số từ 1 đến 999!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSo.Focus();
                txtSo.SelectAll();
                return;
            }

            lblKetQua.Text = DocSoThanhChu(n);
        }

     
        private void txtSo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnThucHien_Click(sender, e);
            }
        }

     
        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtSo.Clear();
            lblKetQua.Text = "";
            txtSo.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
 }
