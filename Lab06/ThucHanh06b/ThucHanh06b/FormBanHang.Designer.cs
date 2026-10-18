namespace ThucHanh06b
{
    partial class FormBanHang
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnTaoHD = new System.Windows.Forms.Button();
            this.grpChiTiet = new System.Windows.Forms.GroupBox();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.cboSanPham = new System.Windows.Forms.ComboBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.grpChiTiet.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTaoHD
            // 
            this.btnTaoHD.Location = new System.Drawing.Point(300, 15);
            this.btnTaoHD.Name = "btnTaoHD";
            this.btnTaoHD.Size = new System.Drawing.Size(140, 30);
            this.btnTaoHD.TabIndex = 0;
            this.btnTaoHD.Text = "Tạo hóa đơn mới";
            this.btnTaoHD.UseVisualStyleBackColor = true;
            // 
            // grpChiTiet
            // 
            this.grpChiTiet.Controls.Add(this.lblMaHD);
            this.grpChiTiet.Controls.Add(this.txtMaHD);
            this.grpChiTiet.Controls.Add(this.lblMaSP);
            this.grpChiTiet.Controls.Add(this.cboSanPham);
            this.grpChiTiet.Controls.Add(this.lblSoLuong);
            this.grpChiTiet.Controls.Add(this.txtSoLuong);
            this.grpChiTiet.Controls.Add(this.btnThem);
            this.grpChiTiet.Controls.Add(this.btnHuy);
            this.grpChiTiet.Enabled = false;
            this.grpChiTiet.Location = new System.Drawing.Point(20, 60);
            this.grpChiTiet.Name = "grpChiTiet";
            this.grpChiTiet.Size = new System.Drawing.Size(420, 190);
            this.grpChiTiet.TabIndex = 1;
            this.grpChiTiet.TabStop = false;
            this.grpChiTiet.Text = "Chi tiết hóa đơn";
            // 
            // lblMaHD
            // 
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.Location = new System.Drawing.Point(20, 35);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(71, 16);
            this.lblMaHD.Text = "Mã hóa đơn";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(130, 32);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.ReadOnly = true;
            this.txtMaHD.Size = new System.Drawing.Size(270, 22);
            this.txtMaHD.TabIndex = 0;
            // 
            // lblMaSP
            // 
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Location = new System.Drawing.Point(20, 70);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(84, 16);
            this.lblMaSP.Text = "Mã sản phẩm";
            // 
            // cboSanPham
            // 
            this.cboSanPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSanPham.FormattingEnabled = true;
            this.cboSanPham.Location = new System.Drawing.Point(130, 67);
            this.cboSanPham.Name = "cboSanPham";
            this.cboSanPham.Size = new System.Drawing.Size(270, 24);
            this.cboSanPham.TabIndex = 1;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(20, 105);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(59, 16);
            this.lblSoLuong.Text = "Số lượng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(130, 102);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(270, 22);
            this.txtSoLuong.TabIndex = 2;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(130, 140);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 30);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(250, 140);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(90, 30);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Enabled = false;
            this.btnThanhToan.Location = new System.Drawing.Point(300, 265);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(140, 30);
            this.btnThanhToan.TabIndex = 2;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // FormBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 315);
            this.Controls.Add(this.btnTaoHD);
            this.Controls.Add(this.grpChiTiet);
            this.Controls.Add(this.btnThanhToan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BanHang";
            this.grpChiTiet.ResumeLayout(false);
            this.grpChiTiet.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnTaoHD;
        private System.Windows.Forms.GroupBox grpChiTiet;
        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.ComboBox cboSanPham;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThanhToan;
    }
}