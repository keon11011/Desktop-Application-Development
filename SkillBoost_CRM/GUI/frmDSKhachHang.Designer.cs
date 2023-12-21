namespace GUI
{
    partial class frmDSKhachHang
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
            this.txtTimKH = new System.Windows.Forms.TextBox();
            this.btnTimKH = new System.Windows.Forms.Button();
            this.dtgvKhachHang = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.yêuCầuTưVấnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quyĐịnhGiảmGiáToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinKhóaHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grLocHoatDongLead = new System.Windows.Forms.GroupBox();
            this.btnHuyLoc = new System.Windows.Forms.Button();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLoc = new System.Windows.Forms.Button();
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKhachHang)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.grLocHoatDongLead.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTimKH
            // 
            this.txtTimKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKH.Location = new System.Drawing.Point(1260, 272);
            this.txtTimKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKH.Name = "txtTimKH";
            this.txtTimKH.Size = new System.Drawing.Size(782, 44);
            this.txtTimKH.TabIndex = 11;
            this.txtTimKH.TextChanged += new System.EventHandler(this.txtTimKH_TextChanged);
            // 
            // btnTimKH
            // 
            this.btnTimKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKH.Location = new System.Drawing.Point(2063, 266);
            this.btnTimKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKH.Name = "btnTimKH";
            this.btnTimKH.Size = new System.Drawing.Size(101, 55);
            this.btnTimKH.TabIndex = 10;
            this.btnTimKH.Text = "Tìm kiếm";
            this.btnTimKH.UseVisualStyleBackColor = true;
            this.btnTimKH.Click += new System.EventHandler(this.btnTimKH_Click);
            // 
            // dtgvKhachHang
            // 
            this.dtgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvKhachHang.Location = new System.Drawing.Point(150, 417);
            this.dtgvKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvKhachHang.Name = "dtgvKhachHang";
            this.dtgvKhachHang.RowHeadersWidth = 62;
            this.dtgvKhachHang.RowTemplate.Height = 28;
            this.dtgvKhachHang.Size = new System.Drawing.Size(2022, 815);
            this.dtgvKhachHang.TabIndex = 8;
            this.dtgvKhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 46);
            this.label1.TabIndex = 7;
            this.label1.Text = "Danh sách Khách hàng";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yêuCầuTưVấnToolStripMenuItem,
            this.leadToolStripMenuItem,
            this.kháchHàngToolStripMenuItem,
            this.quyĐịnhGiảmGiáToolStripMenuItem,
            this.thôngTinKhóaHọcToolStripMenuItem,
            this.báoCáoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(2417, 33);
            this.menuStrip1.TabIndex = 87;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // yêuCầuTưVấnToolStripMenuItem
            // 
            this.yêuCầuTưVấnToolStripMenuItem.Name = "yêuCầuTưVấnToolStripMenuItem";
            this.yêuCầuTưVấnToolStripMenuItem.Size = new System.Drawing.Size(142, 29);
            this.yêuCầuTưVấnToolStripMenuItem.Text = "Yêu cầu tư vấn";
            this.yêuCầuTưVấnToolStripMenuItem.Click += new System.EventHandler(this.yêuCầuTưVấnToolStripMenuItem_Click);
            // 
            // leadToolStripMenuItem
            // 
            this.leadToolStripMenuItem.Name = "leadToolStripMenuItem";
            this.leadToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.leadToolStripMenuItem.Text = "Lead";
            this.leadToolStripMenuItem.Click += new System.EventHandler(this.leadToolStripMenuItem_Click);
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(120, 29);
            this.kháchHàngToolStripMenuItem.Text = "Khách hàng";
            this.kháchHàngToolStripMenuItem.Click += new System.EventHandler(this.kháchHàngToolStripMenuItem_Click);
            // 
            // quyĐịnhGiảmGiáToolStripMenuItem
            // 
            this.quyĐịnhGiảmGiáToolStripMenuItem.Name = "quyĐịnhGiảmGiáToolStripMenuItem";
            this.quyĐịnhGiảmGiáToolStripMenuItem.Size = new System.Drawing.Size(175, 29);
            this.quyĐịnhGiảmGiáToolStripMenuItem.Text = "Quy định giảm giá";
            this.quyĐịnhGiảmGiáToolStripMenuItem.Click += new System.EventHandler(this.quyĐịnhGiảmGiáToolStripMenuItem_Click);
            // 
            // thôngTinKhóaHọcToolStripMenuItem
            // 
            this.thôngTinKhóaHọcToolStripMenuItem.Name = "thôngTinKhóaHọcToolStripMenuItem";
            this.thôngTinKhóaHọcToolStripMenuItem.Size = new System.Drawing.Size(182, 29);
            this.thôngTinKhóaHọcToolStripMenuItem.Text = "Thông tin khóa học";
            this.thôngTinKhóaHọcToolStripMenuItem.Click += new System.EventHandler(this.thôngTinKhóaHọcToolStripMenuItem_Click);
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(91, 29);
            this.báoCáoToolStripMenuItem.Text = "Báo cáo";
            this.báoCáoToolStripMenuItem.Click += new System.EventHandler(this.báoCáoToolStripMenuItem_Click);
            // 
            // grLocHoatDongLead
            // 
            this.grLocHoatDongLead.Controls.Add(this.cbTrangThai);
            this.grLocHoatDongLead.Controls.Add(this.label2);
            this.grLocHoatDongLead.Controls.Add(this.btnHuyLoc);
            this.grLocHoatDongLead.Controls.Add(this.cbGioiTinh);
            this.grLocHoatDongLead.Controls.Add(this.label3);
            this.grLocHoatDongLead.Controls.Add(this.btnLoc);
            this.grLocHoatDongLead.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grLocHoatDongLead.Location = new System.Drawing.Point(150, 177);
            this.grLocHoatDongLead.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grLocHoatDongLead.Name = "grLocHoatDongLead";
            this.grLocHoatDongLead.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grLocHoatDongLead.Size = new System.Drawing.Size(1043, 194);
            this.grLocHoatDongLead.TabIndex = 88;
            this.grLocHoatDongLead.TabStop = false;
            this.grLocHoatDongLead.Text = "Lọc khách hàng";
            // 
            // btnHuyLoc
            // 
            this.btnHuyLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyLoc.Location = new System.Drawing.Point(708, 89);
            this.btnHuyLoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHuyLoc.Name = "btnHuyLoc";
            this.btnHuyLoc.Size = new System.Drawing.Size(127, 47);
            this.btnHuyLoc.TabIndex = 13;
            this.btnHuyLoc.Text = "Hủy lọc";
            this.btnHuyLoc.UseVisualStyleBackColor = true;
            this.btnHuyLoc.Click += new System.EventHandler(this.btnHuyLoc_Click);
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Location = new System.Drawing.Point(19, 95);
            this.cbGioiTinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(151, 37);
            this.cbGioiTinh.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Giới tính:";
            // 
            // btnLoc
            // 
            this.btnLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.Location = new System.Drawing.Point(874, 89);
            this.btnLoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(139, 47);
            this.btnLoc.TabIndex = 5;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Location = new System.Drawing.Point(238, 95);
            this.cbTrangThai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(427, 37);
            this.cbTrangThai.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(235, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Trạng thái";
            // 
            // frmDSKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2417, 1262);
            this.Controls.Add(this.grLocHoatDongLead);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtTimKH);
            this.Controls.Add(this.btnTimKH);
            this.Controls.Add(this.dtgvKhachHang);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDSKhachHang";
            this.Text = "frmDanhSachKH";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDanhSachKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKhachHang)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grLocHoatDongLead.ResumeLayout(false);
            this.grLocHoatDongLead.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTimKH;
        private System.Windows.Forms.Button btnTimKH;
        private System.Windows.Forms.DataGridView dtgvKhachHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yêuCầuTưVấnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quyĐịnhGiảmGiáToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinKhóaHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
        private System.Windows.Forms.GroupBox grLocHoatDongLead;
        private System.Windows.Forms.Button btnHuyLoc;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.ComboBox cbTrangThai;
        private System.Windows.Forms.Label label2;
    }
}