namespace ThucHanh06b
{
    partial class DanhSachLop
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnHienThi = new System.Windows.Forms.Button();
            this.lvLop = new System.Windows.Forms.ListView();
            this.colSTT = new System.Windows.Forms.ColumnHeader();
            this.colMaLop = new System.Windows.Forms.ColumnHeader();
            this.colTenLop = new System.Windows.Forms.ColumnHeader();
            this.colMaKhoa = new System.Windows.Forms.ColumnHeader();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // btnHienThi
            //
            this.btnHienThi.Location = new System.Drawing.Point(20, 14);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(100, 26);
            this.btnHienThi.Text = "Hiển thị dữ liệu";
            this.btnHienThi.UseVisualStyleBackColor = true;
            //
            // lvLop
            //
            this.lvLop.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                this.colSTT, this.colMaLop, this.colTenLop, this.colMaKhoa});
            this.lvLop.FullRowSelect = true;
            this.lvLop.GridLines = true;
            this.lvLop.Location = new System.Drawing.Point(20, 50);
            this.lvLop.Name = "lvLop";
            this.lvLop.Size = new System.Drawing.Size(460, 220);
            this.lvLop.UseCompatibleStateImageBehavior = false;
            this.lvLop.View = System.Windows.Forms.View.Details;
            //
            // colSTT
            //
            this.colSTT.Text = "STT";
            this.colSTT.Width = 45;
            //
            // colMaLop
            //
            this.colMaLop.Text = "Mã lớp";
            this.colMaLop.Width = 100;
            //
            // colTenLop
            //
            this.colTenLop.Text = "Tên lớp";
            this.colTenLop.Width = 200;
            //
            // colMaKhoa
            //
            this.colMaKhoa.Text = "Mã khoa";
            this.colMaKhoa.Width = 100;
            //
            // btnThoat
            //
            this.btnThoat.Location = new System.Drawing.Point(380, 282);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 30);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            //
            // DanhSachLop
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(500, 325);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.lvLop);
            this.Controls.Add(this.btnThoat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DanhSachLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách Lớp";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnHienThi, btnThoat;
        private System.Windows.Forms.ListView lvLop;
        private System.Windows.Forms.ColumnHeader colSTT, colMaLop, colTenLop, colMaKhoa;
    }
}