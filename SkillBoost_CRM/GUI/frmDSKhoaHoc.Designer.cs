namespace GUI
{
    partial class frmDSKhoaHoc
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
            this.grLocKhoaHoc = new System.Windows.Forms.GroupBox();
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnHuyLoc = new System.Windows.Forms.Button();
            this.cbGiangVien = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLoc = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtThanhTimKiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridDanhSachKhoaHoc = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.yêuCầuTưVấnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quyĐịnhGiảmGiáToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinKhóaHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grLocKhoaHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDanhSachKhoaHoc)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grLocKhoaHoc
            // 
            this.grLocKhoaHoc.Controls.Add(this.cbTrangThai);
            this.grLocKhoaHoc.Controls.Add(this.label7);
            this.grLocKhoaHoc.Controls.Add(this.btnHuyLoc);
            this.grLocKhoaHoc.Controls.Add(this.cbGiangVien);
            this.grLocKhoaHoc.Controls.Add(this.label4);
            this.grLocKhoaHoc.Controls.Add(this.btnLoc);
            this.grLocKhoaHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grLocKhoaHoc.Location = new System.Drawing.Point(1552, 83);
            this.grLocKhoaHoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grLocKhoaHoc.Name = "grLocKhoaHoc";
            this.grLocKhoaHoc.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grLocKhoaHoc.Size = new System.Drawing.Size(440, 224);
            this.grLocKhoaHoc.TabIndex = 19;
            this.grLocKhoaHoc.TabStop = false;
            this.grLocKhoaHoc.Text = "Lọc khóa học";
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Location = new System.Drawing.Point(228, 98);
            this.cbTrangThai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(181, 33);
            this.cbTrangThai.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(225, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Trạng thái:";
            // 
            // btnHuyLoc
            // 
            this.btnHuyLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyLoc.Location = new System.Drawing.Point(228, 168);
            this.btnHuyLoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHuyLoc.Name = "btnHuyLoc";
            this.btnHuyLoc.Size = new System.Drawing.Size(84, 29);
            this.btnHuyLoc.TabIndex = 13;
            this.btnHuyLoc.Text = "Hủy lọc";
            this.btnHuyLoc.UseVisualStyleBackColor = true;
            this.btnHuyLoc.Click += new System.EventHandler(this.btnHuyLoc_Click);
            // 
            // cbGiangVien
            // 
            this.cbGiangVien.FormattingEnabled = true;
            this.cbGiangVien.Location = new System.Drawing.Point(19, 98);
            this.cbGiangVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbGiangVien.Name = "cbGiangVien";
            this.cbGiangVien.Size = new System.Drawing.Size(181, 33);
            this.cbGiangVien.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Giảng viên:";
            // 
            // btnLoc
            // 
            this.btnLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.Location = new System.Drawing.Point(325, 168);
            this.btnLoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(84, 29);
            this.btnLoc.TabIndex = 5;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(775, 104);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(84, 29);
            this.btnTimKiem.TabIndex = 18;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtThanhTimKiem
            // 
            this.txtThanhTimKiem.Location = new System.Drawing.Point(426, 104);
            this.txtThanhTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtThanhTimKiem.Name = "txtThanhTimKiem";
            this.txtThanhTimKiem.Size = new System.Drawing.Size(342, 26);
            this.txtThanhTimKiem.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(327, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tìm kiếm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Danh sách khóa học";
            // 
            // dataGridDanhSachKhoaHoc
            // 
            this.dataGridDanhSachKhoaHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDanhSachKhoaHoc.Location = new System.Drawing.Point(34, 335);
            this.dataGridDanhSachKhoaHoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridDanhSachKhoaHoc.Name = "dataGridDanhSachKhoaHoc";
            this.dataGridDanhSachKhoaHoc.RowHeadersWidth = 51;
            this.dataGridDanhSachKhoaHoc.RowTemplate.Height = 24;
            this.dataGridDanhSachKhoaHoc.Size = new System.Drawing.Size(1959, 655);
            this.dataGridDanhSachKhoaHoc.TabIndex = 14;
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
            this.menuStrip1.Size = new System.Drawing.Size(2005, 33);
            this.menuStrip1.TabIndex = 88;
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
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(91, 29);
            this.báoCáoToolStripMenuItem.Text = "Báo cáo";
            // 
            // frmDSKhoaHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2005, 1130);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.grLocKhoaHoc);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtThanhTimKiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridDanhSachKhoaHoc);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDSKhoaHoc";
            this.Text = "frmDanhSachKhoaHoc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDanhSachKhoaHoc_Load);
            this.grLocKhoaHoc.ResumeLayout(false);
            this.grLocKhoaHoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDanhSachKhoaHoc)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grLocKhoaHoc;
        private System.Windows.Forms.ComboBox cbTrangThai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnHuyLoc;
        private System.Windows.Forms.ComboBox cbGiangVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtThanhTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridDanhSachKhoaHoc;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yêuCầuTưVấnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quyĐịnhGiảmGiáToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinKhóaHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
    }
}