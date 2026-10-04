using System;
using System.Windows.Forms;

namespace ThucHanh04c
{
    public partial class UocBoiSo : Form
    {
        public UocBoiSo()
        {
            InitializeComponent();

            btnThucHien.Click += btnThucHien_Click;
            btnTiepTuc.Click += btnTiepTuc_Click;
            btnThoat.Click += btnThoat_Click;
        }

        private long UCLN(long a, long b)
        {
            while (b != 0)
            {
                long r = a % b;
                a = b;
                b = r;
            }
            return a;
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            long a, b;

            if (txtA.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập số a!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtA.Focus();
                return;
            }
            if (!long.TryParse(txtA.Text.Trim(), out a))
            {
                MessageBox.Show("Số a phải là số nguyên!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtA.Focus();
                txtA.SelectAll();
                return;
            }
            if (txtB.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập số b!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtB.Focus();
                return;
            }
            if (!long.TryParse(txtB.Text.Trim(), out b))
            {
                MessageBox.Show("Số b phải là số nguyên!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtB.Focus();
                txtB.SelectAll();
                return;
            }
            if (a <= 0 || b <= 0)
            {
                MessageBox.Show("Số a và b phải lớn hơn 0!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtA.Focus();
                return;
            }

            long uc = UCLN(a, b);
            long bc = a / uc * b; 

            txtUCLN.Text = uc.ToString();
            txtBCNN.Text = bc.ToString();
        }

  
        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtUCLN.Clear();
            txtBCNN.Clear();
            txtA.Focus();
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