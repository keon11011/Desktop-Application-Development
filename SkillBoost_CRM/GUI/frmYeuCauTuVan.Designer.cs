﻿namespace GUI
{
    partial class frmYeuCauTuVan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtTimYCTV = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnDaTiepNhan = new System.Windows.Forms.RadioButton();
            this.rdnChuaTiepNhan = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.yêuCầuTưVấnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quyĐịnhGiảmGiáToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinKhóaHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTimYCTV
            // 
            this.txtTimYCTV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimYCTV.Location = new System.Drawing.Point(480, 84);
            this.txtTimYCTV.Name = "txtTimYCTV";
            this.txtTimYCTV.Size = new System.Drawing.Size(246, 22);
            this.txtTimYCTV.TabIndex = 13;
            // 
            // btnTim
            // 
            this.btnTim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTim.Location = new System.Drawing.Point(745, 83);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 12;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Location = new System.Drawing.Point(45, 121);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1059, 499);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Danh sách yêu cầu tư vấn";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "YÊU CẦU TƯ VẤN";
            // 
            // rbtnDaTiepNhan
            // 
            this.rbtnDaTiepNhan.AutoSize = true;
            this.rbtnDaTiepNhan.Location = new System.Drawing.Point(6, 23);
            this.rbtnDaTiepNhan.Name = "rbtnDaTiepNhan";
            this.rbtnDaTiepNhan.Size = new System.Drawing.Size(102, 20);
            this.rbtnDaTiepNhan.TabIndex = 6;
            this.rbtnDaTiepNhan.TabStop = true;
            this.rbtnDaTiepNhan.Text = "Đã tiếp nhận";
            this.rbtnDaTiepNhan.UseVisualStyleBackColor = true;
            this.rbtnDaTiepNhan.CheckedChanged += new System.EventHandler(this.rbtnDaTiepNhan_CheckedChanged);
            // 
            // rdnChuaTiepNhan
            // 
            this.rdnChuaTiepNhan.AutoSize = true;
            this.rdnChuaTiepNhan.Location = new System.Drawing.Point(132, 22);
            this.rdnChuaTiepNhan.Name = "rdnChuaTiepNhan";
            this.rdnChuaTiepNhan.Size = new System.Drawing.Size(116, 20);
            this.rdnChuaTiepNhan.TabIndex = 7;
            this.rdnChuaTiepNhan.TabStop = true;
            this.rdnChuaTiepNhan.Text = "Chưa tiếp nhận";
            this.rdnChuaTiepNhan.UseVisualStyleBackColor = true;
            this.rdnChuaTiepNhan.CheckedChanged += new System.EventHandler(this.rdnChuaTiepNhan_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rbtnDaTiepNhan);
            this.groupBox1.Controls.Add(this.rdnChuaTiepNhan);
            this.groupBox1.Location = new System.Drawing.Point(836, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 49);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lọc Trạng Thái";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yêuCầuTưVấnToolStripMenuItem,
            this.leadToolStripMenuItem,
            this.kháchHàngToolStripMenuItem,
            this.quyĐịnhGiảmGiáToolStripMenuItem,
            this.thôngTinKhóaHọcToolStripMenuItem,
            this.báoCáoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1169, 28);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // yêuCầuTưVấnToolStripMenuItem
            // 
            this.yêuCầuTưVấnToolStripMenuItem.Name = "yêuCầuTưVấnToolStripMenuItem";
            this.yêuCầuTưVấnToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.yêuCầuTưVấnToolStripMenuItem.Text = "Yêu Cầu Tư Vấn";
            this.yêuCầuTưVấnToolStripMenuItem.Click += new System.EventHandler(this.yêuCầuTưVấnToolStripMenuItem_Click);
            // 
            // leadToolStripMenuItem
            // 
            this.leadToolStripMenuItem.Name = "leadToolStripMenuItem";
            this.leadToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
            this.leadToolStripMenuItem.Text = "Lead";
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(100, 26);
            this.kháchHàngToolStripMenuItem.Text = "Khách hàng";
            // 
            // quyĐịnhGiảmGiáToolStripMenuItem
            // 
            this.quyĐịnhGiảmGiáToolStripMenuItem.Name = "quyĐịnhGiảmGiáToolStripMenuItem";
            this.quyĐịnhGiảmGiáToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.quyĐịnhGiảmGiáToolStripMenuItem.Text = "Quy định giảm giá";
            // 
            // thôngTinKhóaHọcToolStripMenuItem
            // 
            this.thôngTinKhóaHọcToolStripMenuItem.Name = "thôngTinKhóaHọcToolStripMenuItem";
            this.thôngTinKhóaHọcToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.thôngTinKhóaHọcToolStripMenuItem.Text = "Thông tin khóa học";
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(77, 26);
            this.báoCáoToolStripMenuItem.Text = "Báo cáo";
            this.báoCáoToolStripMenuItem.Click += new System.EventHandler(this.báoCáoToolStripMenuItem_Click);
            // 
            // frmYeuCauTuVan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 659);
            this.Controls.Add(this.txtTimYCTV);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmYeuCauTuVan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmYeuCauTuVan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmYeuCauTuVan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTimYCTV;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnDaTiepNhan;
        private System.Windows.Forms.RadioButton rdnChuaTiepNhan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yêuCầuTưVấnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quyĐịnhGiảmGiáToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinKhóaHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
    }
}