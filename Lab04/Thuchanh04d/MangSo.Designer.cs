namespace ThucHanh04d
{
    partial class MangSo
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.btnNhapMang = new System.Windows.Forms.Button();
            this.txtNhapMang = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.txtKetQuaMang = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.gbSapXep = new System.Windows.Forms.GroupBox();
            this.rdTang = new System.Windows.Forms.RadioButton();
            this.rdGiam = new System.Windows.Forms.RadioButton();
            this.gbTim = new System.Windows.Forms.GroupBox();
            this.rdTimGiaTri = new System.Windows.Forms.RadioButton();
            this.txtTimGiaTri = new System.Windows.Forms.TextBox();
            this.rdTimViTri = new System.Windows.Forms.RadioButton();
            this.txtTimViTri = new System.Windows.Forms.TextBox();
            this.lblSoTim = new System.Windows.Forms.Label();
            this.txtSoTimDuoc = new System.Windows.Forms.TextBox();
            this.gbXoa = new System.Windows.Forms.GroupBox();
            this.rdXoaGiaTri = new System.Windows.Forms.RadioButton();
            this.txtXoaGiaTri = new System.Windows.Forms.TextBox();
            this.rdXoaViTri = new System.Windows.Forms.RadioButton();
            this.txtXoaViTri = new System.Windows.Forms.TextBox();
            this.lblCanXoa = new System.Windows.Forms.Label();
            this.gbThem = new System.Windows.Forms.GroupBox();
            this.lblGtThem = new System.Windows.Forms.Label();
            this.txtThemGiaTri = new System.Windows.Forms.TextBox();
            this.lblVtThem = new System.Windows.Forms.Label();
            this.txtThemViTri = new System.Windows.Forms.TextBox();
            this.lblCanThem = new System.Windows.Forms.Label();
            this.gbTong = new System.Windows.Forms.GroupBox();
            this.lblTongMang = new System.Windows.Forms.Label();
            this.txtTongMang = new System.Windows.Forms.TextBox();
            this.lblTongChan = new System.Windows.Forms.Label();
            this.txtTongChan = new System.Windows.Forms.TextBox();
            this.lblTongLe = new System.Windows.Forms.Label();
            this.txtTongLe = new System.Windows.Forms.TextBox();
            this.btnTong = new System.Windows.Forms.Button();
            this.gbMaxMin = new System.Windows.Forms.GroupBox();
            this.lblMax = new System.Windows.Forms.Label();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.lblMin = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.gbThay = new System.Windows.Forms.GroupBox();
            this.rdThayGiaTri = new System.Windows.Forms.RadioButton();
            this.txtThayGiaTri = new System.Windows.Forms.TextBox();
            this.rdThayViTri = new System.Windows.Forms.RadioButton();
            this.txtThayViTri = new System.Windows.Forms.TextBox();
            this.lblSoThay = new System.Windows.Forms.Label();
            this.txtSoThay = new System.Windows.Forms.TextBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbSapXep.SuspendLayout();
            this.gbTim.SuspendLayout();
            this.gbXoa.SuspendLayout();
            this.gbThem.SuspendLayout();
            this.gbTong.SuspendLayout();
            this.gbMaxMin.SuspendLayout();
            this.gbThay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.Red;
            this.lblTieuDe.Location = new System.Drawing.Point(0, 9);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(469, 34);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Mảng Số Nguyên";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNhapMang
            // 
            this.btnNhapMang.Location = new System.Drawing.Point(11, 51);
            this.btnNhapMang.Name = "btnNhapMang";
            this.btnNhapMang.Size = new System.Drawing.Size(103, 27);
            this.btnNhapMang.TabIndex = 1;
            this.btnNhapMang.Text = "Nhập mảng";
            // 
            // txtNhapMang
            // 
            this.txtNhapMang.Location = new System.Drawing.Point(123, 53);
            this.txtNhapMang.Name = "txtNhapMang";
            this.txtNhapMang.Size = new System.Drawing.Size(234, 22);
            this.txtNhapMang.TabIndex = 2;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(368, 51);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(89, 27);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            // 
            // lblKetQua
            // 
            this.lblKetQua.Location = new System.Drawing.Point(11, 92);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(109, 21);
            this.lblKetQua.TabIndex = 4;
            this.lblKetQua.Text = "Kết quả mảng :";
            // 
            // txtKetQuaMang
            // 
            this.txtKetQuaMang.Location = new System.Drawing.Point(123, 89);
            this.txtKetQuaMang.Name = "txtKetQuaMang";
            this.txtKetQuaMang.ReadOnly = true;
            this.txtKetQuaMang.Size = new System.Drawing.Size(234, 22);
            this.txtKetQuaMang.TabIndex = 5;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(368, 86);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(89, 27);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            // 
            // btnThucHien
            // 
            this.btnThucHien.Location = new System.Drawing.Point(11, 123);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(103, 48);
            this.btnThucHien.TabIndex = 7;
            this.btnThucHien.Text = "Thực Hiện";
            // 
            // gbSapXep
            // 
            this.gbSapXep.Controls.Add(this.rdTang);
            this.gbSapXep.Controls.Add(this.rdGiam);
            this.gbSapXep.Location = new System.Drawing.Point(123, 117);
            this.gbSapXep.Name = "gbSapXep";
            this.gbSapXep.Size = new System.Drawing.Size(334, 53);
            this.gbSapXep.TabIndex = 8;
            this.gbSapXep.TabStop = false;
            this.gbSapXep.Text = "Sắp Xếp";
            // 
            // rdTang
            // 
            this.rdTang.Location = new System.Drawing.Point(23, 21);
            this.rdTang.Name = "rdTang";
            this.rdTang.Size = new System.Drawing.Size(137, 23);
            this.rdTang.TabIndex = 0;
            this.rdTang.Text = "Sắp xếp Tăng";
            // 
            // rdGiam
            // 
            this.rdGiam.Location = new System.Drawing.Point(171, 21);
            this.rdGiam.Name = "rdGiam";
            this.rdGiam.Size = new System.Drawing.Size(137, 23);
            this.rdGiam.TabIndex = 1;
            this.rdGiam.Text = "Sắp xếp Giảm";
            // 
            // gbTim
            // 
            this.gbTim.Controls.Add(this.rdTimGiaTri);
            this.gbTim.Controls.Add(this.txtTimGiaTri);
            this.gbTim.Controls.Add(this.rdTimViTri);
            this.gbTim.Controls.Add(this.txtTimViTri);
            this.gbTim.Controls.Add(this.lblSoTim);
            this.gbTim.Controls.Add(this.txtSoTimDuoc);
            this.gbTim.Location = new System.Drawing.Point(11, 179);
            this.gbTim.Name = "gbTim";
            this.gbTim.Size = new System.Drawing.Size(223, 107);
            this.gbTim.TabIndex = 9;
            this.gbTim.TabStop = false;
            this.gbTim.Text = "Tìm Kiếm";
            // 
            // rdTimGiaTri
            // 
            this.rdTimGiaTri.Location = new System.Drawing.Point(7, 19);
            this.rdTimGiaTri.Name = "rdTimGiaTri";
            this.rdTimGiaTri.Size = new System.Drawing.Size(143, 23);
            this.rdTimGiaTri.TabIndex = 0;
            this.rdTimGiaTri.Text = "Tìm giá trị cần tìm";
            // 
            // txtTimGiaTri
            // 
            this.txtTimGiaTri.Location = new System.Drawing.Point(154, 18);
            this.txtTimGiaTri.Name = "txtTimGiaTri";
            this.txtTimGiaTri.Size = new System.Drawing.Size(57, 22);
            this.txtTimGiaTri.TabIndex = 1;
            // 
            // rdTimViTri
            // 
            this.rdTimViTri.Location = new System.Drawing.Point(7, 47);
            this.rdTimViTri.Name = "rdTimViTri";
            this.rdTimViTri.Size = new System.Drawing.Size(143, 23);
            this.rdTimViTri.TabIndex = 2;
            this.rdTimViTri.Text = "Tìm vị trí cần tìm";
            // 
            // txtTimViTri
            // 
            this.txtTimViTri.Location = new System.Drawing.Point(154, 46);
            this.txtTimViTri.Name = "txtTimViTri";
            this.txtTimViTri.Size = new System.Drawing.Size(57, 22);
            this.txtTimViTri.TabIndex = 3;
            // 
            // lblSoTim
            // 
            this.lblSoTim.Location = new System.Drawing.Point(7, 79);
            this.lblSoTim.Name = "lblSoTim";
            this.lblSoTim.Size = new System.Drawing.Size(109, 19);
            this.lblSoTim.TabIndex = 4;
            this.lblSoTim.Text = "Số tìm được là :";
            // 
            // txtSoTimDuoc
            // 
            this.txtSoTimDuoc.Location = new System.Drawing.Point(120, 76);
            this.txtSoTimDuoc.Name = "txtSoTimDuoc";
            this.txtSoTimDuoc.ReadOnly = true;
            this.txtSoTimDuoc.Size = new System.Drawing.Size(91, 22);
            this.txtSoTimDuoc.TabIndex = 5;
            // 
            // gbXoa
            // 
            this.gbXoa.Controls.Add(this.rdXoaGiaTri);
            this.gbXoa.Controls.Add(this.txtXoaGiaTri);
            this.gbXoa.Controls.Add(this.rdXoaViTri);
            this.gbXoa.Controls.Add(this.txtXoaViTri);
            this.gbXoa.Controls.Add(this.lblCanXoa);
            this.gbXoa.Location = new System.Drawing.Point(240, 179);
            this.gbXoa.Name = "gbXoa";
            this.gbXoa.Size = new System.Drawing.Size(217, 107);
            this.gbXoa.TabIndex = 10;
            this.gbXoa.TabStop = false;
            this.gbXoa.Text = "Xóa";
            // 
            // rdXoaGiaTri
            // 
            this.rdXoaGiaTri.Location = new System.Drawing.Point(7, 19);
            this.rdXoaGiaTri.Name = "rdXoaGiaTri";
            this.rdXoaGiaTri.Size = new System.Drawing.Size(146, 23);
            this.rdXoaGiaTri.TabIndex = 0;
            this.rdXoaGiaTri.Text = "Tìm giá trị cần xóa";
            // 
            // txtXoaGiaTri
            // 
            this.txtXoaGiaTri.Location = new System.Drawing.Point(158, 18);
            this.txtXoaGiaTri.Name = "txtXoaGiaTri";
            this.txtXoaGiaTri.Size = new System.Drawing.Size(52, 22);
            this.txtXoaGiaTri.TabIndex = 1;
            // 
            // rdXoaViTri
            // 
            this.rdXoaViTri.Location = new System.Drawing.Point(7, 47);
            this.rdXoaViTri.Name = "rdXoaViTri";
            this.rdXoaViTri.Size = new System.Drawing.Size(146, 23);
            this.rdXoaViTri.TabIndex = 2;
            this.rdXoaViTri.Text = "Tìm vị trí cần xóa";
            // 
            // txtXoaViTri
            // 
            this.txtXoaViTri.Location = new System.Drawing.Point(158, 46);
            this.txtXoaViTri.Name = "txtXoaViTri";
            this.txtXoaViTri.Size = new System.Drawing.Size(52, 22);
            this.txtXoaViTri.TabIndex = 3;
            // 
            // lblCanXoa
            // 
            this.lblCanXoa.ForeColor = System.Drawing.Color.Red;
            this.lblCanXoa.Location = new System.Drawing.Point(34, 79);
            this.lblCanXoa.Name = "lblCanXoa";
            this.lblCanXoa.Size = new System.Drawing.Size(149, 19);
            this.lblCanXoa.TabIndex = 4;
            this.lblCanXoa.Text = "Cần sắp xếp tăng";
            // 
            // gbThem
            // 
            this.gbThem.Controls.Add(this.lblGtThem);
            this.gbThem.Controls.Add(this.txtThemGiaTri);
            this.gbThem.Controls.Add(this.lblVtThem);
            this.gbThem.Controls.Add(this.txtThemViTri);
            this.gbThem.Controls.Add(this.lblCanThem);
            this.gbThem.Location = new System.Drawing.Point(11, 292);
            this.gbThem.Name = "gbThem";
            this.gbThem.Size = new System.Drawing.Size(223, 107);
            this.gbThem.TabIndex = 11;
            this.gbThem.TabStop = false;
            this.gbThem.Text = "Thêm";
            // 
            // lblGtThem
            // 
            this.lblGtThem.Location = new System.Drawing.Point(7, 23);
            this.lblGtThem.Name = "lblGtThem";
            this.lblGtThem.Size = new System.Drawing.Size(126, 19);
            this.lblGtThem.TabIndex = 0;
            this.lblGtThem.Text = "Giá trị cần thêm :";
            // 
            // txtThemGiaTri
            // 
            this.txtThemGiaTri.Location = new System.Drawing.Point(143, 20);
            this.txtThemGiaTri.Name = "txtThemGiaTri";
            this.txtThemGiaTri.Size = new System.Drawing.Size(68, 22);
            this.txtThemGiaTri.TabIndex = 1;
            // 
            // lblVtThem
            // 
            this.lblVtThem.Location = new System.Drawing.Point(7, 53);
            this.lblVtThem.Name = "lblVtThem";
            this.lblVtThem.Size = new System.Drawing.Size(131, 19);
            this.lblVtThem.TabIndex = 2;
            this.lblVtThem.Text = "Tại vị trí cần thêm :";
            // 
            // txtThemViTri
            // 
            this.txtThemViTri.Location = new System.Drawing.Point(143, 50);
            this.txtThemViTri.Name = "txtThemViTri";
            this.txtThemViTri.Size = new System.Drawing.Size(68, 22);
            this.txtThemViTri.TabIndex = 3;
            // 
            // lblCanThem
            // 
            this.lblCanThem.ForeColor = System.Drawing.Color.Red;
            this.lblCanThem.Location = new System.Drawing.Point(34, 81);
            this.lblCanThem.Name = "lblCanThem";
            this.lblCanThem.Size = new System.Drawing.Size(149, 19);
            this.lblCanThem.TabIndex = 4;
            this.lblCanThem.Text = "Cần sắp xếp tăng";
            // 
            // gbTong
            // 
            this.gbTong.Controls.Add(this.lblTongMang);
            this.gbTong.Controls.Add(this.txtTongMang);
            this.gbTong.Controls.Add(this.lblTongChan);
            this.gbTong.Controls.Add(this.txtTongChan);
            this.gbTong.Controls.Add(this.lblTongLe);
            this.gbTong.Controls.Add(this.txtTongLe);
            this.gbTong.Controls.Add(this.btnTong);
            this.gbTong.Location = new System.Drawing.Point(240, 292);
            this.gbTong.Name = "gbTong";
            this.gbTong.Size = new System.Drawing.Size(217, 107);
            this.gbTong.TabIndex = 12;
            this.gbTong.TabStop = false;
            this.gbTong.Text = "Tổng";
            // 
            // lblTongMang
            // 
            this.lblTongMang.Location = new System.Drawing.Point(7, 23);
            this.lblTongMang.Name = "lblTongMang";
            this.lblTongMang.Size = new System.Drawing.Size(86, 19);
            this.lblTongMang.TabIndex = 0;
            this.lblTongMang.Text = "Tổng mảng";
            // 
            // txtTongMang
            // 
            this.txtTongMang.Location = new System.Drawing.Point(94, 20);
            this.txtTongMang.Name = "txtTongMang";
            this.txtTongMang.ReadOnly = true;
            this.txtTongMang.Size = new System.Drawing.Size(51, 22);
            this.txtTongMang.TabIndex = 1;
            // 
            // lblTongChan
            // 
            this.lblTongChan.Location = new System.Drawing.Point(7, 53);
            this.lblTongChan.Name = "lblTongChan";
            this.lblTongChan.Size = new System.Drawing.Size(86, 19);
            this.lblTongChan.TabIndex = 2;
            this.lblTongChan.Text = "Tổng chẵn";
            // 
            // txtTongChan
            // 
            this.txtTongChan.Location = new System.Drawing.Point(94, 50);
            this.txtTongChan.Name = "txtTongChan";
            this.txtTongChan.ReadOnly = true;
            this.txtTongChan.Size = new System.Drawing.Size(51, 22);
            this.txtTongChan.TabIndex = 3;
            // 
            // lblTongLe
            // 
            this.lblTongLe.Location = new System.Drawing.Point(7, 81);
            this.lblTongLe.Name = "lblTongLe";
            this.lblTongLe.Size = new System.Drawing.Size(86, 19);
            this.lblTongLe.TabIndex = 4;
            this.lblTongLe.Text = "Tổng lẻ";
            // 
            // txtTongLe
            // 
            this.txtTongLe.Location = new System.Drawing.Point(94, 78);
            this.txtTongLe.Name = "txtTongLe";
            this.txtTongLe.ReadOnly = true;
            this.txtTongLe.Size = new System.Drawing.Size(51, 22);
            this.txtTongLe.TabIndex = 5;
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(153, 20);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(57, 82);
            this.btnTong.TabIndex = 6;
            this.btnTong.Text = "Tổng";
            // 
            // gbMaxMin
            // 
            this.gbMaxMin.Controls.Add(this.lblMax);
            this.gbMaxMin.Controls.Add(this.txtMax);
            this.gbMaxMin.Controls.Add(this.lblMin);
            this.gbMaxMin.Controls.Add(this.txtMin);
            this.gbMaxMin.Controls.Add(this.btnTim);
            this.gbMaxMin.Location = new System.Drawing.Point(11, 405);
            this.gbMaxMin.Name = "gbMaxMin";
            this.gbMaxMin.Size = new System.Drawing.Size(223, 107);
            this.gbMaxMin.TabIndex = 13;
            this.gbMaxMin.TabStop = false;
            this.gbMaxMin.Text = "Max - Min";
            // 
            // lblMax
            // 
            this.lblMax.Location = new System.Drawing.Point(7, 30);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(109, 19);
            this.lblMax.TabIndex = 0;
            this.lblMax.Text = "Giá trị lớn nhất";
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(119, 27);
            this.txtMax.Name = "txtMax";
            this.txtMax.ReadOnly = true;
            this.txtMax.Size = new System.Drawing.Size(45, 22);
            this.txtMax.TabIndex = 1;
            // 
            // lblMin
            // 
            this.lblMin.Location = new System.Drawing.Point(7, 66);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(109, 19);
            this.lblMin.TabIndex = 2;
            this.lblMin.Text = "Giá trị nhỏ nhất";
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(119, 63);
            this.txtMin.Name = "txtMin";
            this.txtMin.ReadOnly = true;
            this.txtMin.Size = new System.Drawing.Size(45, 22);
            this.txtMin.TabIndex = 3;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(171, 27);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(43, 59);
            this.btnTim.TabIndex = 4;
            this.btnTim.Text = "Tìm";
            // 
            // gbThay
            // 
            this.gbThay.Controls.Add(this.rdThayGiaTri);
            this.gbThay.Controls.Add(this.txtThayGiaTri);
            this.gbThay.Controls.Add(this.rdThayViTri);
            this.gbThay.Controls.Add(this.txtThayViTri);
            this.gbThay.Controls.Add(this.lblSoThay);
            this.gbThay.Controls.Add(this.txtSoThay);
            this.gbThay.Controls.Add(this.lblGhiChu);
            this.gbThay.Location = new System.Drawing.Point(240, 405);
            this.gbThay.Name = "gbThay";
            this.gbThay.Size = new System.Drawing.Size(217, 139);
            this.gbThay.TabIndex = 14;
            this.gbThay.TabStop = false;
            this.gbThay.Text = "Thay Thế";
            // 
            // rdThayGiaTri
            // 
            this.rdThayGiaTri.Location = new System.Drawing.Point(7, 21);
            this.rdThayGiaTri.Name = "rdThayGiaTri";
            this.rdThayGiaTri.Size = new System.Drawing.Size(135, 23);
            this.rdThayGiaTri.TabIndex = 0;
            this.rdThayGiaTri.Text = "Giá trị cần thay";
            // 
            // txtThayGiaTri
            // 
            this.txtThayGiaTri.Location = new System.Drawing.Point(146, 20);
            this.txtThayGiaTri.Name = "txtThayGiaTri";
            this.txtThayGiaTri.Size = new System.Drawing.Size(63, 22);
            this.txtThayGiaTri.TabIndex = 1;
            // 
            // rdThayViTri
            // 
            this.rdThayViTri.Location = new System.Drawing.Point(7, 51);
            this.rdThayViTri.Name = "rdThayViTri";
            this.rdThayViTri.Size = new System.Drawing.Size(135, 23);
            this.rdThayViTri.TabIndex = 2;
            this.rdThayViTri.Text = "Vị trí cần thay";
            // 
            // txtThayViTri
            // 
            this.txtThayViTri.Location = new System.Drawing.Point(146, 50);
            this.txtThayViTri.Name = "txtThayViTri";
            this.txtThayViTri.Size = new System.Drawing.Size(63, 22);
            this.txtThayViTri.TabIndex = 3;
            // 
            // lblSoThay
            // 
            this.lblSoThay.Location = new System.Drawing.Point(23, 85);
            this.lblSoThay.Name = "lblSoThay";
            this.lblSoThay.Size = new System.Drawing.Size(120, 19);
            this.lblSoThay.TabIndex = 4;
            this.lblSoThay.Text = "Số thay thế là :";
            // 
            // txtSoThay
            // 
            this.txtSoThay.Location = new System.Drawing.Point(146, 82);
            this.txtSoThay.Name = "txtSoThay";
            this.txtSoThay.Size = new System.Drawing.Size(63, 22);
            this.txtSoThay.TabIndex = 5;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.ForeColor = System.Drawing.Color.Gray;
            this.lblGhiChu.Location = new System.Drawing.Point(7, 113);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(194, 19);
            this.lblGhiChu.TabIndex = 6;
            this.lblGhiChu.Text = "Nhấn Enter để thực hiện";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // MangSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 555);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.btnNhapMang);
            this.Controls.Add(this.txtNhapMang);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.txtKetQuaMang);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThucHien);
            this.Controls.Add(this.gbSapXep);
            this.Controls.Add(this.gbTim);
            this.Controls.Add(this.gbXoa);
            this.Controls.Add(this.gbThem);
            this.Controls.Add(this.gbTong);
            this.Controls.Add(this.gbMaxMin);
            this.Controls.Add(this.gbThay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MangSo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mảng Số Nguyên";
            this.gbSapXep.ResumeLayout(false);
            this.gbTim.ResumeLayout(false);
            this.gbTim.PerformLayout();
            this.gbXoa.ResumeLayout(false);
            this.gbXoa.PerformLayout();
            this.gbThem.ResumeLayout(false);
            this.gbThem.PerformLayout();
            this.gbTong.ResumeLayout(false);
            this.gbTong.PerformLayout();
            this.gbMaxMin.ResumeLayout(false);
            this.gbMaxMin.PerformLayout();
            this.gbThay.ResumeLayout(false);
            this.gbThay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTieuDe, lblKetQua, lblSoTim, lblCanXoa, lblGtThem, lblVtThem,
            lblCanThem, lblTongMang, lblTongChan, lblTongLe, lblMax, lblMin, lblSoThay, lblGhiChu;
        private System.Windows.Forms.Button btnNhapMang, btnReset, btnThoat, btnThucHien, btnTong, btnTim;
        private System.Windows.Forms.TextBox txtNhapMang, txtKetQuaMang, txtTimGiaTri, txtTimViTri, txtSoTimDuoc,
            txtXoaGiaTri, txtXoaViTri, txtThemGiaTri, txtThemViTri, txtTongMang, txtTongChan, txtTongLe,
            txtMax, txtMin, txtThayGiaTri, txtThayViTri, txtSoThay;
        private System.Windows.Forms.RadioButton rdTang, rdGiam, rdTimGiaTri, rdTimViTri,
            rdXoaGiaTri, rdXoaViTri, rdThayGiaTri, rdThayViTri;
        private System.Windows.Forms.GroupBox gbSapXep, gbTim, gbXoa, gbThem, gbTong, gbMaxMin, gbThay;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}