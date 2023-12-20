namespace GUI
{
    partial class frmTaoHoatDongLead
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
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnTao = new System.Windows.Forms.Button();
            this.cbLoaiHoatDong = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenHoatDongLead = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridDanhSachHoatDong = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDanhSachHoatDong)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(1881, 190);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(84, 29);
            this.btnHuy.TabIndex = 32;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnTao
            // 
            this.btnTao.Location = new System.Drawing.Point(1772, 190);
            this.btnTao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(84, 29);
            this.btnTao.TabIndex = 31;
            this.btnTao.Text = "Tạo";
            this.btnTao.UseVisualStyleBackColor = true;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // cbLoaiHoatDong
            // 
            this.cbLoaiHoatDong.FormattingEnabled = true;
            this.cbLoaiHoatDong.Location = new System.Drawing.Point(261, 191);
            this.cbLoaiHoatDong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbLoaiHoatDong.Name = "cbLoaiHoatDong";
            this.cbLoaiHoatDong.Size = new System.Drawing.Size(201, 28);
            this.cbLoaiHoatDong.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(258, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Loại hoạt động:";
            // 
            // txtTenHoatDongLead
            // 
            this.txtTenHoatDongLead.Location = new System.Drawing.Point(18, 191);
            this.txtTenHoatDongLead.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenHoatDongLead.Name = "txtTenHoatDongLead";
            this.txtTenHoatDongLead.Size = new System.Drawing.Size(201, 26);
            this.txtTenHoatDongLead.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Tên hoạt động:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 29);
            this.label1.TabIndex = 26;
            this.label1.Text = "Tạo mới hoạt động Lead";
            // 
            // dataGridDanhSachHoatDong
            // 
            this.dataGridDanhSachHoatDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDanhSachHoatDong.Location = new System.Drawing.Point(14, 241);
            this.dataGridDanhSachHoatDong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridDanhSachHoatDong.Name = "dataGridDanhSachHoatDong";
            this.dataGridDanhSachHoatDong.RowHeadersWidth = 51;
            this.dataGridDanhSachHoatDong.RowTemplate.Height = 24;
            this.dataGridDanhSachHoatDong.Size = new System.Drawing.Size(1962, 709);
            this.dataGridDanhSachHoatDong.TabIndex = 25;
            // 
            // frmTaoHoatDongLead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2006, 991);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.cbLoaiHoatDong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTenHoatDongLead);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridDanhSachHoatDong);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmTaoHoatDongLead";
            this.Text = "frmTaoHoatDongLead";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTaoHoatDongLead_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDanhSachHoatDong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.ComboBox cbLoaiHoatDong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenHoatDongLead;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridDanhSachHoatDong;
    }
}