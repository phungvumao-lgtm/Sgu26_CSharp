using System;
using System.Globalization;
using System.Windows.Forms;

namespace ThucHanh04c
{
    public partial class CongTruNhanChia : Form
    {
        private void label1_Click(object sender, EventArgs e)
        {
        }
        public CongTruNhanChia()
        {
            InitializeComponent();
        }

        private void SoOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            string sep = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;

            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar)) return;           // phím điều khiển, chữ số
            if (e.KeyChar.ToString() == sep && !tb.Text.Contains(sep)) return;            // dấu thập phân (1 lần)
            if (e.KeyChar == '-' && tb.SelectionStart == 0 && !tb.Text.Contains("-")) return; // dấu âm ở đầu

            e.Handled = true;
        }


        private void txt_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            double tmp;
            if (!double.TryParse(tb.Text, out tmp))
                errorProvider1.SetError(tb, "Vui lòng nhập một số hợp lệ!");
            else
                errorProvider1.SetError(tb, "");
        }

  
        private bool LayHaiSo(out double a, out double b)
        {
            bool okA = double.TryParse(txtA.Text, out a);
            bool okB = double.TryParse(txtB.Text, out b);

            errorProvider1.SetError(txtA, okA ? "" : "Vui lòng nhập một số hợp lệ!");
            errorProvider1.SetError(txtB, okB ? "" : "Vui lòng nhập một số hợp lệ!");

            if (!okA)
            {
                MessageBox.Show("Dữ liệu a không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtA.Focus();
                return false;
            }
            if (!okB)
            {
                MessageBox.Show("Dữ liệu b không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtB.Focus();
                return false;
            }
            return true;
        }


        private void btnCong_Click(object sender, EventArgs e)
        {
            double a, b;
            if (LayHaiSo(out a, out b)) txtKetQua.Text = (a + b).ToString();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            double a, b;
            if (LayHaiSo(out a, out b)) txtKetQua.Text = (a - b).ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            double a, b;
            if (LayHaiSo(out a, out b)) txtKetQua.Text = (a * b).ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            double a, b;
            if (!LayHaiSo(out a, out b)) return;

            if (b == 0)
            {
                MessageBox.Show("Không thể chia cho 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtB.Focus();
                return;
            }
            txtKetQua.Text = (a / b).ToString();
        }

   
   
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No) e.Cancel = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtKetQua_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
