namespace ThucHanh06b
{
    partial class FormCuaHang
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuTaoTonKho = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThemSP = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBanHang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuTaoTonKho,
                this.mnuThemSP,
                this.mnuBanHang});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(500, 28);
            this.menuStrip1.TabIndex = 0;
            // 
            // mnuTaoTonKho
            // 
            this.mnuTaoTonKho.Name = "mnuTaoTonKho";
            this.mnuTaoTonKho.Size = new System.Drawing.Size(100, 24);
            this.mnuTaoTonKho.Text = "Tạo tồn kho";
            // 
            // mnuThemSP
            // 
            this.mnuThemSP.Name = "mnuThemSP";
            this.mnuThemSP.Size = new System.Drawing.Size(150, 24);
            this.mnuThemSP.Text = "Thêm sản phẩm mới";
            // 
            // mnuBanHang
            // 
            this.mnuBanHang.Name = "mnuBanHang";
            this.mnuBanHang.Size = new System.Drawing.Size(80, 24);
            this.mnuBanHang.Text = "Bán hàng";
            // 
            // FormCuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 280);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormCuaHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý cửa hàng";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuTaoTonKho;
        private System.Windows.Forms.ToolStripMenuItem mnuThemSP;
        private System.Windows.Forms.ToolStripMenuItem mnuBanHang;
    }
}