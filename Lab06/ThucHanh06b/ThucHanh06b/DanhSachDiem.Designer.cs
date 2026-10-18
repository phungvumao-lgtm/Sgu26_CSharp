namespace ThucHanh06b
{
    partial class DanhSachDiem
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblMon = new System.Windows.Forms.Label();
            this.cboMon = new System.Windows.Forms.ComboBox();
            this.btnLoc = new System.Windows.Forms.Button();
            this.lvDiem = new System.Windows.Forms.ListView();
            this.colSTT = new System.Windows.Forms.ColumnHeader();
            this.colTenSV = new System.Windows.Forms.ColumnHeader();
            this.colNgaySinh = new System.Windows.Forms.ColumnHeader();
            this.colTenMon = new System.Windows.Forms.ColumnHeader();
            this.colDiem = new System.Windows.Forms.ColumnHeader();
            this.lblTong = new System.Windows.Forms.Label();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // lblMon
            //
            this.lblMon.Location = new System.Drawing.Point(20, 20);
            this.lblMon.Name = "lblMon";
            this.lblMon.Size = new System.Drawing.Size(55, 18);
            this.lblMon.Text = "Môn học";
            //
            // cboMon
            //
            this.cboMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMon.FormattingEnabled = true;
            this.cboMon.Location = new System.Drawing.Point(90, 17);
            this.cboMon.Name = "cboMon";
            this.cboMon.Size = new System.Drawing.Size(250, 21);
            //
            // btnLoc
            //
            this.btnLoc.Location = new System.Drawing.Point(360, 14);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(100, 27);
            this.btnLoc.Text = "Lọc dữ liệu";
            this.btnLoc.UseVisualStyleBackColor = true;
            //
            // lvDiem
            //
            this.lvDiem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                this.colSTT, this.colTenSV, this.colNgaySinh, this.colTenMon, this.colDiem});
            this.lvDiem.FullRowSelect = true;
            this.lvDiem.GridLines = true;
            this.lvDiem.Location = new System.Drawing.Point(20, 55);
            this.lvDiem.Name = "lvDiem";
            this.lvDiem.Size = new System.Drawing.Size(560, 250);
            this.lvDiem.UseCompatibleStateImageBehavior = false;
            this.lvDiem.View = System.Windows.Forms.View.Details;
            //
            // colSTT
            //
            this.colSTT.Text = "STT";
            this.colSTT.Width = 45;
            //
            // colTenSV
            //
            this.colTenSV.Text = "Tên SV";
            this.colTenSV.Width = 160;
            //
            // colNgaySinh
            //
            this.colNgaySinh.Text = "Ngày sinh";
            this.colNgaySinh.Width = 95;
            //
            // colTenMon
            //
            this.colTenMon.Text = "Tên môn học";
            this.colTenMon.Width = 170;
            //
            // colDiem
            //
            this.colDiem.Text = "Điểm";
            this.colDiem.Width = 70;
            //
            // lblTong
            //
            this.lblTong.Location = new System.Drawing.Point(380, 322);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(60, 18);
            this.lblTong.Text = "Tổng điểm";
            //
            // txtTong
            //
            this.txtTong.Location = new System.Drawing.Point(450, 319);
            this.txtTong.Name = "txtTong";
            this.txtTong.ReadOnly = true;
            this.txtTong.Size = new System.Drawing.Size(130, 20);
            //
            // DanhSachDiem
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(600, 355);
            this.Controls.Add(this.lblMon);
            this.Controls.Add(this.cboMon);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.lvDiem);
            this.Controls.Add(this.lblTong);
            this.Controls.Add(this.txtTong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DanhSachDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách sinh viên";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblMon, lblTong;
        private System.Windows.Forms.ComboBox cboMon;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.ListView lvDiem;
        private System.Windows.Forms.ColumnHeader colSTT, colTenSV, colNgaySinh, colTenMon, colDiem;
        private System.Windows.Forms.TextBox txtTong;
    }
}