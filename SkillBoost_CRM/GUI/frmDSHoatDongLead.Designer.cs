namespace GUI
{
    partial class frmDSHoatDongLead
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridDanhSachHoatDong = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ThongTinChungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BaoGiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HoạtđộngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBack = new System.Windows.Forms.Button();
            this.lb_LeadName = new System.Windows.Forms.Label();
            this.grLocHoatDongLead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDanhSachHoatDong)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            this.grLocHoatDongLead.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grLocHoatDongLead.Location = new System.Drawing.Point(177, 244);
            this.grLocHoatDongLead.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grLocHoatDongLead.Name = "grLocHoatDongLead";
            this.grLocHoatDongLead.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grLocHoatDongLead.Size = new System.Drawing.Size(1069, 194);
            this.grLocHoatDongLead.TabIndex = 14;
            this.grLocHoatDongLead.TabStop = false;
            this.grLocHoatDongLead.Text = "Lọc hoạt động Lead";
            // 
            // btnHuyLoc
            // 
            this.btnHuyLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyLoc.Location = new System.Drawing.Point(735, 95);
            this.btnHuyLoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHuyLoc.Name = "btnHuyLoc";
            this.btnHuyLoc.Size = new System.Drawing.Size(127, 47);
            this.btnHuyLoc.TabIndex = 13;
            this.btnHuyLoc.Text = "Hủy lọc";
            this.btnHuyLoc.UseVisualStyleBackColor = true;
            this.btnHuyLoc.Click += new System.EventHandler(this.btnHuyLoc_Click);
            // 
            // cbDuocTaoBoi
            // 
            this.cbDuocTaoBoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDuocTaoBoi.FormattingEnabled = true;
            this.cbDuocTaoBoi.Location = new System.Drawing.Point(401, 95);
            this.cbDuocTaoBoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbDuocTaoBoi.Name = "cbDuocTaoBoi";
            this.cbDuocTaoBoi.Size = new System.Drawing.Size(302, 37);
            this.cbDuocTaoBoi.TabIndex = 12;
            this.cbDuocTaoBoi.SelectedIndexChanged += new System.EventHandler(this.cbDuocTaoBoi_SelectedIndexChanged);
            // 
            // cbLoaiHoatDong
            // 
            this.cbLoaiHoatDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiHoatDong.FormattingEnabled = true;
            this.cbLoaiHoatDong.Location = new System.Drawing.Point(19, 95);
            this.cbLoaiHoatDong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbLoaiHoatDong.Name = "cbLoaiHoatDong";
            this.cbLoaiHoatDong.Size = new System.Drawing.Size(302, 37);
            this.cbLoaiHoatDong.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(398, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Được tạo bởi:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Loại hoạt động:";
            // 
            // btnLoc
            // 
            this.btnLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.Location = new System.Drawing.Point(891, 95);
            this.btnLoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(139, 47);
            this.btnLoc.TabIndex = 5;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // btnThemHoatDongLead
            // 
            this.btnThemHoatDongLead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemHoatDongLead.Location = new System.Drawing.Point(1979, 322);
            this.btnThemHoatDongLead.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThemHoatDongLead.Name = "btnThemHoatDongLead";
            this.btnThemHoatDongLead.Size = new System.Drawing.Size(168, 56);
            this.btnThemHoatDongLead.TabIndex = 13;
            this.btnThemHoatDongLead.Text = "Thêm";
            this.btnThemHoatDongLead.UseVisualStyleBackColor = true;
            this.btnThemHoatDongLead.Click += new System.EventHandler(this.btnThemHoatDongLead_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(1780, 322);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(145, 56);
            this.btnTimKiem.TabIndex = 12;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtThanhTimKiem
            // 
            this.txtThanhTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhTimKiem.Location = new System.Drawing.Point(1304, 322);
            this.txtThanhTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtThanhTimKiem.Multiline = true;
            this.txtThanhTimKiem.Name = "txtThanhTimKiem";
            this.txtThanhTimKiem.Size = new System.Drawing.Size(456, 56);
            this.txtThanhTimKiem.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Danh sách hoạt động Lead";
            // 
            // dataGridDanhSachHoatDong
            // 
            this.dataGridDanhSachHoatDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDanhSachHoatDong.Location = new System.Drawing.Point(177, 463);
            this.dataGridDanhSachHoatDong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridDanhSachHoatDong.Name = "dataGridDanhSachHoatDong";
            this.dataGridDanhSachHoatDong.RowHeadersWidth = 51;
            this.dataGridDanhSachHoatDong.RowTemplate.Height = 24;
            this.dataGridDanhSachHoatDong.Size = new System.Drawing.Size(1970, 605);
            this.dataGridDanhSachHoatDong.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ThongTinChungToolStripMenuItem,
            this.BaoGiaToolStripMenuItem,
            this.HoạtđộngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(2358, 33);
            this.menuStrip1.TabIndex = 89;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ThongTinChungToolStripMenuItem
            // 
            this.ThongTinChungToolStripMenuItem.Name = "ThongTinChungToolStripMenuItem";
            this.ThongTinChungToolStripMenuItem.Size = new System.Drawing.Size(158, 32);
            this.ThongTinChungToolStripMenuItem.Text = "Thông tin chung";
            this.ThongTinChungToolStripMenuItem.Click += new System.EventHandler(this.ThongTinChungToolStripMenuItem_Click);
            // 
            // BaoGiaToolStripMenuItem
            // 
            this.BaoGiaToolStripMenuItem.Name = "BaoGiaToolStripMenuItem";
            this.BaoGiaToolStripMenuItem.Size = new System.Drawing.Size(87, 32);
            this.BaoGiaToolStripMenuItem.Text = "Báo giá";
            // 
            // HoạtđộngToolStripMenuItem
            // 
            this.HoạtđộngToolStripMenuItem.Name = "HoạtđộngToolStripMenuItem";
            this.HoạtđộngToolStripMenuItem.Size = new System.Drawing.Size(115, 32);
            this.HoạtđộngToolStripMenuItem.Text = "Hoạt động";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(177, 149);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(61, 51);
            this.btnBack.TabIndex = 90;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lb_LeadName
            // 
            this.lb_LeadName.AutoSize = true;
            this.lb_LeadName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LeadName.Location = new System.Drawing.Point(170, 78);
            this.lb_LeadName.Name = "lb_LeadName";
            this.lb_LeadName.Size = new System.Drawing.Size(265, 37);
            this.lb_LeadName.TabIndex = 91;
            this.lb_LeadName.Text = "Phan Duy Trọng";
            this.lb_LeadName.Click += new System.EventHandler(this.label2_Click);
            // 
            // frmDSHoatDongLead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2358, 1081);
            this.Controls.Add(this.lb_LeadName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.grLocHoatDongLead);
            this.Controls.Add(this.btnThemHoatDongLead);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtThanhTimKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridDanhSachHoatDong);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDSHoatDongLead";
            this.Text = "frmDanhSachHoatDongLead";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDanhSachHoatDongLead_Load);
            this.grLocHoatDongLead.ResumeLayout(false);
            this.grLocHoatDongLead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDanhSachHoatDong)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridDanhSachHoatDong;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ThongTinChungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BaoGiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HoạtđộngToolStripMenuItem;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lb_LeadName;
    }
}