namespace ThucHanh06a
{
    partial class QLDiem
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblMaSV = new System.Windows.Forms.Label();
            this.lblMaMH = new System.Windows.Forms.Label();
            this.lblDiem = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // lblMaSV
            //
            this.lblMaSV.Location = new System.Drawing.Point(14, 17);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(55, 18);
            this.lblMaSV.Text = "Mã sv";
            //
            // lblMaMH
            //
            this.lblMaMH.Location = new System.Drawing.Point(14, 49);
            this.lblMaMH.Name = "lblMaMH";
            this.lblMaMH.Size = new System.Drawing.Size(55, 18);
            this.lblMaMH.Text = "Mã mh";
            //
            // lblDiem
            //
            this.lblDiem.Location = new System.Drawing.Point(14, 81);
            this.lblDiem.Name = "lblDiem";
            this.lblDiem.Size = new System.Drawing.Size(55, 18);
            this.lblDiem.Text = "Điểm";
            //
            // txtMaSV
            //
            this.txtMaSV.Location = new System.Drawing.Point(75, 14);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(215, 23);
            //
            // txtMaMH
            //
            this.txtMaMH.Location = new System.Drawing.Point(75, 46);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(215, 23);
            //
            // txtDiem
            //
            this.txtDiem.Location = new System.Drawing.Point(75, 78);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(215, 23);
            //
            // btnThem
            //
            this.btnThem.Location = new System.Drawing.Point(14, 120);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(85, 30);
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            //
            // btnXoa
            //
            this.btnXoa.Location = new System.Drawing.Point(110, 120);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 30);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            //
            // btnSua
            //
            this.btnSua.Location = new System.Drawing.Point(205, 120);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(85, 30);
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            //
            // QLDiem
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 168);
            this.Controls.Add(this.lblMaSV);
            this.Controls.Add(this.lblMaMH);
            this.Controls.Add(this.lblDiem);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.txtMaMH);
            this.Controls.Add(this.txtDiem);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "QLDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Điểm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblMaSV, lblMaMH, lblDiem;
        private System.Windows.Forms.TextBox txtMaSV, txtMaMH, txtDiem;
        private System.Windows.Forms.Button btnThem, btnXoa, btnSua;
    }
}