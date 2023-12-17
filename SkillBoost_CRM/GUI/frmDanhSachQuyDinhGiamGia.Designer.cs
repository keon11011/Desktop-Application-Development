namespace GUI
{
    partial class frmDanhSachQuyDinhGiamGia
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
            this.lbDSachQuyDinhGiamGia = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnTaoQuyDinhGiamGia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDSachQuyDinhGiamGia
            // 
            this.lbDSachQuyDinhGiamGia.AutoSize = true;
            this.lbDSachQuyDinhGiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDSachQuyDinhGiamGia.Location = new System.Drawing.Point(12, 9);
            this.lbDSachQuyDinhGiamGia.Name = "lbDSachQuyDinhGiamGia";
            this.lbDSachQuyDinhGiamGia.Size = new System.Drawing.Size(346, 29);
            this.lbDSachQuyDinhGiamGia.TabIndex = 0;
            this.lbDSachQuyDinhGiamGia.Text = "Danh sách quy định giảm giá";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(960, 482);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnTaoQuyDinhGiamGia
            // 
            this.btnTaoQuyDinhGiamGia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTaoQuyDinhGiamGia.Location = new System.Drawing.Point(857, 16);
            this.btnTaoQuyDinhGiamGia.Name = "btnTaoQuyDinhGiamGia";
            this.btnTaoQuyDinhGiamGia.Size = new System.Drawing.Size(75, 23);
            this.btnTaoQuyDinhGiamGia.TabIndex = 2;
            this.btnTaoQuyDinhGiamGia.Text = "Tạo";
            this.btnTaoQuyDinhGiamGia.UseVisualStyleBackColor = true;
            this.btnTaoQuyDinhGiamGia.Click += new System.EventHandler(this.btnTaoQuyDinhGiamGia_Click);
            // 
            // frmDanhSachQuyDinhGiamGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 553);
            this.Controls.Add(this.btnTaoQuyDinhGiamGia);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbDSachQuyDinhGiamGia);
            this.Name = "frmDanhSachQuyDinhGiamGia";
            this.Text = "frmDanhSachQuyDinhGiamGia";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDSachQuyDinhGiamGia;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTaoQuyDinhGiamGia;
    }
}