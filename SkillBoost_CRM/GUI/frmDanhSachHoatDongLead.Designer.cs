namespace GUI
{
    partial class frmDanhSachHoatDongLead
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
            this.grLocHoatDongLead = new System.Windows.Forms.GroupBox();
            this.btnHuyLoc = new System.Windows.Forms.Button();
            this.cbDuocTaoBoi = new System.Windows.Forms.ComboBox();
            this.cbLoaiHoatDong = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLoc = new System.Windows.Forms.Button();
            this.btnThemHoatDongLead = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtThanhTimKiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridDanhSachHoatDong = new System.Windows.Forms.DataGridView();
            this.grLocHoatDongLead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDanhSachHoatDong)).BeginInit();
            this.SuspendLayout();
            // 
            // grLocHoatDongLead
            // 
            this.grLocHoatDongLead.Controls.Add(this.btnHuyLoc);
            this.grLocHoatDongLead.Controls.Add(this.cbDuocTaoBoi);
            this.grLocHoatDongLead.Controls.Add(this.cbLoaiHoatDong);
            this.grLocHoatDongLead.Controls.Add(this.label4);
            this.grLocHoatDongLead.Controls.Add(this.label3);
            this.grLocHoatDongLead.Controls.Add(this.btnLoc);
            this.grLocHoatDongLead.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grLocHoatDongLead.Location = new System.Drawing.Point(1283, 74);
            this.grLocHoatDongLead.Name = "grLocHoatDongLead";
            this.grLocHoatDongLead.Size = new System.Drawing.Size(365, 158);
            this.grLocHoatDongLead.TabIndex = 14;
            this.grLocHoatDongLead.TabStop = false;
            this.grLocHoatDongLead.Text = "Lọc hoạt động Lead";
            // 
            // btnHuyLoc
            // 
            this.btnHuyLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyLoc.Location = new System.Drawing.Point(192, 120);
            this.btnHuyLoc.Name = "btnHuyLoc";
            this.btnHuyLoc.Size = new System.Drawing.Size(75, 23);
            this.btnHuyLoc.TabIndex = 13;
            this.btnHuyLoc.Text = "Hủy lọc";
            this.btnHuyLoc.UseVisualStyleBackColor = true;
            this.btnHuyLoc.Click += new System.EventHandler(this.btnHuyLoc_Click);
            // 
            // cbDuocTaoBoi
            // 
            this.cbDuocTaoBoi.FormattingEnabled = true;
            this.cbDuocTaoBoi.Location = new System.Drawing.Point(192, 64);
            this.cbDuocTaoBoi.Name = "cbDuocTaoBoi";
            this.cbDuocTaoBoi.Size = new System.Drawing.Size(161, 28);
            this.cbDuocTaoBoi.TabIndex = 12;
            // 
            // cbLoaiHoatDong
            // 
            this.cbLoaiHoatDong.FormattingEnabled = true;
            this.cbLoaiHoatDong.Location = new System.Drawing.Point(15, 64);
            this.cbLoaiHoatDong.Name = "cbLoaiHoatDong";
            this.cbLoaiHoatDong.Size = new System.Drawing.Size(161, 28);
            this.cbLoaiHoatDong.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(189, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Được tạo bởi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Loại hoạt động:";
            // 
            // btnLoc
            // 
            this.btnLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.Location = new System.Drawing.Point(273, 120);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(75, 23);
            this.btnLoc.TabIndex = 5;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // btnThemHoatDongLead
            // 
            this.btnThemHoatDongLead.Location = new System.Drawing.Point(1681, 58);
            this.btnThemHoatDongLead.Name = "btnThemHoatDongLead";
            this.btnThemHoatDongLead.Size = new System.Drawing.Size(75, 23);
            this.btnThemHoatDongLead.TabIndex = 13;
            this.btnThemHoatDongLead.Text = "Thêm";
            this.btnThemHoatDongLead.UseVisualStyleBackColor = true;
            this.btnThemHoatDongLead.Click += new System.EventHandler(this.btnThemHoatDongLead_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(753, 106);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 12;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtThanhTimKiem
            // 
            this.txtThanhTimKiem.Location = new System.Drawing.Point(443, 106);
            this.txtThanhTimKiem.Name = "txtThanhTimKiem";
            this.txtThanhTimKiem.Size = new System.Drawing.Size(304, 22);
            this.txtThanhTimKiem.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(355, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tìm kiếm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Danh sách hoạt động Lead";
            // 
            // dataGridDanhSachHoatDong
            // 
            this.dataGridDanhSachHoatDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDanhSachHoatDong.Location = new System.Drawing.Point(12, 248);
            this.dataGridDanhSachHoatDong.Name = "dataGridDanhSachHoatDong";
            this.dataGridDanhSachHoatDong.RowHeadersWidth = 51;
            this.dataGridDanhSachHoatDong.RowTemplate.Height = 24;
            this.dataGridDanhSachHoatDong.Size = new System.Drawing.Size(1751, 567);
            this.dataGridDanhSachHoatDong.TabIndex = 8;
            // 
            // frmDanhSachHoatDongLead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1781, 519);
            this.Controls.Add(this.grLocHoatDongLead);
            this.Controls.Add(this.btnThemHoatDongLead);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtThanhTimKiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridDanhSachHoatDong);
            this.Name = "frmDanhSachHoatDongLead";
            this.Text = "frmDanhSachHoatDongLead";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDanhSachHoatDongLead_Load);
            this.grLocHoatDongLead.ResumeLayout(false);
            this.grLocHoatDongLead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDanhSachHoatDong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grLocHoatDongLead;
        private System.Windows.Forms.Button btnHuyLoc;
        private System.Windows.Forms.ComboBox cbDuocTaoBoi;
        private System.Windows.Forms.ComboBox cbLoaiHoatDong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Button btnThemHoatDongLead;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtThanhTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridDanhSachHoatDong;
    }
}