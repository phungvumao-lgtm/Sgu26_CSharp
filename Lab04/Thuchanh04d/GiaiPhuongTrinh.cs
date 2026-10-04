using System;
using System.Windows.Forms;
using Thuchanh04d;

namespace ThucHanh04c
{
    public partial class GiaiPhuongTrinh : Form
    {
        public GiaiPhuongTrinh()
        {
            InitializeComponent();

            this.Load += GiaiPhuongTrinh_Load;
            this.FormClosing += GiaiPhuongTrinh_FormClosing;
            rdBacNhat.CheckedChanged += Radio_CheckedChanged;
            rdBacHai.CheckedChanged += Radio_CheckedChanged;
            txtA.TextChanged += KiemTraNut;
            txtB.TextChanged += KiemTraNut;
            txtC.TextChanged += KiemTraNut;
            btnGiai.Click += btnGiai_Click;
            btnThoat.Click += btnThoat_Click;
        }

 
        private void GiaiPhuongTrinh_Load(object sender, EventArgs e)
        {
            rdBacNhat.Checked = true;
            CapNhatGiaoDien();
        }

        private void Radio_CheckedChanged(object sender, EventArgs e)
        {
            CapNhatGiaoDien();
        }

    
        private void CapNhatGiaoDien()
        {
            txtC.Enabled = rdBacHai.Checked;
            if (!txtC.Enabled) txtC.Clear();
            txtKetQua.Clear();
            KiemTraNut(null, null);
        }

 
        private void KiemTraNut(object sender, EventArgs e)
        {
            bool du = txtA.Text.Trim() != "" && txtB.Text.Trim() != "";
            if (rdBacHai.Checked)
                du = du && txtC.Text.Trim() != "";
            btnGiai.Enabled = du;
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            double a, b, c = 0;

            if (!double.TryParse(txtA.Text.Trim(), out a))
            {
                BaoLoi("Hệ số a phải là số!", txtA);
                return;
            }
            if (!double.TryParse(txtB.Text.Trim(), out b))
            {
                BaoLoi("Hệ số b phải là số!", txtB);
                return;
            }
            if (rdBacHai.Checked && !double.TryParse(txtC.Text.Trim(), out c))
            {
                BaoLoi("Hệ số c phải là số!", txtC);
                return;
            }

            PhuongTrinhBacHai pt = new PhuongTrinhBacHai(a, b, c);
            txtKetQua.Text = rdBacNhat.Checked ? pt.GiaiBacNhat() : pt.GiaiBacHai();
        }

        private void BaoLoi(string noiDung, TextBox txt)
        {
            MessageBox.Show(noiDung, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txt.Focus();
            txt.SelectAll();
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   
        private void GiaiPhuongTrinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}