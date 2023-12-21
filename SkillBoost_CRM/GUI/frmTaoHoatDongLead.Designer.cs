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
            this.lb_LeadName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(469, 402);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(140, 50);
            this.btnHuy.TabIndex = 32;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnTao
            // 
            this.btnTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTao.Location = new System.Drawing.Point(653, 402);
            this.btnTao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(140, 50);
            this.btnTao.TabIndex = 31;
            this.btnTao.Text = "Tạo";
            this.btnTao.UseVisualStyleBackColor = true;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // cbLoaiHoatDong
            // 
            this.cbLoaiHoatDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiHoatDong.FormattingEnabled = true;
            this.cbLoaiHoatDong.Location = new System.Drawing.Point(157, 220);
            this.cbLoaiHoatDong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbLoaiHoatDong.Name = "cbLoaiHoatDong";
            this.cbLoaiHoatDong.Size = new System.Drawing.Size(636, 37);
            this.cbLoaiHoatDong.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(154, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 29);
            this.label4.TabIndex = 29;
            this.label4.Text = "Loại hoạt động:";
            // 
            // txtTenHoatDongLead
            // 
            this.txtTenHoatDongLead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenHoatDongLead.Location = new System.Drawing.Point(157, 328);
            this.txtTenHoatDongLead.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenHoatDongLead.Multiline = true;
            this.txtTenHoatDongLead.Name = "txtTenHoatDongLead";
            this.txtTenHoatDongLead.Size = new System.Drawing.Size(636, 42);
            this.txtTenHoatDongLead.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(154, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 29);
            this.label3.TabIndex = 27;
            this.label3.Text = "Tên hoạt động:";
            // 
            // lb_LeadName
            // 
            this.lb_LeadName.AutoSize = true;
            this.lb_LeadName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LeadName.Location = new System.Drawing.Point(152, 46);
            this.lb_LeadName.Name = "lb_LeadName";
            this.lb_LeadName.Size = new System.Drawing.Size(265, 37);
            this.lb_LeadName.TabIndex = 94;
            this.lb_LeadName.Text = "Phan Duy Trọng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 32);
            this.label2.TabIndex = 92;
            this.label2.Text = "Thêm hoạt động Lead";
            // 
            // frmTaoHoatDongLead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 550);
            this.Controls.Add(this.lb_LeadName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.cbLoaiHoatDong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTenHoatDongLead);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmTaoHoatDongLead";
            this.Text = "frmTaoHoatDongLead";
            this.Load += new System.EventHandler(this.frmTaoHoatDongLead_Load);
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
        private System.Windows.Forms.Label lb_LeadName;
        private System.Windows.Forms.Label label2;
    }
}