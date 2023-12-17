namespace GUI
{
    partial class frmTaoQuyDinhGiamGia
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
            this.lbTaoQuyDinhGiamGia = new System.Windows.Forms.Label();
            this.lbMaQuyDinhGiamGia = new System.Windows.Forms.Label();
            this.txtMaQuyDinhGiamGia = new System.Windows.Forms.TextBox();
            this.lbMoTaLoaiGiamGia = new System.Windows.Forms.Label();
            this.txtMoTaLoaiGiamGia = new System.Windows.Forms.TextBox();
            this.lbSoLuongKhoaHocDangKy = new System.Windows.Forms.Label();
            this.lbTenNgheNghiep = new System.Windows.Forms.Label();
            this.lbPhanTramGiamGiaMacDinh = new System.Windows.Forms.Label();
            this.lbPhanTramGiamGiaToiDa = new System.Windows.Forms.Label();
            this.lbNgayBatDau = new System.Windows.Forms.Label();
            this.lbNgayKetThuc = new System.Windows.Forms.Label();
            this.dateTimePickerNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.btnTaoQuyDinhGiamGIa = new System.Windows.Forms.Button();
            this.cboNgheNghiep = new System.Windows.Forms.ComboBox();
            this.numUpDownSoLuongKhoaHocDangKy = new System.Windows.Forms.NumericUpDown();
            this.numUpDownPhanTramGiamGiaMacDinh = new System.Windows.Forms.NumericUpDown();
            this.numUpDownPhanTramGiamGiaToiDa = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownSoLuongKhoaHocDangKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPhanTramGiamGiaMacDinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPhanTramGiamGiaToiDa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(13, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(31, 37);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lbTaoQuyDinhGiamGia
            // 
            this.lbTaoQuyDinhGiamGia.AutoSize = true;
            this.lbTaoQuyDinhGiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaoQuyDinhGiamGia.Location = new System.Drawing.Point(50, 20);
            this.lbTaoQuyDinhGiamGia.Name = "lbTaoQuyDinhGiamGia";
            this.lbTaoQuyDinhGiamGia.Size = new System.Drawing.Size(225, 25);
            this.lbTaoQuyDinhGiamGia.TabIndex = 2;
            this.lbTaoQuyDinhGiamGia.Text = "Tạo quy định giảm giá";
            // 
            // lbMaQuyDinhGiamGia
            // 
            this.lbMaQuyDinhGiamGia.AutoSize = true;
            this.lbMaQuyDinhGiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaQuyDinhGiamGia.Location = new System.Drawing.Point(8, 65);
            this.lbMaQuyDinhGiamGia.Name = "lbMaQuyDinhGiamGia";
            this.lbMaQuyDinhGiamGia.Size = new System.Drawing.Size(173, 20);
            this.lbMaQuyDinhGiamGia.TabIndex = 3;
            this.lbMaQuyDinhGiamGia.Text = "Mã quy định giảm giá*";
            // 
            // txtMaQuyDinhGiamGia
            // 
            this.txtMaQuyDinhGiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaQuyDinhGiamGia.Location = new System.Drawing.Point(12, 88);
            this.txtMaQuyDinhGiamGia.Name = "txtMaQuyDinhGiamGia";
            this.txtMaQuyDinhGiamGia.Size = new System.Drawing.Size(215, 27);
            this.txtMaQuyDinhGiamGia.TabIndex = 4;
            // 
            // lbMoTaLoaiGiamGia
            // 
            this.lbMoTaLoaiGiamGia.AutoSize = true;
            this.lbMoTaLoaiGiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMoTaLoaiGiamGia.Location = new System.Drawing.Point(284, 65);
            this.lbMoTaLoaiGiamGia.Name = "lbMoTaLoaiGiamGia";
            this.lbMoTaLoaiGiamGia.Size = new System.Drawing.Size(192, 20);
            this.lbMoTaLoaiGiamGia.TabIndex = 5;
            this.lbMoTaLoaiGiamGia.Text = "Mô tả quy định giảm giá*";
            // 
            // txtMoTaLoaiGiamGia
            // 
            this.txtMoTaLoaiGiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoTaLoaiGiamGia.Location = new System.Drawing.Point(288, 88);
            this.txtMoTaLoaiGiamGia.Name = "txtMoTaLoaiGiamGia";
            this.txtMoTaLoaiGiamGia.Size = new System.Drawing.Size(675, 27);
            this.txtMoTaLoaiGiamGia.TabIndex = 6;
            // 
            // lbSoLuongKhoaHocDangKy
            // 
            this.lbSoLuongKhoaHocDangKy.AutoSize = true;
            this.lbSoLuongKhoaHocDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoLuongKhoaHocDangKy.Location = new System.Drawing.Point(8, 142);
            this.lbSoLuongKhoaHocDangKy.Name = "lbSoLuongKhoaHocDangKy";
            this.lbSoLuongKhoaHocDangKy.Size = new System.Drawing.Size(214, 20);
            this.lbSoLuongKhoaHocDangKy.TabIndex = 7;
            this.lbSoLuongKhoaHocDangKy.Text = "Số lượng khóa học đăng ký*";
            // 
            // lbTenNgheNghiep
            // 
            this.lbTenNgheNghiep.AutoSize = true;
            this.lbTenNgheNghiep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNgheNghiep.Location = new System.Drawing.Point(284, 142);
            this.lbTenNgheNghiep.Name = "lbTenNgheNghiep";
            this.lbTenNgheNghiep.Size = new System.Drawing.Size(132, 20);
            this.lbTenNgheNghiep.TabIndex = 11;
            this.lbTenNgheNghiep.Text = "Tên nghề nghiệp";
            // 
            // lbPhanTramGiamGiaMacDinh
            // 
            this.lbPhanTramGiamGiaMacDinh.AutoSize = true;
            this.lbPhanTramGiamGiaMacDinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhanTramGiamGiaMacDinh.Location = new System.Drawing.Point(8, 224);
            this.lbPhanTramGiamGiaMacDinh.Name = "lbPhanTramGiamGiaMacDinh";
            this.lbPhanTramGiamGiaMacDinh.Size = new System.Drawing.Size(233, 20);
            this.lbPhanTramGiamGiaMacDinh.TabIndex = 13;
            this.lbPhanTramGiamGiaMacDinh.Text = "Phần trăm giảm giá mặc định*";
            // 
            // lbPhanTramGiamGiaToiDa
            // 
            this.lbPhanTramGiamGiaToiDa.AutoSize = true;
            this.lbPhanTramGiamGiaToiDa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhanTramGiamGiaToiDa.Location = new System.Drawing.Point(270, 224);
            this.lbPhanTramGiamGiaToiDa.Name = "lbPhanTramGiamGiaToiDa";
            this.lbPhanTramGiamGiaToiDa.Size = new System.Drawing.Size(206, 20);
            this.lbPhanTramGiamGiaToiDa.TabIndex = 15;
            this.lbPhanTramGiamGiaToiDa.Text = "Phần trăm giảm giá tối đa*";
            // 
            // lbNgayBatDau
            // 
            this.lbNgayBatDau.AutoSize = true;
            this.lbNgayBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayBatDau.Location = new System.Drawing.Point(531, 224);
            this.lbNgayBatDau.Name = "lbNgayBatDau";
            this.lbNgayBatDau.Size = new System.Drawing.Size(107, 20);
            this.lbNgayBatDau.TabIndex = 17;
            this.lbNgayBatDau.Text = "Ngày bắt đầu";
            // 
            // lbNgayKetThuc
            // 
            this.lbNgayKetThuc.AutoSize = true;
            this.lbNgayKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayKetThuc.Location = new System.Drawing.Point(773, 224);
            this.lbNgayKetThuc.Name = "lbNgayKetThuc";
            this.lbNgayKetThuc.Size = new System.Drawing.Size(111, 20);
            this.lbNgayKetThuc.TabIndex = 19;
            this.lbNgayKetThuc.Text = "Ngày kết thúc";
            // 
            // dateTimePickerNgayBatDau
            // 
            this.dateTimePickerNgayBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgayBatDau.Location = new System.Drawing.Point(535, 247);
            this.dateTimePickerNgayBatDau.Name = "dateTimePickerNgayBatDau";
            this.dateTimePickerNgayBatDau.Size = new System.Drawing.Size(200, 27);
            this.dateTimePickerNgayBatDau.TabIndex = 21;
            // 
            // dateTimePickerNgayKetThuc
            // 
            this.dateTimePickerNgayKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgayKetThuc.Location = new System.Drawing.Point(777, 247);
            this.dateTimePickerNgayKetThuc.Name = "dateTimePickerNgayKetThuc";
            this.dateTimePickerNgayKetThuc.Size = new System.Drawing.Size(200, 27);
            this.dateTimePickerNgayKetThuc.TabIndex = 22;
            // 
            // btnTaoQuyDinhGiamGIa
            // 
            this.btnTaoQuyDinhGiamGIa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoQuyDinhGiamGIa.Location = new System.Drawing.Point(877, 371);
            this.btnTaoQuyDinhGiamGIa.Name = "btnTaoQuyDinhGiamGIa";
            this.btnTaoQuyDinhGiamGIa.Size = new System.Drawing.Size(86, 35);
            this.btnTaoQuyDinhGiamGIa.TabIndex = 23;
            this.btnTaoQuyDinhGiamGIa.Text = "Tạo";
            this.btnTaoQuyDinhGiamGIa.UseVisualStyleBackColor = true;
            this.btnTaoQuyDinhGiamGIa.Click += new System.EventHandler(this.btnTaoQuyDinhGiamGIa_Click);
            // 
            // cboNgheNghiep
            // 
            this.cboNgheNghiep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNgheNghiep.FormattingEnabled = true;
            this.cboNgheNghiep.Location = new System.Drawing.Point(288, 165);
            this.cboNgheNghiep.Name = "cboNgheNghiep";
            this.cboNgheNghiep.Size = new System.Drawing.Size(675, 28);
            this.cboNgheNghiep.TabIndex = 24;
            // 
            // numUpDownSoLuongKhoaHocDangKy
            // 
            this.numUpDownSoLuongKhoaHocDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDownSoLuongKhoaHocDangKy.Location = new System.Drawing.Point(12, 166);
            this.numUpDownSoLuongKhoaHocDangKy.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDownSoLuongKhoaHocDangKy.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownSoLuongKhoaHocDangKy.Name = "numUpDownSoLuongKhoaHocDangKy";
            this.numUpDownSoLuongKhoaHocDangKy.Size = new System.Drawing.Size(218, 27);
            this.numUpDownSoLuongKhoaHocDangKy.TabIndex = 25;
            this.numUpDownSoLuongKhoaHocDangKy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numUpDownPhanTramGiamGiaMacDinh
            // 
            this.numUpDownPhanTramGiamGiaMacDinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDownPhanTramGiamGiaMacDinh.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUpDownPhanTramGiamGiaMacDinh.Location = new System.Drawing.Point(12, 250);
            this.numUpDownPhanTramGiamGiaMacDinh.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numUpDownPhanTramGiamGiaMacDinh.Name = "numUpDownPhanTramGiamGiaMacDinh";
            this.numUpDownPhanTramGiamGiaMacDinh.Size = new System.Drawing.Size(218, 27);
            this.numUpDownPhanTramGiamGiaMacDinh.TabIndex = 26;
            // 
            // numUpDownPhanTramGiamGiaToiDa
            // 
            this.numUpDownPhanTramGiamGiaToiDa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDownPhanTramGiamGiaToiDa.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUpDownPhanTramGiamGiaToiDa.Location = new System.Drawing.Point(274, 250);
            this.numUpDownPhanTramGiamGiaToiDa.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numUpDownPhanTramGiamGiaToiDa.Name = "numUpDownPhanTramGiamGiaToiDa";
            this.numUpDownPhanTramGiamGiaToiDa.Size = new System.Drawing.Size(218, 27);
            this.numUpDownPhanTramGiamGiaToiDa.TabIndex = 27;
            // 
            // frmTaoQuyDinhGiamGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 553);
            this.Controls.Add(this.numUpDownPhanTramGiamGiaToiDa);
            this.Controls.Add(this.numUpDownPhanTramGiamGiaMacDinh);
            this.Controls.Add(this.numUpDownSoLuongKhoaHocDangKy);
            this.Controls.Add(this.cboNgheNghiep);
            this.Controls.Add(this.btnTaoQuyDinhGiamGIa);
            this.Controls.Add(this.dateTimePickerNgayKetThuc);
            this.Controls.Add(this.dateTimePickerNgayBatDau);
            this.Controls.Add(this.lbNgayKetThuc);
            this.Controls.Add(this.lbNgayBatDau);
            this.Controls.Add(this.lbPhanTramGiamGiaToiDa);
            this.Controls.Add(this.lbPhanTramGiamGiaMacDinh);
            this.Controls.Add(this.lbTenNgheNghiep);
            this.Controls.Add(this.lbSoLuongKhoaHocDangKy);
            this.Controls.Add(this.txtMoTaLoaiGiamGia);
            this.Controls.Add(this.lbMoTaLoaiGiamGia);
            this.Controls.Add(this.txtMaQuyDinhGiamGia);
            this.Controls.Add(this.lbMaQuyDinhGiamGia);
            this.Controls.Add(this.lbTaoQuyDinhGiamGia);
            this.Controls.Add(this.btnBack);
            this.Name = "frmTaoQuyDinhGiamGia";
            this.Text = "frmTaoQuyDinhGiamGia";
            this.Load += new System.EventHandler(this.frmTaoQuyDinhGiamGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownSoLuongKhoaHocDangKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPhanTramGiamGiaMacDinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPhanTramGiamGiaToiDa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lbTaoQuyDinhGiamGia;
        private System.Windows.Forms.Label lbMaQuyDinhGiamGia;
        private System.Windows.Forms.TextBox txtMaQuyDinhGiamGia;
        private System.Windows.Forms.Label lbMoTaLoaiGiamGia;
        private System.Windows.Forms.TextBox txtMoTaLoaiGiamGia;
        private System.Windows.Forms.Label lbSoLuongKhoaHocDangKy;
        private System.Windows.Forms.Label lbTenNgheNghiep;
        private System.Windows.Forms.Label lbPhanTramGiamGiaMacDinh;
        private System.Windows.Forms.Label lbPhanTramGiamGiaToiDa;
        private System.Windows.Forms.Label lbNgayBatDau;
        private System.Windows.Forms.Label lbNgayKetThuc;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayBatDau;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayKetThuc;
        private System.Windows.Forms.Button btnTaoQuyDinhGiamGIa;
        private System.Windows.Forms.ComboBox cboNgheNghiep;
        private System.Windows.Forms.NumericUpDown numUpDownSoLuongKhoaHocDangKy;
        private System.Windows.Forms.NumericUpDown numUpDownPhanTramGiamGiaMacDinh;
        private System.Windows.Forms.NumericUpDown numUpDownPhanTramGiamGiaToiDa;
    }
}