namespace ThucHanh06a
{
    partial class QLMonHoc
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblMaMH = new System.Windows.Forms.Label();
            this.lblTenMH = new System.Windows.Forms.Label();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // lblMaMH
            //
            this.lblMaMH.Location = new System.Drawing.Point(14, 17);
            this.lblMaMH.Name = "lblMaMH";
            this.lblMaMH.Size = new System.Drawing.Size(50, 18);
            this.lblMaMH.Text = "Mã mh";
            //
            // lblTenMH
            //
            this.lblTenMH.Location = new System.Drawing.Point(14, 49);
            this.lblTenMH.Name = "lblTenMH";
            this.lblTenMH.Size = new System.Drawing.Size(50, 18);
            this.lblTenMH.Text = "Tên mh";
            //
            // txtMaMH
            //
            this.txtMaMH.Location = new System.Drawing.Point(72, 14);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(215, 23);
            //
            // txtTenMH
            //
            this.txtTenMH.Location = new System.Drawing.Point(72, 46);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(215, 23);
            //
            // btnThem
            //
            this.btnThem.Location = new System.Drawing.Point(14, 88);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 30);
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            //
            // btnXoa
            //
            this.btnXoa.Location = new System.Drawing.Point(110, 88);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 30);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            //
            // btnSua
            //
            this.btnSua.Location = new System.Drawing.Point(207, 88);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(80, 30);
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            //
            // QLMonHoc
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 135);
            this.Controls.Add(this.lblMaMH);
            this.Controls.Add(this.lblTenMH);
            this.Controls.Add(this.txtMaMH);
            this.Controls.Add(this.txtTenMH);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "QLMonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý môn học";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblMaMH;
        private System.Windows.Forms.Label lblTenMH;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
    }
}