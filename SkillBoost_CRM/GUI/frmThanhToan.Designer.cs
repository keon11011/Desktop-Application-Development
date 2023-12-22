namespace GUI
{
    partial class frmThanhToan
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
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTennguoithuhuong = new System.Windows.Forms.TextBox();
            this.txtSotaikhoan = new System.Windows.Forms.TextBox();
            this.txtChinhanh = new System.Windows.Forms.TextBox();
            this.txtNoidungchuyenkhoan = new System.Windows.Forms.TextBox();
            this.txtMagiamgia = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_QR = new System.Windows.Forms.Label();
            this.txtMadonhang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Location = new System.Drawing.Point(494, 473);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(240, 57);
            this.btnThanhToan.TabIndex = 57;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(919, 154);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(91, 68);
            this.btnTim.TabIndex = 56;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTongtien
            // 
            this.txtTongtien.Location = new System.Drawing.Point(338, 381);
            this.txtTongtien.Multiline = true;
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.Size = new System.Drawing.Size(547, 55);
            this.txtTongtien.TabIndex = 55;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(334, 264);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 20);
            this.label11.TabIndex = 54;
            this.label11.Text = "Chi nhánh";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(653, 264);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 20);
            this.label10.TabIndex = 53;
            this.label10.Text = "Nội dung chuyển khoản";
            // 
            // txtTennguoithuhuong
            // 
            this.txtTennguoithuhuong.Location = new System.Drawing.Point(338, 222);
            this.txtTennguoithuhuong.Name = "txtTennguoithuhuong";
            this.txtTennguoithuhuong.Size = new System.Drawing.Size(228, 26);
            this.txtTennguoithuhuong.TabIndex = 52;
            // 
            // txtSotaikhoan
            // 
            this.txtSotaikhoan.Location = new System.Drawing.Point(657, 222);
            this.txtSotaikhoan.Name = "txtSotaikhoan";
            this.txtSotaikhoan.Size = new System.Drawing.Size(228, 26);
            this.txtSotaikhoan.TabIndex = 51;
            // 
            // txtChinhanh
            // 
            this.txtChinhanh.Location = new System.Drawing.Point(338, 287);
            this.txtChinhanh.Name = "txtChinhanh";
            this.txtChinhanh.Size = new System.Drawing.Size(228, 26);
            this.txtChinhanh.TabIndex = 50;
            // 
            // txtNoidungchuyenkhoan
            // 
            this.txtNoidungchuyenkhoan.Location = new System.Drawing.Point(657, 287);
            this.txtNoidungchuyenkhoan.Name = "txtNoidungchuyenkhoan";
            this.txtNoidungchuyenkhoan.Size = new System.Drawing.Size(228, 26);
            this.txtNoidungchuyenkhoan.TabIndex = 49;
            // 
            // txtMagiamgia
            // 
            this.txtMagiamgia.Location = new System.Drawing.Point(657, 153);
            this.txtMagiamgia.Name = "txtMagiamgia";
            this.txtMagiamgia.Size = new System.Drawing.Size(228, 26);
            this.txtMagiamgia.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(653, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 20);
            this.label9.TabIndex = 47;
            this.label9.Text = "Mã giảm giá (nếu có)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(334, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 20);
            this.label8.TabIndex = 46;
            this.label8.Text = "Tên người thụ hưởng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(653, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 45;
            this.label7.Text = "Số tài khoản";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(334, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 44;
            this.label6.Text = "Tổng tiền:";
            // 
            // lb_QR
            // 
            this.lb_QR.AutoSize = true;
            this.lb_QR.Location = new System.Drawing.Point(72, 130);
            this.lb_QR.Name = "lb_QR";
            this.lb_QR.Size = new System.Drawing.Size(201, 20);
            this.lb_QR.TabIndex = 42;
            this.lb_QR.Text = "Quét mã QR để thanh toán";
            this.lb_QR.Visible = false;
            // 
            // txtMadonhang
            // 
            this.txtMadonhang.Location = new System.Drawing.Point(338, 154);
            this.txtMadonhang.Name = "txtMadonhang";
            this.txtMadonhang.Size = new System.Drawing.Size(228, 26);
            this.txtMadonhang.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "Mã đơn hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(551, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 22);
            this.label1.TabIndex = 39;
            this.label1.Text = "Thanh toán";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources._409435812_1108269803880950_1323162967013208065_n;
            this.pictureBox1.Location = new System.Drawing.Point(86, 168);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // frmThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 645);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTongtien);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTennguoithuhuong);
            this.Controls.Add(this.txtSotaikhoan);
            this.Controls.Add(this.txtChinhanh);
            this.Controls.Add(this.txtNoidungchuyenkhoan);
            this.Controls.Add(this.txtMagiamgia);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lb_QR);
            this.Controls.Add(this.txtMadonhang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmThanhToan";
            this.Text = "Thanh toán";
            this.Load += new System.EventHandler(this.frmThanhToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTennguoithuhuong;
        private System.Windows.Forms.TextBox txtSotaikhoan;
        private System.Windows.Forms.TextBox txtChinhanh;
        private System.Windows.Forms.TextBox txtNoidungchuyenkhoan;
        private System.Windows.Forms.TextBox txtMagiamgia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_QR;
        private System.Windows.Forms.TextBox txtMadonhang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}