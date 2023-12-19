namespace GUI
{
    partial class frmDanhSachKH
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
            this.btnThemKH = new System.Windows.Forms.Button();
            this.dtgvKhachHang = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLocKH = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTimKH
            // 
            this.txtTimKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKH.Location = new System.Drawing.Point(1180, 22);
            this.txtTimKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKH.Name = "txtTimKH";
            this.txtTimKH.Size = new System.Drawing.Size(545, 38);
            this.txtTimKH.TabIndex = 11;
            this.txtTimKH.TextChanged += new System.EventHandler(this.txtTimKH_TextChanged);
            // 
            // btnTimKH
            // 
            this.btnTimKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKH.Location = new System.Drawing.Point(1740, 17);
            this.btnTimKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKH.Name = "btnTimKH";
            this.btnTimKH.Size = new System.Drawing.Size(90, 44);
            this.btnTimKH.TabIndex = 10;
            this.btnTimKH.Text = "Tìm kiếm";
            this.btnTimKH.UseVisualStyleBackColor = true;
            this.btnTimKH.Click += new System.EventHandler(this.btnTimKH_Click);
            // 
            // btnThemKH
            // 
            this.btnThemKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemKH.Location = new System.Drawing.Point(2004, 18);
            this.btnThemKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(137, 43);
            this.btnThemKH.TabIndex = 9;
            this.btnThemKH.Text = "Thêm Khách hàng";
            this.btnThemKH.UseVisualStyleBackColor = true;
            // 
            // dtgvKhachHang
            // 
            this.dtgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvKhachHang.Location = new System.Drawing.Point(38, 78);
            this.dtgvKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvKhachHang.Name = "dtgvKhachHang";
            this.dtgvKhachHang.RowHeadersWidth = 62;
            this.dtgvKhachHang.RowTemplate.Height = 28;
            this.dtgvKhachHang.Size = new System.Drawing.Size(2103, 846);
            this.dtgvKhachHang.TabIndex = 8;
            this.dtgvKhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Danh sách Khách hàng";
            // 
            // btnLocKH
            // 
            this.btnLocKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocKH.Location = new System.Drawing.Point(1852, 18);
            this.btnLocKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLocKH.Name = "btnLocKH";
            this.btnLocKH.Size = new System.Drawing.Size(137, 43);
            this.btnLocKH.TabIndex = 12;
            this.btnLocKH.Text = "Lọc";
            this.btnLocKH.UseVisualStyleBackColor = true;
            // 
            // frmDanhSachKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1710, 844);
            this.Controls.Add(this.btnLocKH);
            this.Controls.Add(this.txtTimKH);
            this.Controls.Add(this.btnTimKH);
            this.Controls.Add(this.btnThemKH);
            this.Controls.Add(this.dtgvKhachHang);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDanhSachKH";
            this.Text = "frmDanhSachKH";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDanhSachKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTimKH;
        private System.Windows.Forms.Button btnTimKH;
        private System.Windows.Forms.Button btnThemKH;
        private System.Windows.Forms.DataGridView dtgvKhachHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLocKH;
    }
}