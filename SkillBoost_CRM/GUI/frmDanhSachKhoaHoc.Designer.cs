namespace GUI
{
    partial class frmDanhSachKhoaHoc
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
            this.grLocKhoaHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDanhSachKhoaHoc)).BeginInit();
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
            this.grLocKhoaHoc.Location = new System.Drawing.Point(1379, 102);
            this.grLocKhoaHoc.Name = "grLocKhoaHoc";
            this.grLocKhoaHoc.Size = new System.Drawing.Size(391, 179);
            this.grLocKhoaHoc.TabIndex = 19;
            this.grLocKhoaHoc.TabStop = false;
            this.grLocKhoaHoc.Text = "Lọc khóa học";
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Location = new System.Drawing.Point(203, 78);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(161, 28);
            this.cbTrangThai.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(200, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Trạng thái:";
            // 
            // btnHuyLoc
            // 
            this.btnHuyLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyLoc.Location = new System.Drawing.Point(203, 134);
            this.btnHuyLoc.Name = "btnHuyLoc";
            this.btnHuyLoc.Size = new System.Drawing.Size(75, 23);
            this.btnHuyLoc.TabIndex = 13;
            this.btnHuyLoc.Text = "Hủy lọc";
            this.btnHuyLoc.UseVisualStyleBackColor = true;
            this.btnHuyLoc.Click += new System.EventHandler(this.btnHuyLoc_Click);
            // 
            // cbGiangVien
            // 
            this.cbGiangVien.FormattingEnabled = true;
            this.cbGiangVien.Location = new System.Drawing.Point(17, 78);
            this.cbGiangVien.Name = "cbGiangVien";
            this.cbGiangVien.Size = new System.Drawing.Size(161, 28);
            this.cbGiangVien.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Giảng viên:";
            // 
            // btnLoc
            // 
            this.btnLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.Location = new System.Drawing.Point(289, 134);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(75, 23);
            this.btnLoc.TabIndex = 5;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(688, 119);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 18;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtThanhTimKiem
            // 
            this.txtThanhTimKiem.Location = new System.Drawing.Point(378, 119);
            this.txtThanhTimKiem.Name = "txtThanhTimKiem";
            this.txtThanhTimKiem.Size = new System.Drawing.Size(304, 22);
            this.txtThanhTimKiem.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(290, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tìm kiếm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Danh sách khóa học";
            // 
            // dataGridDanhSachKhoaHoc
            // 
            this.dataGridDanhSachKhoaHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDanhSachKhoaHoc.Location = new System.Drawing.Point(29, 304);
            this.dataGridDanhSachKhoaHoc.Name = "dataGridDanhSachKhoaHoc";
            this.dataGridDanhSachKhoaHoc.RowHeadersWidth = 51;
            this.dataGridDanhSachKhoaHoc.RowTemplate.Height = 24;
            this.dataGridDanhSachKhoaHoc.Size = new System.Drawing.Size(1741, 524);
            this.dataGridDanhSachKhoaHoc.TabIndex = 14;
            // 
            // frmDanhSachKhoaHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1782, 549);
            this.Controls.Add(this.grLocKhoaHoc);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtThanhTimKiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridDanhSachKhoaHoc);
            this.Name = "frmDanhSachKhoaHoc";
            this.Text = "frmDanhSachKhoaHoc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDanhSachKhoaHoc_Load);
            this.grLocKhoaHoc.ResumeLayout(false);
            this.grLocKhoaHoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDanhSachKhoaHoc)).EndInit();
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
    }
}