using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ThucHanh04c
{
    public partial class DaySo : Form
    {
  
        private List<int> ds = new List<int>();

        public DaySo()
        {
            InitializeComponent();

            btnNhap.Click += btnNhap_Click;
            btnTinhTong.Click += btnTinhTong_Click;
            btnTongChan.Click += btnTongChan_Click;
            btnTongLe.Click += btnTongLe_Click;
            btnTiepTuc.Click += btnTiepTuc_Click;
            btnThoat.Click += btnThoat_Click;
            txtNhapSo.KeyDown += txtNhapSo_KeyDown;
        }


        private void btnNhap_Click(object sender, EventArgs e)
        {
            int so;
            if (txtNhapSo.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập một số nguyên!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNhapSo.Focus();
                return;
            }
            if (!int.TryParse(txtNhapSo.Text.Trim(), out so))
            {
                MessageBox.Show("Dữ liệu phải là số nguyên!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNhapSo.Focus();
                txtNhapSo.SelectAll();
                return;
            }

            ds.Add(so);
            txtDay.Text = string.Join(" ", ds);

            txtNhapSo.Clear();
            txtNhapSo.Focus();
        }

     
        private void txtNhapSo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnNhap_Click(sender, e);
            }
        }

        private bool CoDuLieu()
        {
            if (ds.Count == 0)
            {
                MessageBox.Show("Chưa có số nào trong dãy. Hãy nhập số trước!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNhapSo.Focus();
                return false;
            }
            return true;
        }

        
        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            if (!CoDuLieu()) return;
            long tong = 0;
            foreach (int x in ds) tong += x;
            txtTong.Text = tong.ToString();
        }

       
        private void btnTongChan_Click(object sender, EventArgs e)
        {
            if (!CoDuLieu()) return;
            long tong = 0;
            foreach (int x in ds)
                if (x % 2 == 0) tong += x;
            txtTongChan.Text = tong.ToString();
        }

      
        private void btnTongLe_Click(object sender, EventArgs e)
        {
            if (!CoDuLieu()) return;
            long tong = 0;
            foreach (int x in ds)
                if (x % 2 != 0) tong += x;
            txtTongLe.Text = tong.ToString();
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            ds.Clear();
            txtNhapSo.Clear();
            txtDay.Clear();
            txtTong.Clear();
            txtTongChan.Clear();
            txtTongLe.Clear();
            txtNhapSo.Focus();
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