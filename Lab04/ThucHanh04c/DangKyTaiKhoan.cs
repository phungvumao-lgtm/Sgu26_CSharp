using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ThucHanh04c
{
    public partial class DangKyTaiKhoan : Form
    {
        private void DangKyTaiKhoan_Load(object sender, EventArgs e)
        {
        }
        public DangKyTaiKhoan()
        {
            InitializeComponent();

            this.AutoValidate = AutoValidate.EnableAllowFocusChange;

        
            txtEmail.Validating += txtEmail_Validating;
            btnDangKy.Click += btnDangKy_Click;
            txtXacNhan.KeyDown += txtXacNhan_KeyDown;
            this.FormClosing += DangKyTaiKhoan_FormClosing;
        }

        
        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            string email = txtEmail.Text.Trim();
            if (email == "") return; 

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                errorProvider1.SetError(txtEmail, "Email không đúng định dạng!");
                MessageBox.Show("Email không đúng định dạng (ví dụ: abc@gmail.com)",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true; 
            }
            else
            {
                errorProvider1.SetError(txtEmail, "");
            }
        }

      
        private bool KiemTraBatBuoc()
        {
            if (txtTenDangNhap.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập Tên đăng nhập!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDangNhap.Focus();
                return false;
            }
            if (txtEmail.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập Địa chỉ email!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }
            if (!Regex.IsMatch(txtEmail.Text.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Email không đúng định dạng!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }
            if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Mật khẩu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
                return false;
            }
            return true;
        }

       
        private void DangKy()
        {
            if (!KiemTraBatBuoc()) return;

            string thongTin =
                "Tên đăng nhập: " + txtTenDangNhap.Text + "\n" +
                "Địa chỉ email: " + txtEmail.Text + "\n" +
                "Mật khẩu: " + txtMatKhau.Text + "\n" +
                "Xác nhận mật khẩu: " + txtXacNhan.Text;

            MessageBox.Show(thongTin, "Thông tin đăng ký",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            DangKy();
        }


        private void txtXacNhan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; 
                DangKy();
            }
        }

  
        private void DangKyTaiKhoan_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}