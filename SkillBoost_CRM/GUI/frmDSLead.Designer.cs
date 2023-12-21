namespace GUI
{
    partial class frmDSLead
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
            this.dataGridViewDSLead = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.yêuCầuTưVấnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quyĐịnhGiảmGiáToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinKhóaHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSLead)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewDSLead
            // 
            this.dataGridViewDSLead.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDSLead.Location = new System.Drawing.Point(162, 130);
            this.dataGridViewDSLead.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewDSLead.Name = "dataGridViewDSLead";
            this.dataGridViewDSLead.RowHeadersWidth = 82;
            this.dataGridViewDSLead.RowTemplate.Height = 33;
            this.dataGridViewDSLead.Size = new System.Drawing.Size(2081, 1003);
            this.dataGridViewDSLead.TabIndex = 11;
            this.dataGridViewDSLead.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDSLead_CellDoubleClick);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(2115, 62);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(128, 51);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 46);
            this.label1.TabIndex = 6;
            this.label1.Text = "Danh sách Lead";
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
            this.menuStrip1.Size = new System.Drawing.Size(2397, 33);
            this.menuStrip1.TabIndex = 89;
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
            this.thôngTinKhóaHọcToolStripMenuItem.Click += new System.EventHandler(this.thôngTinKhóaHọcToolStripMenuItem_Click);
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(91, 29);
            this.báoCáoToolStripMenuItem.Text = "Báo cáo";
            this.báoCáoToolStripMenuItem.Click += new System.EventHandler(this.báoCáoToolStripMenuItem_Click);
            // 
            // frmDSLead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2397, 1194);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridViewDSLead);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label1);
            this.Name = "frmDSLead";
            this.Text = "frmDSLead";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDSLead_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSLead)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDSLead;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yêuCầuTưVấnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quyĐịnhGiảmGiáToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinKhóaHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
    }
}