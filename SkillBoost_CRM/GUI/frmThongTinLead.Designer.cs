﻿namespace GUI
{
    partial class frmThongTinLead
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
            this.btnBack = new System.Windows.Forms.Button();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.label19 = new System.Windows.Forms.Label();
            this.txtTrangThaiLead = new System.Windows.Forms.TextBox();
            this.dateTimePickerNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.btnXoaKhoaHoc = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnUnfollow = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.btnLuuThayDoi = new System.Windows.Forms.Button();
            this.btnHuyChinhSua = new System.Windows.Forms.Button();
            this.cbKhoaHoc = new System.Windows.Forms.ComboBox();
            this.btnThemKhoaHoc = new System.Windows.Forms.Button();
            this.dataGridViewKhoaHocKHQuanTam = new System.Windows.Forms.DataGridView();
            this.cbNguonLead = new System.Windows.Forms.ComboBox();
            this.cbNgheNghiep = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPIC = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLeadID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhoaHocKHQuanTam)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(34, 55);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(64, 62);
            this.btnBack.TabIndex = 163;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(87, 29);
            this.toolStripMenuItem2.Text = "Báo giá";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(158, 29);
            this.toolStripMenuItem1.Text = "Thông tin chung";
            // 
            // menuStrip2
            // 
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(2391, 33);
            this.menuStrip2.TabIndex = 162;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(115, 29);
            this.toolStripMenuItem3.Text = "Hoạt động";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click_1);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(1615, 225);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(223, 36);
            this.label19.TabIndex = 160;
            this.label19.Text = "Trạng thái Lead";
            // 
            // txtTrangThaiLead
            // 
            this.txtTrangThaiLead.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrangThaiLead.Location = new System.Drawing.Point(1622, 292);
            this.txtTrangThaiLead.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTrangThaiLead.Name = "txtTrangThaiLead";
            this.txtTrangThaiLead.ReadOnly = true;
            this.txtTrangThaiLead.ShortcutsEnabled = false;
            this.txtTrangThaiLead.Size = new System.Drawing.Size(530, 41);
            this.txtTrangThaiLead.TabIndex = 161;
            // 
            // dateTimePickerNgaySinh
            // 
            this.dateTimePickerNgaySinh.Enabled = false;
            this.dateTimePickerNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgaySinh.Location = new System.Drawing.Point(992, 604);
            this.dateTimePickerNgaySinh.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerNgaySinh.Name = "dateTimePickerNgaySinh";
            this.dateTimePickerNgaySinh.Size = new System.Drawing.Size(530, 41);
            this.dateTimePickerNgaySinh.TabIndex = 159;
            // 
            // btnXoaKhoaHoc
            // 
            this.btnXoaKhoaHoc.Enabled = false;
            this.btnXoaKhoaHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaKhoaHoc.Location = new System.Drawing.Point(1084, 1202);
            this.btnXoaKhoaHoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoaKhoaHoc.Name = "btnXoaKhoaHoc";
            this.btnXoaKhoaHoc.Size = new System.Drawing.Size(202, 58);
            this.btnXoaKhoaHoc.TabIndex = 158;
            this.btnXoaKhoaHoc.Text = "Xóa khóa học ";
            this.btnXoaKhoaHoc.UseVisualStyleBackColor = true;
            this.btnXoaKhoaHoc.Click += new System.EventHandler(this.btnXoaKhoaHoc_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(2078, 124);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(87, 74);
            this.btnXoa.TabIndex = 157;
            this.btnXoa.Text = "🗑️";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnUnfollow
            // 
            this.btnUnfollow.BackColor = System.Drawing.Color.Transparent;
            this.btnUnfollow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnfollow.Location = new System.Drawing.Point(1975, 124);
            this.btnUnfollow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUnfollow.Name = "btnUnfollow";
            this.btnUnfollow.Size = new System.Drawing.Size(87, 74);
            this.btnUnfollow.TabIndex = 156;
            this.btnUnfollow.Text = "⛔";
            this.btnUnfollow.UseVisualStyleBackColor = false;
            this.btnUnfollow.Click += new System.EventHandler(this.btnUnfollow_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Transparent;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(1868, 124);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(87, 74);
            this.btnSua.TabIndex = 155;
            this.btnSua.Text = "✏️";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(265, 133);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(299, 46);
            this.label18.TabIndex = 154;
            this.label18.Text = "Thông tin Lead";
            // 
            // btnLuuThayDoi
            // 
            this.btnLuuThayDoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuThayDoi.ForeColor = System.Drawing.Color.Blue;
            this.btnLuuThayDoi.Location = new System.Drawing.Point(1956, 1295);
            this.btnLuuThayDoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLuuThayDoi.Name = "btnLuuThayDoi";
            this.btnLuuThayDoi.Size = new System.Drawing.Size(202, 58);
            this.btnLuuThayDoi.TabIndex = 153;
            this.btnLuuThayDoi.Text = "Lưu thay đổi";
            this.btnLuuThayDoi.UseVisualStyleBackColor = true;
            this.btnLuuThayDoi.Click += new System.EventHandler(this.btnLuuThayDoi_Click);
            // 
            // btnHuyChinhSua
            // 
            this.btnHuyChinhSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyChinhSua.ForeColor = System.Drawing.Color.Red;
            this.btnHuyChinhSua.Location = new System.Drawing.Point(1715, 1295);
            this.btnHuyChinhSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHuyChinhSua.Name = "btnHuyChinhSua";
            this.btnHuyChinhSua.Size = new System.Drawing.Size(202, 58);
            this.btnHuyChinhSua.TabIndex = 152;
            this.btnHuyChinhSua.Text = "Hủy chỉnh sửa";
            this.btnHuyChinhSua.UseVisualStyleBackColor = true;
            this.btnHuyChinhSua.Click += new System.EventHandler(this.btnHuyChinhSua_Click);
            // 
            // cbKhoaHoc
            // 
            this.cbKhoaHoc.Enabled = false;
            this.cbKhoaHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhoaHoc.FormattingEnabled = true;
            this.cbKhoaHoc.Location = new System.Drawing.Point(274, 1209);
            this.cbKhoaHoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbKhoaHoc.Name = "cbKhoaHoc";
            this.cbKhoaHoc.Size = new System.Drawing.Size(546, 40);
            this.cbKhoaHoc.TabIndex = 151;
            // 
            // btnThemKhoaHoc
            // 
            this.btnThemKhoaHoc.Enabled = false;
            this.btnThemKhoaHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemKhoaHoc.Location = new System.Drawing.Point(856, 1202);
            this.btnThemKhoaHoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThemKhoaHoc.Name = "btnThemKhoaHoc";
            this.btnThemKhoaHoc.Size = new System.Drawing.Size(202, 58);
            this.btnThemKhoaHoc.TabIndex = 150;
            this.btnThemKhoaHoc.Text = "Thêm khóa học ";
            this.btnThemKhoaHoc.UseVisualStyleBackColor = true;
            this.btnThemKhoaHoc.Click += new System.EventHandler(this.btnThemKhoaHoc_Click);
            // 
            // dataGridViewKhoaHocKHQuanTam
            // 
            this.dataGridViewKhoaHocKHQuanTam.AllowUserToOrderColumns = true;
            this.dataGridViewKhoaHocKHQuanTam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKhoaHocKHQuanTam.Enabled = false;
            this.dataGridViewKhoaHocKHQuanTam.Location = new System.Drawing.Point(274, 931);
            this.dataGridViewKhoaHocKHQuanTam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewKhoaHocKHQuanTam.Name = "dataGridViewKhoaHocKHQuanTam";
            this.dataGridViewKhoaHocKHQuanTam.ReadOnly = true;
            this.dataGridViewKhoaHocKHQuanTam.RowHeadersWidth = 82;
            this.dataGridViewKhoaHocKHQuanTam.Size = new System.Drawing.Size(1881, 254);
            this.dataGridViewKhoaHocKHQuanTam.TabIndex = 149;
            // 
            // cbNguonLead
            // 
            this.cbNguonLead.Enabled = false;
            this.cbNguonLead.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNguonLead.FormattingEnabled = true;
            this.cbNguonLead.Location = new System.Drawing.Point(278, 604);
            this.cbNguonLead.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbNguonLead.Name = "cbNguonLead";
            this.cbNguonLead.Size = new System.Drawing.Size(546, 40);
            this.cbNguonLead.TabIndex = 148;
            // 
            // cbNgheNghiep
            // 
            this.cbNgheNghiep.Enabled = false;
            this.cbNgheNghiep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNgheNghiep.FormattingEnabled = true;
            this.cbNgheNghiep.Location = new System.Drawing.Point(1622, 456);
            this.cbNgheNghiep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbNgheNghiep.Name = "cbNgheNghiep";
            this.cbNgheNghiep.Size = new System.Drawing.Size(530, 40);
            this.cbNgheNghiep.TabIndex = 147;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(268, 889);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(280, 36);
            this.label15.TabIndex = 146;
            this.label15.Text = "Khóa học quan tâm ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(1115, 537);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(28, 36);
            this.label17.TabIndex = 145;
            this.label17.Text = "*";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(274, 757);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.ReadOnly = true;
            this.txtGhiChu.Size = new System.Drawing.Size(1879, 104);
            this.txtGhiChu.TabIndex = 144;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(266, 696);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(232, 36);
            this.label16.TabIndex = 143;
            this.label16.Text = "Ghi chú về Lead";
            // 
            // txtPIC
            // 
            this.txtPIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPIC.Location = new System.Drawing.Point(1622, 601);
            this.txtPIC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPIC.Name = "txtPIC";
            this.txtPIC.ReadOnly = true;
            this.txtPIC.Size = new System.Drawing.Size(530, 41);
            this.txtPIC.TabIndex = 142;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1619, 552);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(298, 36);
            this.label14.TabIndex = 141;
            this.label14.Text = "PIC (người tiếp nhận)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(451, 539);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 36);
            this.label2.TabIndex = 140;
            this.label2.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(271, 539);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(179, 36);
            this.label12.TabIndex = 139;
            this.label12.Text = "Nguồn Lead";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1615, 384);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(186, 36);
            this.label11.TabIndex = 138;
            this.label11.Text = "Nghề nghiệp";
            this.label11.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(992, 459);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(546, 41);
            this.txtEmail.TabIndex = 137;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(1057, 384);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 36);
            this.label8.TabIndex = 136;
            this.label8.Text = "*";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDienThoai.Location = new System.Drawing.Point(274, 459);
            this.txtSoDienThoai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.ReadOnly = true;
            this.txtSoDienThoai.Size = new System.Drawing.Size(546, 41);
            this.txtSoDienThoai.TabIndex = 134;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(446, 384);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 36);
            this.label6.TabIndex = 133;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(266, 384);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 36);
            this.label7.TabIndex = 132;
            this.label7.Text = "Số điện thoại";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(977, 537);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(149, 36);
            this.label.TabIndex = 131;
            this.label.Text = "Ngày sinh";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(985, 384);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 36);
            this.label9.TabIndex = 135;
            this.label9.Text = "Email";
            // 
            // txtHoten
            // 
            this.txtHoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoten.Location = new System.Drawing.Point(988, 292);
            this.txtHoten.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.ReadOnly = true;
            this.txtHoten.ShortcutsEnabled = false;
            this.txtHoten.Size = new System.Drawing.Size(530, 41);
            this.txtHoten.TabIndex = 130;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(1076, 225);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 36);
            this.label3.TabIndex = 129;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(980, 225);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 36);
            this.label4.TabIndex = 128;
            this.label4.Text = "Họ tên";
            // 
            // txtLeadID
            // 
            this.txtLeadID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeadID.Location = new System.Drawing.Point(280, 292);
            this.txtLeadID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLeadID.Name = "txtLeadID";
            this.txtLeadID.ReadOnly = true;
            this.txtLeadID.Size = new System.Drawing.Size(535, 41);
            this.txtLeadID.TabIndex = 127;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 225);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 36);
            this.label1.TabIndex = 126;
            this.label1.Text = "Lead ID";
            // 
            // frmThongTinLead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2391, 1383);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtTrangThaiLead);
            this.Controls.Add(this.dateTimePickerNgaySinh);
            this.Controls.Add(this.btnXoaKhoaHoc);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnUnfollow);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.btnLuuThayDoi);
            this.Controls.Add(this.btnHuyChinhSua);
            this.Controls.Add(this.cbKhoaHoc);
            this.Controls.Add(this.btnThemKhoaHoc);
            this.Controls.Add(this.dataGridViewKhoaHocKHQuanTam);
            this.Controls.Add(this.cbNguonLead);
            this.Controls.Add(this.cbNgheNghiep);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtPIC);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLeadID);
            this.Controls.Add(this.label1);
            this.Name = "frmThongTinLead";
            this.Text = "frmThongTinLead";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmThongTinLead_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhoaHocKHQuanTam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtTrangThaiLead;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgaySinh;
        private System.Windows.Forms.Button btnXoaKhoaHoc;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnUnfollow;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnLuuThayDoi;
        private System.Windows.Forms.Button btnHuyChinhSua;
        private System.Windows.Forms.ComboBox cbKhoaHoc;
        private System.Windows.Forms.Button btnThemKhoaHoc;
        private System.Windows.Forms.DataGridView dataGridViewKhoaHocKHQuanTam;
        private System.Windows.Forms.ComboBox cbNguonLead;
        private System.Windows.Forms.ComboBox cbNgheNghiep;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtPIC;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLeadID;
        private System.Windows.Forms.Label label1;
    }
}