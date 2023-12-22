namespace GUI
{
    partial class frmDSBaoGiaCuaLead
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.yêuCầuTưVấnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTao = new System.Windows.Forms.Button();
            this.lbDSBaoGia = new System.Windows.Forms.Label();
            this.txtHoTenLead = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(210, 271);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1908, 900);
            this.dataGridView1.TabIndex = 91;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yêuCầuTưVấnToolStripMenuItem,
            this.leadToolStripMenuItem,
            this.kháchHàngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(2391, 31);
            this.menuStrip1.TabIndex = 88;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // yêuCầuTưVấnToolStripMenuItem
            // 
            this.yêuCầuTưVấnToolStripMenuItem.Name = "yêuCầuTưVấnToolStripMenuItem";
            this.yêuCầuTưVấnToolStripMenuItem.Size = new System.Drawing.Size(158, 29);
            this.yêuCầuTưVấnToolStripMenuItem.Text = "Thông tin chung";
            this.yêuCầuTưVấnToolStripMenuItem.Click += new System.EventHandler(this.yêuCầuTưVấnToolStripMenuItem_Click);
            // 
            // leadToolStripMenuItem
            // 
            this.leadToolStripMenuItem.Name = "leadToolStripMenuItem";
            this.leadToolStripMenuItem.Size = new System.Drawing.Size(87, 29);
            this.leadToolStripMenuItem.Text = "Báo giá";
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(115, 29);
            this.kháchHàngToolStripMenuItem.Text = "Hoạt động";
            this.kháchHàngToolStripMenuItem.Click += new System.EventHandler(this.kháchHàngToolStripMenuItem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(1928, 180);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 58);
            this.btnSua.TabIndex = 95;
            this.btnSua.Text = "✏️";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(2043, 180);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 58);
            this.btnXoa.TabIndex = 93;
            this.btnXoa.Text = "🗑️";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTao
            // 
            this.btnTao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTao.Location = new System.Drawing.Point(1811, 180);
            this.btnTao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(75, 58);
            this.btnTao.TabIndex = 92;
            this.btnTao.Text = "➕";
            this.btnTao.UseVisualStyleBackColor = true;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // lbDSBaoGia
            // 
            this.lbDSBaoGia.AutoSize = true;
            this.lbDSBaoGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDSBaoGia.Location = new System.Drawing.Point(491, 185);
            this.lbDSBaoGia.Name = "lbDSBaoGia";
            this.lbDSBaoGia.Size = new System.Drawing.Size(306, 38);
            this.lbDSBaoGia.TabIndex = 90;
            this.lbDSBaoGia.Text = "Danh sách báo giá";
            // 
            // txtHoTenLead
            // 
            this.txtHoTenLead.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTenLead.Location = new System.Drawing.Point(210, 87);
            this.txtHoTenLead.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHoTenLead.Name = "txtHoTenLead";
            this.txtHoTenLead.Size = new System.Drawing.Size(631, 52);
            this.txtHoTenLead.TabIndex = 89;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(210, 185);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 49);
            this.button1.TabIndex = 96;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmDSBaoGiaCuaLead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2391, 1194);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.lbDSBaoGia);
            this.Controls.Add(this.txtHoTenLead);
            this.Name = "frmDSBaoGiaCuaLead";
            this.Text = "frmDSBaoGiaCuaLead";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDSBaoGiaCuaLead_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yêuCầuTưVấnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.Label lbDSBaoGia;
        private System.Windows.Forms.TextBox txtHoTenLead;
        private System.Windows.Forms.Button button1;
    }
}