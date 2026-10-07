using System;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Lab05
{
    public partial class Thuchanh05a : Form
    {
        private DataTable dt = new DataTable();

        public Thuchanh05a()
        {
            InitializeComponent();

            // Bảng order gồm 2 cột
            dt.Columns.Add("FoodName");
            dt.Columns.Add("Quantity", typeof(int));

            // Gắn 2 cột của lưới vào 2 cột của DataTable
            dgvOrder.AutoGenerateColumns = false;
            colMon.DataPropertyName = "FoodName";
            colSoLuong.DataPropertyName = "Quantity";
            dgvOrder.DataSource = dt;

            // Danh sách bàn
            for (int i = 1; i <= 10; i++)
                cboBan.Items.Add("Bàn " + i);

            // Gắn sự kiện Click cho mọi nút món ăn trong GroupBox
            foreach (Control c in grpDanhMuc.Controls)
            {
                if (c is Button)
                    c.Click += NutMon_Click;
            }

            btnXoa.Click += btnXoa_Click;
            btnOrder.Click += btnOrder_Click;
            this.FormClosing += Thuchanh05a_FormClosing;
        }

        // Bấm món: chưa có thì thêm dòng số lượng 1, có rồi thì tăng 1
        private void NutMon_Click(object sender, EventArgs e)
        {
            if (cboBan.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn tên bàn trước!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboBan.Focus();
                return;
            }

            string ten = ((Button)sender).Text.Trim();
            DataRow[] tim = dt.Select("FoodName = '" + ten.Replace("'", "''") + "'");
            if (tim.Length == 0)
            {
                DataRow r = dt.NewRow();
                r["FoodName"] = ten;
                r["Quantity"] = 1;
                dt.Rows.Add(r);
            }
            else
            {
                tim[0]["Quantity"] = (int)tim[0]["Quantity"] + 1;
            }
        }

        // Xóa dòng đang chọn (không có dòng chọn thì xóa hết)
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dt.Rows.Count == 0) return;

            if (dgvOrder.CurrentRow != null)
                dt.Rows.RemoveAt(dgvOrder.CurrentRow.Index);
            else
                dt.Rows.Clear();
        }

        // Order: gửi cho đầu bếp (hiện MessageBox) rồi làm mới
        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (cboBan.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn tên bàn!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboBan.Focus();
                return;
            }
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có món nào được chọn!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Đã gửi order xuống bếp cho " + cboBan.Text + ":");
            sb.AppendLine();
            foreach (DataRow r in dt.Rows)
                sb.AppendLine(r["FoodName"] + " x " + r["Quantity"]);

            MessageBox.Show(sb.ToString(), "Order",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            dt.Rows.Clear();
            cboBan.SelectedIndex = -1;
        }

        private void Thuchanh05a_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.No) e.Cancel = true;
        }
    }
}