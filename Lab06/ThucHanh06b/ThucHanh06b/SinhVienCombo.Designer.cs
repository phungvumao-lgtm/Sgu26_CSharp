namespace ThucHanh06b
{
    partial class SinhVienCombo
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblLop = new System.Windows.Forms.Label();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.mskNgaySinh = new System.Windows.Forms.MaskedTextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // lblLop
            //
            this.lblLop.Location = new System.Drawing.Point(14, 17);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(65, 18);
            this.lblLop.Text = "Lớp";
            //
            // lblMaSV
            //
            this.lblMaSV.Location = new System.Drawing.Point(14, 49);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(65, 18);
            this.lblMaSV.Text = "Mã sv";
            //
            // lblHoTen
            //
            this.lblHoTen.Location = new System.Drawing.Point(14, 81);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(65, 18);
            this.lblHoTen.Text = "Họ tên";
            //
            // lblNgaySinh
            //
            this.lblNgaySinh.Location = new System.Drawing.Point(14, 113);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(65, 18);
            this.lblNgaySinh.Text = "Ngày sinh";
            //
            // cboLop
            //
            this.cboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(85, 14);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(215, 21);
            //
            // txtMaSV
            //
            this.txtMaSV.Location = new System.Drawing.Point(85, 46);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(215, 20);
            //
            // txtHoTen
            //
            this.txtHoTen.Location = new System.Drawing.Point(85, 78);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(215, 20);
            //
            // mskNgaySinh
            //
            this.mskNgaySinh.Location = new System.Drawing.Point(85, 110);
            this.mskNgaySinh.Mask = "00/00/0000";
            this.mskNgaySinh.Name = "mskNgaySinh";
            this.mskNgaySinh.Size = new System.Drawing.Size(215, 20);
            this.mskNgaySinh.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            //
            // btnThem
            //
            this.btnThem.Location = new System.Drawing.Point(14, 152);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(85, 30);
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            //
            // btnXoa
            //
            this.btnXoa.Location = new System.Drawing.Point(115, 152);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 30);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            //
            // btnSua
            //
            this.btnSua.Location = new System.Drawing.Point(215, 152);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(85, 30);
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            //
            // SinhVienCombo
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(318, 200);
            this.Controls.Add(this.lblLop);
            this.Controls.Add(this.lblMaSV);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.cboLop);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.mskNgaySinh);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SinhVienCombo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSinhvien_Combo";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblLop, lblMaSV, lblHoTen, lblNgaySinh;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.TextBox txtMaSV, txtHoTen;
        private System.Windows.Forms.MaskedTextBox mskNgaySinh;
        private System.Windows.Forms.Button btnThem, btnXoa, btnSua;
    }
}