namespace GUI
{
    partial class frmTaoLead
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
            this.btnXoaKhoaHoc = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnTao = new System.Windows.Forms.Button();
            this.cbKhoaHoc = new System.Windows.Forms.ComboBox();
            this.btnThemKhoaHoc = new System.Windows.Forms.Button();
            this.dateTimePickerNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewKhoaHocKHQuanTam = new System.Windows.Forms.DataGridView();
            this.cbNguonLead = new System.Windows.Forms.ComboBox();
            this.cbNgheNghiep = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhoaHocKHQuanTam)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoaKhoaHoc
            // 
            this.btnXoaKhoaHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaKhoaHoc.Location = new System.Drawing.Point(1179, 985);
            this.btnXoaKhoaHoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoaKhoaHoc.Name = "btnXoaKhoaHoc";
            this.btnXoaKhoaHoc.Size = new System.Drawing.Size(202, 58);
            this.btnXoaKhoaHoc.TabIndex = 181;
            this.btnXoaKhoaHoc.Text = "Xóa khóa học ";
            this.btnXoaKhoaHoc.UseVisualStyleBackColor = true;
            this.btnXoaKhoaHoc.Click += new System.EventHandler(this.btnXoaKhoaHoc_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(1728, 505);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 36);
            this.label10.TabIndex = 180;
            this.label10.Text = "*";
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Location = new System.Drawing.Point(1613, 565);
            this.cbGioiTinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(530, 40);
            this.cbGioiTinh.TabIndex = 179;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1606, 505);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 36);
            this.label5.TabIndex = 178;
            this.label5.Text = "Giới tính";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(1994, 1045);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(152, 74);
            this.btnHuy.TabIndex = 177;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click_1);
            // 
            // btnTao
            // 
            this.btnTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTao.Location = new System.Drawing.Point(1790, 1045);
            this.btnTao.Margin = new System.Windows.Forms.Padding(2);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(152, 74);
            this.btnTao.TabIndex = 176;
            this.btnTao.Text = "Tạo";
            this.btnTao.UseVisualStyleBackColor = true;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // cbKhoaHoc
            // 
            this.cbKhoaHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhoaHoc.FormattingEnabled = true;
            this.cbKhoaHoc.Location = new System.Drawing.Point(265, 990);
            this.cbKhoaHoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbKhoaHoc.Name = "cbKhoaHoc";
            this.cbKhoaHoc.Size = new System.Drawing.Size(546, 40);
            this.cbKhoaHoc.TabIndex = 175;
            // 
            // btnThemKhoaHoc
            // 
            this.btnThemKhoaHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemKhoaHoc.Location = new System.Drawing.Point(952, 985);
            this.btnThemKhoaHoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThemKhoaHoc.Name = "btnThemKhoaHoc";
            this.btnThemKhoaHoc.Size = new System.Drawing.Size(202, 58);
            this.btnThemKhoaHoc.TabIndex = 174;
            this.btnThemKhoaHoc.Text = "Thêm khóa học ";
            this.btnThemKhoaHoc.UseVisualStyleBackColor = true;
            this.btnThemKhoaHoc.Click += new System.EventHandler(this.btnThemKhoaHoc_Click);
            // 
            // dateTimePickerNgaySinh
            // 
            this.dateTimePickerNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgaySinh.Location = new System.Drawing.Point(1613, 408);
            this.dateTimePickerNgaySinh.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerNgaySinh.Name = "dateTimePickerNgaySinh";
            this.dateTimePickerNgaySinh.Size = new System.Drawing.Size(530, 41);
            this.dateTimePickerNgaySinh.TabIndex = 173;
            // 
            // dataGridViewKhoaHocKHQuanTam
            // 
            this.dataGridViewKhoaHocKHQuanTam.AllowUserToOrderColumns = true;
            this.dataGridViewKhoaHocKHQuanTam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKhoaHocKHQuanTam.Enabled = false;
            this.dataGridViewKhoaHocKHQuanTam.Location = new System.Drawing.Point(265, 721);
            this.dataGridViewKhoaHocKHQuanTam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewKhoaHocKHQuanTam.Name = "dataGridViewKhoaHocKHQuanTam";
            this.dataGridViewKhoaHocKHQuanTam.ReadOnly = true;
            this.dataGridViewKhoaHocKHQuanTam.RowHeadersWidth = 82;
            this.dataGridViewKhoaHocKHQuanTam.Size = new System.Drawing.Size(1881, 254);
            this.dataGridViewKhoaHocKHQuanTam.TabIndex = 172;
            // 
            // cbNguonLead
            // 
            this.cbNguonLead.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNguonLead.FormattingEnabled = true;
            this.cbNguonLead.Location = new System.Drawing.Point(983, 408);
            this.cbNguonLead.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbNguonLead.Name = "cbNguonLead";
            this.cbNguonLead.Size = new System.Drawing.Size(546, 40);
            this.cbNguonLead.TabIndex = 171;
            // 
            // cbNgheNghiep
            // 
            this.cbNgheNghiep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNgheNghiep.FormattingEnabled = true;
            this.cbNgheNghiep.Location = new System.Drawing.Point(1613, 246);
            this.cbNgheNghiep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbNgheNghiep.Name = "cbNgheNghiep";
            this.cbNgheNghiep.Size = new System.Drawing.Size(530, 40);
            this.cbNgheNghiep.TabIndex = 170;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(259, 679);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(280, 36);
            this.label15.TabIndex = 169;
            this.label15.Text = "Khóa học quan tâm ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(1756, 343);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(28, 36);
            this.label17.TabIndex = 168;
            this.label17.Text = "*";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(265, 547);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(722, 104);
            this.txtGhiChu.TabIndex = 167;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(259, 505);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(232, 36);
            this.label16.TabIndex = 166;
            this.label16.Text = "Ghi chú về Lead";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(1156, 343);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 36);
            this.label2.TabIndex = 165;
            this.label2.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(976, 343);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(179, 36);
            this.label12.TabIndex = 164;
            this.label12.Text = "Nguồn Lead";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1606, 174);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(186, 36);
            this.label11.TabIndex = 163;
            this.label11.Text = "Nghề nghiệp";
            this.label11.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(983, 249);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(546, 41);
            this.txtEmail.TabIndex = 162;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(1048, 174);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 36);
            this.label8.TabIndex = 161;
            this.label8.Text = "*";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDienThoai.Location = new System.Drawing.Point(273, 406);
            this.txtSoDienThoai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(546, 41);
            this.txtSoDienThoai.TabIndex = 159;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(445, 331);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 36);
            this.label6.TabIndex = 158;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(265, 331);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 36);
            this.label7.TabIndex = 157;
            this.label7.Text = "Số điện thoại";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(1607, 343);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(149, 36);
            this.label.TabIndex = 156;
            this.label.Text = "Ngày sinh";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(976, 174);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 36);
            this.label9.TabIndex = 160;
            this.label9.Text = "Email";
            // 
            // txtHoten
            // 
            this.txtHoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoten.Location = new System.Drawing.Point(265, 246);
            this.txtHoten.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.ShortcutsEnabled = false;
            this.txtHoten.Size = new System.Drawing.Size(530, 41);
            this.txtHoten.TabIndex = 155;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(353, 179);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 36);
            this.label3.TabIndex = 154;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(257, 179);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 36);
            this.label4.TabIndex = 153;
            this.label4.Text = "Họ tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 46);
            this.label1.TabIndex = 152;
            this.label1.Text = "Tạo Lead mới";
            // 
            // frmTaoLead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2387, 1177);
            this.Controls.Add(this.btnXoaKhoaHoc);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbGioiTinh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.cbKhoaHoc);
            this.Controls.Add(this.btnThemKhoaHoc);
            this.Controls.Add(this.dateTimePickerNgaySinh);
            this.Controls.Add(this.dataGridViewKhoaHocKHQuanTam);
            this.Controls.Add(this.cbNguonLead);
            this.Controls.Add(this.cbNgheNghiep);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.label16);
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
            this.Controls.Add(this.label1);
            this.Name = "frmTaoLead";
            this.Text = "frmTaoLead";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTaoLead_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhoaHocKHQuanTam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXoaKhoaHoc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.ComboBox cbKhoaHoc;
        private System.Windows.Forms.Button btnThemKhoaHoc;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgaySinh;
        private System.Windows.Forms.DataGridView dataGridViewKhoaHocKHQuanTam;
        private System.Windows.Forms.ComboBox cbNguonLead;
        private System.Windows.Forms.ComboBox cbNgheNghiep;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label16;
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
        private System.Windows.Forms.Label label1;
    }
}