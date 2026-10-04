using System;
using System.Windows.Forms;

namespace ThucHanh04d
{
    public partial class MangSo : Form
    {
        private MangSoNguyen mang = new MangSoNguyen();

        public MangSo()
        {
            InitializeComponent();

            this.Load += MangSo_Load;
            this.FormClosing += MangSo_FormClosing;

            btnNhapMang.Click += btnNhapMang_Click;
            btnReset.Click += btnReset_Click;
            btnThoat.Click += (s, e) => this.Close();
            btnThucHien.Click += btnThucHien_Click;
            btnTong.Click += btnTong_Click;
            btnTim.Click += btnTim_Click;

            // Nhấn Enter trong các ô nhập để thực hiện chức năng tương ứng
            GanEnter(txtNhapMang, () => btnNhapMang_Click(null, null));
            GanEnter(txtTimGiaTri, TimKiem);
            GanEnter(txtTimViTri, TimKiem);
            GanEnter(txtXoaGiaTri, XoaPhanTu);
            GanEnter(txtXoaViTri, XoaPhanTu);
            GanEnter(txtThemGiaTri, ThemPhanTu);
            GanEnter(txtThemViTri, ThemPhanTu);
            GanEnter(txtThayGiaTri, ThayThe);
            GanEnter(txtThayViTri, ThayThe);
            GanEnter(txtSoThay, ThayThe);
        }

        private void GanEnter(TextBox t, Action hanhDong)
        {
            t.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    hanhDong();
                }
            };
        }

        private void MangSo_Load(object sender, EventArgs e)
        {
            DatLaiMacDinh();
        }

        // ===== Hàm hỗ trợ =====
        private void Loi(string nd, TextBox t)
        {
            MessageBox.Show(nd, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (t != null) { t.Focus(); t.SelectAll(); }
        }

        private bool DocSo(TextBox t, string ten, out int v)
        {
            v = 0;
            if (t.Text.Trim() == "")
            {
                Loi("Vui lòng nhập " + ten + "!", t);
                return false;
            }
            if (!int.TryParse(t.Text.Trim(), out v))
            {
                Loi(ten + " phải là số nguyên!", t);
                return false;
            }
            return true;
        }

        private bool CoMang()
        {
            if (mang.SoPhanTu == 0)
            {
                MessageBox.Show("Chưa có mảng. Hãy nhập mảng trước!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNhapMang.Focus();
                return false;
            }
            return true;
        }

        private bool CanSapTang()
        {
            if (!mang.DaSapXepTang())
            {
                MessageBox.Show("Mảng cần được sắp xếp tăng trước!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void HienThiMang()
        {
            txtKetQuaMang.Text = mang.ToString();
        }

        private void DatLaiMacDinh()
        {
            mang.Xoa();
            rdTang.Checked = true;
            rdTimGiaTri.Checked = true;
            rdXoaGiaTri.Checked = true;
            rdThayGiaTri.Checked = true;

            foreach (TextBox t in new TextBox[] {
                txtNhapMang, txtKetQuaMang, txtTimGiaTri, txtTimViTri, txtSoTimDuoc,
                txtXoaGiaTri, txtXoaViTri, txtThemGiaTri, txtThemViTri,
                txtTongMang, txtTongChan, txtTongLe, txtMax, txtMin,
                txtThayGiaTri, txtThayViTri, txtSoThay })
            {
                t.Clear();
            }
            txtNhapMang.Focus();
        }

        // ===== Các chức năng =====
        private void btnNhapMang_Click(object sender, EventArgs e)
        {
            string loi;
            if (!mang.Nhap(txtNhapMang.Text, out loi))
            {
                Loi(loi, txtNhapMang);
                return;
            }
            HienThiMang();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DatLaiMacDinh();
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            if (!CoMang()) return;
            mang.SapXep(rdTang.Checked);
            HienThiMang();
        }

        // Tìm giá trị -> cho ra vị trí; tìm vị trí -> cho ra giá trị (vị trí tính từ 0)
        private void TimKiem()
        {
            if (!CoMang()) return;
            int v;
            if (rdTimGiaTri.Checked)
            {
                if (!DocSo(txtTimGiaTri, "giá trị cần tìm", out v)) return;
                int vt = mang.TimGiaTri(v);
                txtSoTimDuoc.Text = vt >= 0 ? vt.ToString() : "Không có";
            }
            else
            {
                if (!DocSo(txtTimViTri, "vị trí cần tìm", out v)) return;
                if (!mang.HopLeViTri(v))
                {
                    Loi("Vị trí phải từ 0 đến " + (mang.SoPhanTu - 1) + "!", txtTimViTri);
                    return;
                }
                txtSoTimDuoc.Text = mang.LayGiaTri(v).ToString();
            }
        }

        private void XoaPhanTu()
        {
            if (!CoMang() || !CanSapTang()) return;
            int v;
            if (rdXoaGiaTri.Checked)
            {
                if (!DocSo(txtXoaGiaTri, "giá trị cần xóa", out v)) return;
                if (!mang.XoaGiaTri(v))
                {
                    Loi("Không tìm thấy giá trị " + v + " trong mảng!", txtXoaGiaTri);
                    return;
                }
            }
            else
            {
                if (!DocSo(txtXoaViTri, "vị trí cần xóa", out v)) return;
                if (!mang.XoaViTri(v))
                {
                    Loi("Vị trí phải từ 0 đến " + (mang.SoPhanTu - 1) + "!", txtXoaViTri);
                    return;
                }
            }
            HienThiMang();
        }

        private void ThemPhanTu()
        {
            if (!CoMang() || !CanSapTang()) return;
            int gt, vt;
            if (!DocSo(txtThemGiaTri, "giá trị cần thêm", out gt)) return;
            if (!DocSo(txtThemViTri, "vị trí cần thêm", out vt)) return;
            if (!mang.Them(gt, vt))
            {
                Loi("Vị trí phải từ 0 đến " + mang.SoPhanTu + "!", txtThemViTri);
                return;
            }
            HienThiMang();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            if (!CoMang()) return;
            txtTongMang.Text = mang.Tong().ToString();
            txtTongChan.Text = mang.TongChan().ToString();
            txtTongLe.Text = mang.TongLe().ToString();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (!CoMang()) return;
            txtMax.Text = mang.Max().ToString();
            txtMin.Text = mang.Min().ToString();
        }

        private void ThayThe()
        {
            if (!CoMang()) return;
            int moi, v;
            if (rdThayGiaTri.Checked)
            {
                if (!DocSo(txtThayGiaTri, "giá trị cần thay", out v)) return;
                if (!DocSo(txtSoThay, "số thay thế", out moi)) return;
                if (mang.ThayGiaTri(v, moi) == 0)
                {
                    Loi("Không tìm thấy giá trị " + v + " trong mảng!", txtThayGiaTri);
                    return;
                }
            }
            else
            {
                if (!DocSo(txtThayViTri, "vị trí cần thay", out v)) return;
                if (!DocSo(txtSoThay, "số thay thế", out moi)) return;
                if (!mang.ThayViTri(v, moi))
                {
                    Loi("Vị trí phải từ 0 đến " + (mang.SoPhanTu - 1) + "!", txtThayViTri);
                    return;
                }
            }
            HienThiMang();
        }

        // Xác nhận khi đóng form (cả nút Thoát lẫn nút X)
        private void MangSo_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.No) e.Cancel = true;
        }
    }
}