namespace GUI
{
    partial class frmBaoGia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBaoGiaCuaLead = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lbTieuDeBaoGia = new System.Windows.Forms.Label();
            this.lbTenBaoGia = new System.Windows.Forms.Label();
            this.txtTenBaoGia = new System.Windows.Forms.TextBox();
            this.lbKhoaHoc = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cboKhoaHoc = new System.Windows.Forms.ComboBox();
            this.btnThemKhoaHoc = new System.Windows.Forms.Button();
            this.btnXoaKhoaHoc = new System.Windows.Forms.Button();
            this.lbTongTienTrcGiam = new System.Windows.Forms.Label();
            this.txtTongTienTrcGiam = new System.Windows.Forms.TextBox();
            this.lbSoTienGiamGia = new System.Windows.Forms.Label();
            this.txtSoTienGiamGia = new System.Windows.Forms.TextBox();
            this.lbThanhTien = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.lbKhuyenMai = new System.Windows.Forms.Label();
            this.btnThemKhuyenMai = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSoKhoaHocMuaChung = new System.Windows.Forms.Label();
            this.txtSoKhoaHocMuaChung = new System.Windows.Forms.TextBox();
            this.lbDoiTuongUuTien = new System.Windows.Forms.Label();
            this.txtDoiTuongUuTien = new System.Windows.Forms.TextBox();
            this.lbDipDacBiet = new System.Windows.Forms.Label();
            this.txtDipDacBiet = new System.Windows.Forms.TextBox();
            this.btnLuuKhuyenMai = new System.Windows.Forms.Button();
            this.lbPhanTramGiamGia = new System.Windows.Forms.Label();
            this.numUpDownPhanTramGiamGia = new System.Windows.Forms.NumericUpDown();
            this.txtKoCoGiam = new System.Windows.Forms.TextBox();
            this.btnTaoBaoGia = new System.Windows.Forms.Button();
            this.lbEmailBaoGia = new System.Windows.Forms.Label();
            this.lbTrangThaiEmailBaoGia = new System.Windows.Forms.Label();
            this.txtTrangThaiEmailBaoGia = new System.Windows.Forms.TextBox();
            this.btnTaoEmailBaoGia = new System.Windows.Forms.Button();
            this.btnGuiEmailBaoGia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPhanTramGiamGia)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBaoGiaCuaLead
            // 
            this.txtBaoGiaCuaLead.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBaoGiaCuaLead.Location = new System.Drawing.Point(87, 32);
            this.txtBaoGiaCuaLead.Name = "txtBaoGiaCuaLead";
            this.txtBaoGiaCuaLead.Size = new System.Drawing.Size(561, 45);
            this.txtBaoGiaCuaLead.TabIndex = 82;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(87, 114);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(44, 44);
            this.btnBack.TabIndex = 84;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lbTieuDeBaoGia
            // 
            this.lbTieuDeBaoGia.AutoSize = true;
            this.lbTieuDeBaoGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuDeBaoGia.Location = new System.Drawing.Point(158, 119);
            this.lbTieuDeBaoGia.Name = "lbTieuDeBaoGia";
            this.lbTieuDeBaoGia.Size = new System.Drawing.Size(175, 32);
            this.lbTieuDeBaoGia.TabIndex = 85;
            this.lbTieuDeBaoGia.Text = "Tạo báo giá";
            // 
            // lbTenBaoGia
            // 
            this.lbTenBaoGia.AutoSize = true;
            this.lbTenBaoGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenBaoGia.Location = new System.Drawing.Point(87, 195);
            this.lbTenBaoGia.Name = "lbTenBaoGia";
            this.lbTenBaoGia.Size = new System.Drawing.Size(164, 32);
            this.lbTenBaoGia.TabIndex = 86;
            this.lbTenBaoGia.Text = "Tên báo giá";
            // 
            // txtTenBaoGia
            // 
            this.txtTenBaoGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenBaoGia.Location = new System.Drawing.Point(93, 230);
            this.txtTenBaoGia.Name = "txtTenBaoGia";
            this.txtTenBaoGia.Size = new System.Drawing.Size(1808, 38);
            this.txtTenBaoGia.TabIndex = 87;
            // 
            // lbKhoaHoc
            // 
            this.lbKhoaHoc.AutoSize = true;
            this.lbKhoaHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhoaHoc.Location = new System.Drawing.Point(87, 306);
            this.lbKhoaHoc.Name = "lbKhoaHoc";
            this.lbKhoaHoc.Size = new System.Drawing.Size(134, 32);
            this.lbKhoaHoc.TabIndex = 88;
            this.lbKhoaHoc.Text = "Khóa học";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(93, 341);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1795, 143);
            this.dataGridView1.TabIndex = 89;
            // 
            // cboKhoaHoc
            // 
            this.cboKhoaHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboKhoaHoc.FormattingEnabled = true;
            this.cboKhoaHoc.Location = new System.Drawing.Point(93, 511);
            this.cboKhoaHoc.Name = "cboKhoaHoc";
            this.cboKhoaHoc.Size = new System.Drawing.Size(803, 39);
            this.cboKhoaHoc.TabIndex = 90;
            // 
            // btnThemKhoaHoc
            // 
            this.btnThemKhoaHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemKhoaHoc.Location = new System.Drawing.Point(950, 511);
            this.btnThemKhoaHoc.Name = "btnThemKhoaHoc";
            this.btnThemKhoaHoc.Size = new System.Drawing.Size(282, 39);
            this.btnThemKhoaHoc.TabIndex = 91;
            this.btnThemKhoaHoc.Text = "Thêm khóa học";
            this.btnThemKhoaHoc.UseVisualStyleBackColor = true;
            this.btnThemKhoaHoc.Click += new System.EventHandler(this.btnThemKhoaHoc_Click);
            // 
            // btnXoaKhoaHoc
            // 
            this.btnXoaKhoaHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaKhoaHoc.Location = new System.Drawing.Point(1286, 511);
            this.btnXoaKhoaHoc.Name = "btnXoaKhoaHoc";
            this.btnXoaKhoaHoc.Size = new System.Drawing.Size(282, 39);
            this.btnXoaKhoaHoc.TabIndex = 92;
            this.btnXoaKhoaHoc.Text = "Xóa khóa học";
            this.btnXoaKhoaHoc.UseVisualStyleBackColor = true;
            this.btnXoaKhoaHoc.Click += new System.EventHandler(this.btnXoaKhoaHoc_Click);
            // 
            // lbTongTienTrcGiam
            // 
            this.lbTongTienTrcGiam.AutoSize = true;
            this.lbTongTienTrcGiam.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTienTrcGiam.Location = new System.Drawing.Point(87, 591);
            this.lbTongTienTrcGiam.Name = "lbTongTienTrcGiam";
            this.lbTongTienTrcGiam.Size = new System.Drawing.Size(255, 32);
            this.lbTongTienTrcGiam.TabIndex = 93;
            this.lbTongTienTrcGiam.Text = "Tổng tiền khóa học";
            // 
            // txtTongTienTrcGiam
            // 
            this.txtTongTienTrcGiam.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTienTrcGiam.Location = new System.Drawing.Point(363, 585);
            this.txtTongTienTrcGiam.Name = "txtTongTienTrcGiam";
            this.txtTongTienTrcGiam.Size = new System.Drawing.Size(285, 38);
            this.txtTongTienTrcGiam.TabIndex = 94;
            // 
            // lbSoTienGiamGia
            // 
            this.lbSoTienGiamGia.AutoSize = true;
            this.lbSoTienGiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoTienGiamGia.Location = new System.Drawing.Point(704, 591);
            this.lbSoTienGiamGia.Name = "lbSoTienGiamGia";
            this.lbSoTienGiamGia.Size = new System.Drawing.Size(218, 32);
            this.lbSoTienGiamGia.TabIndex = 95;
            this.lbSoTienGiamGia.Text = "Số tiền giảm giá";
            // 
            // txtSoTienGiamGia
            // 
            this.txtSoTienGiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTienGiamGia.Location = new System.Drawing.Point(950, 585);
            this.txtSoTienGiamGia.Name = "txtSoTienGiamGia";
            this.txtSoTienGiamGia.Size = new System.Drawing.Size(285, 38);
            this.txtSoTienGiamGia.TabIndex = 96;
            // 
            // lbThanhTien
            // 
            this.lbThanhTien.AutoSize = true;
            this.lbThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThanhTien.Location = new System.Drawing.Point(1280, 588);
            this.lbThanhTien.Name = "lbThanhTien";
            this.lbThanhTien.Size = new System.Drawing.Size(149, 32);
            this.lbThanhTien.TabIndex = 97;
            this.lbThanhTien.Text = "Thành tiền";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.AcceptsTab = true;
            this.txtThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhTien.Location = new System.Drawing.Point(1448, 585);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(285, 38);
            this.txtThanhTien.TabIndex = 98;
            // 
            // lbKhuyenMai
            // 
            this.lbKhuyenMai.AutoSize = true;
            this.lbKhuyenMai.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhuyenMai.Location = new System.Drawing.Point(87, 656);
            this.lbKhuyenMai.Name = "lbKhuyenMai";
            this.lbKhuyenMai.Size = new System.Drawing.Size(164, 32);
            this.lbKhuyenMai.TabIndex = 99;
            this.lbKhuyenMai.Text = "Khuyến mãi";
            // 
            // btnThemKhuyenMai
            // 
            this.btnThemKhuyenMai.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemKhuyenMai.Location = new System.Drawing.Point(363, 652);
            this.btnThemKhuyenMai.Name = "btnThemKhuyenMai";
            this.btnThemKhuyenMai.Size = new System.Drawing.Size(285, 39);
            this.btnThemKhuyenMai.TabIndex = 100;
            this.btnThemKhuyenMai.Text = "Thêm khuyến mãi";
            this.btnThemKhuyenMai.UseVisualStyleBackColor = true;
            this.btnThemKhuyenMai.Click += new System.EventHandler(this.btnThemKhuyenMai_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(246, 197);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 29);
            this.label8.TabIndex = 101;
            this.label8.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(215, 309);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 29);
            this.label1.TabIndex = 102;
            this.label1.Text = "*";
            // 
            // lbSoKhoaHocMuaChung
            // 
            this.lbSoKhoaHocMuaChung.AutoSize = true;
            this.lbSoKhoaHocMuaChung.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoKhoaHocMuaChung.Location = new System.Drawing.Point(88, 709);
            this.lbSoKhoaHocMuaChung.Name = "lbSoKhoaHocMuaChung";
            this.lbSoKhoaHocMuaChung.Size = new System.Drawing.Size(269, 29);
            this.lbSoKhoaHocMuaChung.TabIndex = 103;
            this.lbSoKhoaHocMuaChung.Text = "Số khóa học mua chung";
            // 
            // txtSoKhoaHocMuaChung
            // 
            this.txtSoKhoaHocMuaChung.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoKhoaHocMuaChung.Location = new System.Drawing.Point(389, 706);
            this.txtSoKhoaHocMuaChung.Name = "txtSoKhoaHocMuaChung";
            this.txtSoKhoaHocMuaChung.Size = new System.Drawing.Size(259, 34);
            this.txtSoKhoaHocMuaChung.TabIndex = 104;
            // 
            // lbDoiTuongUuTien
            // 
            this.lbDoiTuongUuTien.AutoSize = true;
            this.lbDoiTuongUuTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDoiTuongUuTien.Location = new System.Drawing.Point(705, 709);
            this.lbDoiTuongUuTien.Name = "lbDoiTuongUuTien";
            this.lbDoiTuongUuTien.Size = new System.Drawing.Size(193, 29);
            this.lbDoiTuongUuTien.TabIndex = 105;
            this.lbDoiTuongUuTien.Text = "Đối tượng ưu tiên";
            // 
            // txtDoiTuongUuTien
            // 
            this.txtDoiTuongUuTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoiTuongUuTien.Location = new System.Drawing.Point(950, 704);
            this.txtDoiTuongUuTien.Name = "txtDoiTuongUuTien";
            this.txtDoiTuongUuTien.Size = new System.Drawing.Size(285, 34);
            this.txtDoiTuongUuTien.TabIndex = 106;
            // 
            // lbDipDacBiet
            // 
            this.lbDipDacBiet.AutoSize = true;
            this.lbDipDacBiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDipDacBiet.Location = new System.Drawing.Point(1281, 706);
            this.lbDipDacBiet.Name = "lbDipDacBiet";
            this.lbDipDacBiet.Size = new System.Drawing.Size(141, 29);
            this.lbDipDacBiet.TabIndex = 107;
            this.lbDipDacBiet.Text = "Dịp đặc biệt";
            // 
            // txtDipDacBiet
            // 
            this.txtDipDacBiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDipDacBiet.Location = new System.Drawing.Point(1448, 703);
            this.txtDipDacBiet.Name = "txtDipDacBiet";
            this.txtDipDacBiet.Size = new System.Drawing.Size(285, 34);
            this.txtDipDacBiet.TabIndex = 108;
            // 
            // btnLuuKhuyenMai
            // 
            this.btnLuuKhuyenMai.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuKhuyenMai.Location = new System.Drawing.Point(1786, 652);
            this.btnLuuKhuyenMai.Name = "btnLuuKhuyenMai";
            this.btnLuuKhuyenMai.Size = new System.Drawing.Size(102, 39);
            this.btnLuuKhuyenMai.TabIndex = 110;
            this.btnLuuKhuyenMai.Text = "Lưu";
            this.btnLuuKhuyenMai.UseVisualStyleBackColor = true;
            this.btnLuuKhuyenMai.Click += new System.EventHandler(this.btnLuuKhuyenMai_Click);
            // 
            // lbPhanTramGiamGia
            // 
            this.lbPhanTramGiamGia.AutoSize = true;
            this.lbPhanTramGiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhanTramGiamGia.Location = new System.Drawing.Point(88, 759);
            this.lbPhanTramGiamGia.Name = "lbPhanTramGiamGia";
            this.lbPhanTramGiamGia.Size = new System.Drawing.Size(219, 29);
            this.lbPhanTramGiamGia.TabIndex = 112;
            this.lbPhanTramGiamGia.Text = "Phần trăm giảm giá";
            // 
            // numUpDownPhanTramGiamGia
            // 
            this.numUpDownPhanTramGiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDownPhanTramGiamGia.Location = new System.Drawing.Point(389, 757);
            this.numUpDownPhanTramGiamGia.Name = "numUpDownPhanTramGiamGia";
            this.numUpDownPhanTramGiamGia.Size = new System.Drawing.Size(259, 34);
            this.numUpDownPhanTramGiamGia.TabIndex = 113;
            // 
            // txtKoCoGiam
            // 
            this.txtKoCoGiam.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKoCoGiam.ForeColor = System.Drawing.Color.Red;
            this.txtKoCoGiam.Location = new System.Drawing.Point(710, 756);
            this.txtKoCoGiam.Name = "txtKoCoGiam";
            this.txtKoCoGiam.Size = new System.Drawing.Size(525, 34);
            this.txtKoCoGiam.TabIndex = 114;
            this.txtKoCoGiam.Text = "Không tìm thấy mã giảm giá phù hợp!";
            // 
            // btnTaoBaoGia
            // 
            this.btnTaoBaoGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoBaoGia.Location = new System.Drawing.Point(1757, 896);
            this.btnTaoBaoGia.Name = "btnTaoBaoGia";
            this.btnTaoBaoGia.Size = new System.Drawing.Size(131, 48);
            this.btnTaoBaoGia.TabIndex = 115;
            this.btnTaoBaoGia.Text = "Tạo";
            this.btnTaoBaoGia.UseVisualStyleBackColor = true;
            this.btnTaoBaoGia.Click += new System.EventHandler(this.btnTaoBaoGia_Click);
            // 
            // lbEmailBaoGia
            // 
            this.lbEmailBaoGia.AutoSize = true;
            this.lbEmailBaoGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmailBaoGia.Location = new System.Drawing.Point(87, 822);
            this.lbEmailBaoGia.Name = "lbEmailBaoGia";
            this.lbEmailBaoGia.Size = new System.Drawing.Size(187, 32);
            this.lbEmailBaoGia.TabIndex = 116;
            this.lbEmailBaoGia.Text = "Email báo giá";
            // 
            // lbTrangThaiEmailBaoGia
            // 
            this.lbTrangThaiEmailBaoGia.AutoSize = true;
            this.lbTrangThaiEmailBaoGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrangThaiEmailBaoGia.Location = new System.Drawing.Point(89, 876);
            this.lbTrangThaiEmailBaoGia.Name = "lbTrangThaiEmailBaoGia";
            this.lbTrangThaiEmailBaoGia.Size = new System.Drawing.Size(121, 29);
            this.lbTrangThaiEmailBaoGia.TabIndex = 117;
            this.lbTrangThaiEmailBaoGia.Text = "Trạng thái";
            // 
            // txtTrangThaiEmailBaoGia
            // 
            this.txtTrangThaiEmailBaoGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrangThaiEmailBaoGia.Location = new System.Drawing.Point(389, 870);
            this.txtTrangThaiEmailBaoGia.Name = "txtTrangThaiEmailBaoGia";
            this.txtTrangThaiEmailBaoGia.Size = new System.Drawing.Size(259, 34);
            this.txtTrangThaiEmailBaoGia.TabIndex = 118;
            // 
            // btnTaoEmailBaoGia
            // 
            this.btnTaoEmailBaoGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoEmailBaoGia.Location = new System.Drawing.Point(363, 815);
            this.btnTaoEmailBaoGia.Name = "btnTaoEmailBaoGia";
            this.btnTaoEmailBaoGia.Size = new System.Drawing.Size(282, 39);
            this.btnTaoEmailBaoGia.TabIndex = 119;
            this.btnTaoEmailBaoGia.Text = "Tạo Email Báo giá";
            this.btnTaoEmailBaoGia.UseVisualStyleBackColor = true;
            this.btnTaoEmailBaoGia.Click += new System.EventHandler(this.btnTaoEmailBaoGia_Click);
            // 
            // btnGuiEmailBaoGia
            // 
            this.btnGuiEmailBaoGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuiEmailBaoGia.Location = new System.Drawing.Point(1691, 815);
            this.btnGuiEmailBaoGia.Name = "btnGuiEmailBaoGia";
            this.btnGuiEmailBaoGia.Size = new System.Drawing.Size(197, 39);
            this.btnGuiEmailBaoGia.TabIndex = 120;
            this.btnGuiEmailBaoGia.Text = "Gửi Email";
            this.btnGuiEmailBaoGia.UseVisualStyleBackColor = true;
            this.btnGuiEmailBaoGia.Click += new System.EventHandler(this.btnGuiEmailBaoGia_Click);
            // 
            // frmBaoGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.btnGuiEmailBaoGia);
            this.Controls.Add(this.btnTaoEmailBaoGia);
            this.Controls.Add(this.txtTrangThaiEmailBaoGia);
            this.Controls.Add(this.lbTrangThaiEmailBaoGia);
            this.Controls.Add(this.lbEmailBaoGia);
            this.Controls.Add(this.btnTaoBaoGia);
            this.Controls.Add(this.txtKoCoGiam);
            this.Controls.Add(this.numUpDownPhanTramGiamGia);
            this.Controls.Add(this.lbPhanTramGiamGia);
            this.Controls.Add(this.btnLuuKhuyenMai);
            this.Controls.Add(this.txtDipDacBiet);
            this.Controls.Add(this.lbDipDacBiet);
            this.Controls.Add(this.txtDoiTuongUuTien);
            this.Controls.Add(this.lbDoiTuongUuTien);
            this.Controls.Add(this.txtSoKhoaHocMuaChung);
            this.Controls.Add(this.lbSoKhoaHocMuaChung);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnThemKhuyenMai);
            this.Controls.Add(this.lbKhuyenMai);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.lbThanhTien);
            this.Controls.Add(this.txtSoTienGiamGia);
            this.Controls.Add(this.lbSoTienGiamGia);
            this.Controls.Add(this.txtTongTienTrcGiam);
            this.Controls.Add(this.lbTongTienTrcGiam);
            this.Controls.Add(this.btnXoaKhoaHoc);
            this.Controls.Add(this.btnThemKhoaHoc);
            this.Controls.Add(this.cboKhoaHoc);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbKhoaHoc);
            this.Controls.Add(this.txtTenBaoGia);
            this.Controls.Add(this.lbTenBaoGia);
            this.Controls.Add(this.lbTieuDeBaoGia);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtBaoGiaCuaLead);
            this.Name = "frmBaoGia";
            this.Text = "BaoGia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBaoGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPhanTramGiamGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox txtBaoGiaCuaLead;
        public System.Windows.Forms.TextBox txtTenBaoGia;
        public System.Windows.Forms.ComboBox cboKhoaHoc;
        public System.Windows.Forms.TextBox txtTongTienTrcGiam;
        public System.Windows.Forms.TextBox txtSoTienGiamGia;
        public System.Windows.Forms.TextBox txtThanhTien;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox txtSoKhoaHocMuaChung;
        public System.Windows.Forms.TextBox txtDoiTuongUuTien;
        public System.Windows.Forms.TextBox txtDipDacBiet;
        public System.Windows.Forms.TextBox txtKoCoGiam;
        public System.Windows.Forms.TextBox txtTrangThaiEmailBaoGia;
        public System.Windows.Forms.Button btnBack;
        public System.Windows.Forms.Label lbTieuDeBaoGia;
        public System.Windows.Forms.Label lbTenBaoGia;
        public System.Windows.Forms.Label lbKhoaHoc;
        public System.Windows.Forms.Button btnThemKhoaHoc;
        public System.Windows.Forms.Button btnXoaKhoaHoc;
        public System.Windows.Forms.Label lbTongTienTrcGiam;
        public System.Windows.Forms.Label lbSoTienGiamGia;
        public System.Windows.Forms.Label lbThanhTien;
        public System.Windows.Forms.Label lbKhuyenMai;
        public System.Windows.Forms.Button btnThemKhuyenMai;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbSoKhoaHocMuaChung;
        public System.Windows.Forms.Label lbDoiTuongUuTien;
        public System.Windows.Forms.Label lbDipDacBiet;
        public System.Windows.Forms.Button btnLuuKhuyenMai;
        public System.Windows.Forms.Label lbPhanTramGiamGia;
        public System.Windows.Forms.NumericUpDown numUpDownPhanTramGiamGia;
        public System.Windows.Forms.Button btnTaoBaoGia;
        public System.Windows.Forms.Label lbEmailBaoGia;
        public System.Windows.Forms.Label lbTrangThaiEmailBaoGia;
        public System.Windows.Forms.Button btnTaoEmailBaoGia;
        public System.Windows.Forms.Button btnGuiEmailBaoGia;
    }
}