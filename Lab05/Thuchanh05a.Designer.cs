namespace Lab05
{
    partial class Thuchanh05a
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Thuchanh05a));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.grpDanhMuc = new System.Windows.Forms.GroupBox();
            this.btnBurgerBo = new System.Windows.Forms.Button();
            this.btnBurgerGa = new System.Windows.Forms.Button();
            this.btnBurgerTom = new System.Windows.Forms.Button();
            this.btnBurgerCa = new System.Windows.Forms.Button();
            this.btnTomVien = new System.Windows.Forms.Button();
            this.btnGaVien = new System.Windows.Forms.Button();
            this.btnGaRan = new System.Windows.Forms.Button();
            this.btnComGa = new System.Windows.Forms.Button();
            this.btnPepsi = new System.Windows.Forms.Button();
            this.btnCoca = new System.Windows.Forms.Button();
            this.btn7up = new System.Windows.Forms.Button();
            this.btnLipton = new System.Windows.Forms.Button();
            this.btnCafe = new System.Windows.Forms.Button();
            this.btnCam = new System.Windows.Forms.Button();
            this.btnKhoaiTay = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblTenBan = new System.Windows.Forms.Label();
            this.cboBan = new System.Windows.Forms.ComboBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.colMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpDanhMuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.Blue;
            this.lblTieuDe.Location = new System.Drawing.Point(114, 23);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(343, 38);
            this.lblTieuDe.TabIndex = 1;
            this.lblTieuDe.Text = "Fastfood Order";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpDanhMuc
            // 
            this.grpDanhMuc.Controls.Add(this.btnBurgerBo);
            this.grpDanhMuc.Controls.Add(this.btnBurgerGa);
            this.grpDanhMuc.Controls.Add(this.btnBurgerTom);
            this.grpDanhMuc.Controls.Add(this.btnBurgerCa);
            this.grpDanhMuc.Controls.Add(this.btnTomVien);
            this.grpDanhMuc.Controls.Add(this.btnGaVien);
            this.grpDanhMuc.Controls.Add(this.btnGaRan);
            this.grpDanhMuc.Controls.Add(this.btnComGa);
            this.grpDanhMuc.Controls.Add(this.btnPepsi);
            this.grpDanhMuc.Controls.Add(this.btnCoca);
            this.grpDanhMuc.Controls.Add(this.btn7up);
            this.grpDanhMuc.Controls.Add(this.btnLipton);
            this.grpDanhMuc.Controls.Add(this.btnCafe);
            this.grpDanhMuc.Controls.Add(this.btnCam);
            this.grpDanhMuc.Controls.Add(this.btnKhoaiTay);
            this.grpDanhMuc.Location = new System.Drawing.Point(14, 85);
            this.grpDanhMuc.Name = "grpDanhMuc";
            this.grpDanhMuc.Size = new System.Drawing.Size(469, 171);
            this.grpDanhMuc.TabIndex = 2;
            this.grpDanhMuc.TabStop = false;
            this.grpDanhMuc.Text = "Danh mục món ăn";
            // 
            // btnBurgerBo
            // 
            this.btnBurgerBo.ForeColor = System.Drawing.Color.Red;
            this.btnBurgerBo.Location = new System.Drawing.Point(9, 23);
            this.btnBurgerBo.Name = "btnBurgerBo";
            this.btnBurgerBo.Size = new System.Drawing.Size(114, 28);
            this.btnBurgerBo.TabIndex = 0;
            this.btnBurgerBo.Text = "Burger Phô mai Bò";
            this.btnBurgerBo.UseVisualStyleBackColor = true;
            // 
            // btnBurgerGa
            // 
            this.btnBurgerGa.ForeColor = System.Drawing.Color.Red;
            this.btnBurgerGa.Location = new System.Drawing.Point(9, 58);
            this.btnBurgerGa.Name = "btnBurgerGa";
            this.btnBurgerGa.Size = new System.Drawing.Size(114, 28);
            this.btnBurgerGa.TabIndex = 1;
            this.btnBurgerGa.Text = "Burger Phô mai Gà";
            this.btnBurgerGa.UseVisualStyleBackColor = true;
            // 
            // btnBurgerTom
            // 
            this.btnBurgerTom.ForeColor = System.Drawing.Color.Red;
            this.btnBurgerTom.Location = new System.Drawing.Point(9, 92);
            this.btnBurgerTom.Name = "btnBurgerTom";
            this.btnBurgerTom.Size = new System.Drawing.Size(114, 28);
            this.btnBurgerTom.TabIndex = 2;
            this.btnBurgerTom.Text = "Burger Phô mai Tôm";
            this.btnBurgerTom.UseVisualStyleBackColor = true;
            // 
            // btnBurgerCa
            // 
            this.btnBurgerCa.ForeColor = System.Drawing.Color.Red;
            this.btnBurgerCa.Location = new System.Drawing.Point(9, 126);
            this.btnBurgerCa.Name = "btnBurgerCa";
            this.btnBurgerCa.Size = new System.Drawing.Size(114, 28);
            this.btnBurgerCa.TabIndex = 3;
            this.btnBurgerCa.Text = "Burger Phô mai Cá";
            this.btnBurgerCa.UseVisualStyleBackColor = true;
            // 
            // btnTomVien
            // 
            this.btnTomVien.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnTomVien.Location = new System.Drawing.Point(128, 23);
            this.btnTomVien.Name = "btnTomVien";
            this.btnTomVien.Size = new System.Drawing.Size(114, 28);
            this.btnTomVien.TabIndex = 4;
            this.btnTomVien.Text = "Tôm viên Cola";
            this.btnTomVien.UseVisualStyleBackColor = true;
            // 
            // btnGaVien
            // 
            this.btnGaVien.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnGaVien.Location = new System.Drawing.Point(128, 58);
            this.btnGaVien.Name = "btnGaVien";
            this.btnGaVien.Size = new System.Drawing.Size(114, 28);
            this.btnGaVien.TabIndex = 5;
            this.btnGaVien.Text = "Gà viên Cola";
            this.btnGaVien.UseVisualStyleBackColor = true;
            // 
            // btnGaRan
            // 
            this.btnGaRan.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnGaRan.Location = new System.Drawing.Point(128, 92);
            this.btnGaRan.Name = "btnGaRan";
            this.btnGaRan.Size = new System.Drawing.Size(114, 28);
            this.btnGaRan.TabIndex = 6;
            this.btnGaRan.Text = "Gà rán phần";
            this.btnGaRan.UseVisualStyleBackColor = true;
            // 
            // btnComGa
            // 
            this.btnComGa.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnComGa.Location = new System.Drawing.Point(128, 126);
            this.btnComGa.Name = "btnComGa";
            this.btnComGa.Size = new System.Drawing.Size(114, 28);
            this.btnComGa.TabIndex = 7;
            this.btnComGa.Text = "Cơm Gà Tender";
            this.btnComGa.UseVisualStyleBackColor = true;
            // 
            // btnPepsi
            // 
            this.btnPepsi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPepsi.ForeColor = System.Drawing.Color.Red;
            this.btnPepsi.Location = new System.Drawing.Point(247, 23);
            this.btnPepsi.Name = "btnPepsi";
            this.btnPepsi.Size = new System.Drawing.Size(105, 28);
            this.btnPepsi.TabIndex = 8;
            this.btnPepsi.Text = "Pepsi";
            this.btnPepsi.UseVisualStyleBackColor = true;
            // 
            // btnCoca
            // 
            this.btnCoca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCoca.ForeColor = System.Drawing.Color.Red;
            this.btnCoca.Location = new System.Drawing.Point(357, 23);
            this.btnCoca.Name = "btnCoca";
            this.btnCoca.Size = new System.Drawing.Size(103, 28);
            this.btnCoca.TabIndex = 9;
            this.btnCoca.Text = "Coca";
            this.btnCoca.UseVisualStyleBackColor = true;
            // 
            // btn7up
            // 
            this.btn7up.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn7up.ForeColor = System.Drawing.Color.Red;
            this.btn7up.Location = new System.Drawing.Point(247, 58);
            this.btn7up.Name = "btn7up";
            this.btn7up.Size = new System.Drawing.Size(105, 28);
            this.btn7up.TabIndex = 10;
            this.btn7up.Text = "7 up";
            this.btn7up.UseVisualStyleBackColor = true;
            // 
            // btnLipton
            // 
            this.btnLipton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLipton.ForeColor = System.Drawing.Color.Red;
            this.btnLipton.Location = new System.Drawing.Point(357, 58);
            this.btnLipton.Name = "btnLipton";
            this.btnLipton.Size = new System.Drawing.Size(103, 28);
            this.btnLipton.TabIndex = 11;
            this.btnLipton.Text = "Lipton";
            this.btnLipton.UseVisualStyleBackColor = true;
            // 
            // btnCafe
            // 
            this.btnCafe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCafe.ForeColor = System.Drawing.Color.Red;
            this.btnCafe.Location = new System.Drawing.Point(247, 92);
            this.btnCafe.Name = "btnCafe";
            this.btnCafe.Size = new System.Drawing.Size(105, 28);
            this.btnCafe.TabIndex = 12;
            this.btnCafe.Text = "Cafe";
            this.btnCafe.UseVisualStyleBackColor = true;
            // 
            // btnCam
            // 
            this.btnCam.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCam.ForeColor = System.Drawing.Color.Red;
            this.btnCam.Location = new System.Drawing.Point(357, 92);
            this.btnCam.Name = "btnCam";
            this.btnCam.Size = new System.Drawing.Size(103, 28);
            this.btnCam.TabIndex = 13;
            this.btnCam.Text = "Cam";
            this.btnCam.UseVisualStyleBackColor = true;
            // 
            // btnKhoaiTay
            // 
            this.btnKhoaiTay.ForeColor = System.Drawing.Color.Green;
            this.btnKhoaiTay.Location = new System.Drawing.Point(247, 126);
            this.btnKhoaiTay.Name = "btnKhoaiTay";
            this.btnKhoaiTay.Size = new System.Drawing.Size(213, 28);
            this.btnKhoaiTay.TabIndex = 14;
            this.btnKhoaiTay.Text = "Khoai tây chiên";
            this.btnKhoaiTay.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(14, 267);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(91, 30);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // lblTenBan
            // 
            this.lblTenBan.Location = new System.Drawing.Point(149, 273);
            this.lblTenBan.Name = "lblTenBan";
            this.lblTenBan.Size = new System.Drawing.Size(63, 19);
            this.lblTenBan.TabIndex = 4;
            this.lblTenBan.Text = "Tên bàn";
            // 
            // cboBan
            // 
            this.cboBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBan.FormattingEnabled = true;
            this.cboBan.Location = new System.Drawing.Point(217, 270);
            this.cboBan.Name = "cboBan";
            this.cboBan.Size = new System.Drawing.Size(148, 24);
            this.cboBan.TabIndex = 5;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(391, 267);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(91, 30);
            this.btnOrder.TabIndex = 6;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.AllowUserToDeleteRows = false;
            this.dgvOrder.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMon,
            this.colSoLuong});
            this.dgvOrder.Location = new System.Drawing.Point(14, 307);
            this.dgvOrder.MultiSelect = false;
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.RowHeadersWidth = 51;
            this.dgvOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrder.Size = new System.Drawing.Size(469, 267);
            this.dgvOrder.TabIndex = 7;
            // 
            // colMon
            // 
            this.colMon.HeaderText = "Món ăn";
            this.colMon.MinimumWidth = 6;
            this.colMon.Name = "colMon";
            this.colMon.ReadOnly = true;
            this.colMon.Width = 220;
            // 
            // colSoLuong
            // 
            this.colSoLuong.HeaderText = "Số lượng";
            this.colSoLuong.MinimumWidth = 6;
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.ReadOnly = true;
            // 
            // Thuchanh05a
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 588);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.grpDanhMuc);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.lblTenBan);
            this.Controls.Add(this.cboBan);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.dgvOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Thuchanh05a";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-Order Application";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpDanhMuc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.GroupBox grpDanhMuc;
        private System.Windows.Forms.Button btnBurgerBo, btnBurgerGa, btnBurgerTom, btnBurgerCa;
        private System.Windows.Forms.Button btnTomVien, btnGaVien, btnGaRan, btnComGa;
        private System.Windows.Forms.Button btnPepsi, btnCoca, btn7up, btnLipton, btnCafe, btnCam, btnKhoaiTay;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lblTenBan;
        private System.Windows.Forms.ComboBox cboBan;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
    }
}