﻿namespace GUI
{
    partial class frmYCTV_KhachHang
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
            this.components = new System.ComponentModel.Container();
            this.btnGuiYCTV = new System.Windows.Forms.Button();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtGhichu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbKhoaHoc = new System.Windows.Forms.ComboBox();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuiYCTV
            // 
            this.btnGuiYCTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuiYCTV.Location = new System.Drawing.Point(446, 500);
            this.btnGuiYCTV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuiYCTV.Name = "btnGuiYCTV";
            this.btnGuiYCTV.Size = new System.Drawing.Size(205, 68);
            this.btnGuiYCTV.TabIndex = 32;
            this.btnGuiYCTV.Text = "Gửi yêu cầu tư vấn";
            this.btnGuiYCTV.UseVisualStyleBackColor = true;
            this.btnGuiYCTV.Click += new System.EventHandler(this.btnGuiYCTV_Click);
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(213, 214);
            this.txtSdt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(304, 26);
            this.txtSdt.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(579, 214);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(304, 26);
            this.txtEmail.TabIndex = 4;
            // 
            // txtGhichu
            // 
            this.txtGhichu.Location = new System.Drawing.Point(579, 288);
            this.txtGhichu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGhichu.Multiline = true;
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.Size = new System.Drawing.Size(304, 179);
            this.txtGhichu.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(576, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 22);
            this.label9.TabIndex = 27;
            this.label9.Text = "Ngày sinh *";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(208, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 22);
            this.label8.TabIndex = 26;
            this.label8.Text = "Số điện thoại *";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(576, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 22);
            this.label7.TabIndex = 25;
            this.label7.Text = "Email *";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(208, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 22);
            this.label6.TabIndex = 24;
            this.label6.Text = "Khóa học quan tâm *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(578, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 22);
            this.label5.TabIndex = 23;
            this.label5.Text = "Ghi chú";
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(213, 150);
            this.txtHoten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(304, 26);
            this.txtHoten.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(208, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 22);
            this.label2.TabIndex = 21;
            this.label2.Text = "Họ tên *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(435, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "Thông tin nhận tư vấn";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "yyyy-MM-dd";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(582, 151);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(302, 26);
            this.dtpNgaySinh.TabIndex = 2;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cbKhoaHoc
            // 
            this.cbKhoaHoc.FormattingEnabled = true;
            this.cbKhoaHoc.Location = new System.Drawing.Point(213, 288);
            this.cbKhoaHoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbKhoaHoc.Name = "cbKhoaHoc";
            this.cbKhoaHoc.Size = new System.Drawing.Size(304, 28);
            this.cbKhoaHoc.TabIndex = 5;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // frmYCTV_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 696);
            this.Controls.Add(this.cbKhoaHoc);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.btnGuiYCTV);
            this.Controls.Add(this.txtSdt);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtGhichu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmYCTV_KhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin nhận tư vấn";
            this.Load += new System.EventHandler(this.frmYCTV_KhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.Button btnGuiYCTV;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtGhichu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cbKhoaHoc;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}