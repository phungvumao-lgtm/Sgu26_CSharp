using System;
using System.Windows.Forms;

namespace ThucHanh04c
{
    public partial class MayTinh : Form
    {
        private double soThuNhat = 0;
        private string phepTinh = "";
        private bool nhapSoMoi = true;

        public MayTinh()
        {
            InitializeComponent();

            
            for (int i = 0; i <= 9; i++)
            {
                Control[] ds = this.Controls.Find("btn" + i, true);
                if (ds.Length > 0)
                    ds[0].Click += NutSo_Click;
            }

           
            btnCong.Click += (s, e) => ChonPhep("+");
            btnTru.Click += (s, e) => ChonPhep("-");
            btnNhan.Click += (s, e) => ChonPhep("*");
            btnChia.Click += (s, e) => ChonPhep("/");

            btnBang.Click += btnBang_Click;
            btnXoa.Click += btnXoa_Click;
        }

      
        private void NutSo_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (nhapSoMoi || txtKetQua.Text == "0")
            {
                txtKetQua.Text = b.Text;
                nhapSoMoi = false;
            }
            else
            {
                txtKetQua.Text += b.Text;
            }
        }

  
        private void ChonPhep(string pt)
        {
           
            if (phepTinh != "" && !nhapSoMoi)
            {
                if (!TinhKetQua()) return;
            }
            else
            {
                double.TryParse(txtKetQua.Text, out soThuNhat);
            }

            phepTinh = pt;
            nhapSoMoi = true;
        }

        private bool TinhKetQua()
        {
            double soThuHai;
            double.TryParse(txtKetQua.Text, out soThuHai);
            double kq = soThuNhat;

            switch (phepTinh)
            {
                case "+": kq = soThuNhat + soThuHai; break;
                case "-": kq = soThuNhat - soThuHai; break;
                case "*": kq = soThuNhat * soThuHai; break;
                case "/":
                    if (soThuHai == 0)
                    {
                        MessageBox.Show("Không thể chia cho 0!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        XoaTatCa();
                        return false;
                    }
                    kq = soThuNhat / soThuHai;
                    break;
            }

            txtKetQua.Text = kq.ToString();
            soThuNhat = kq;
            return true;
        }
  
   
        private void btnBang_Click(object sender, EventArgs e)
        {
            if (phepTinh == "") return;
            if (TinhKetQua())
            {
                phepTinh = "";
                nhapSoMoi = true;
            }
        }

  
        private void btnXoa_Click(object sender, EventArgs e)
        {
            XoaTatCa();
        }

        private void XoaTatCa()
        {
            soThuNhat = 0;
            phepTinh = "";
            nhapSoMoi = true;
            txtKetQua.Text = "0";
        }
    }
}