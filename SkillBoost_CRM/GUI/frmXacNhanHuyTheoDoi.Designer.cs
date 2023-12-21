namespace GUI
{
    partial class frmXacNhanHuyTheoDoi
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
            this.btnHuyTheoDoi = new System.Windows.Forms.Button();
            this.txtLyDoHuyTheoDoi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHuyTheoDoi
            // 
            this.btnHuyTheoDoi.BackColor = System.Drawing.Color.Tomato;
            this.btnHuyTheoDoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyTheoDoi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHuyTheoDoi.Location = new System.Drawing.Point(305, 519);
            this.btnHuyTheoDoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuyTheoDoi.Name = "btnHuyTheoDoi";
            this.btnHuyTheoDoi.Size = new System.Drawing.Size(664, 90);
            this.btnHuyTheoDoi.TabIndex = 7;
            this.btnHuyTheoDoi.Text = "Hủy theo dõi";
            this.btnHuyTheoDoi.UseVisualStyleBackColor = false;
            this.btnHuyTheoDoi.Click += new System.EventHandler(this.btnHuyTheoDoi_Click);
            // 
            // txtLyDoHuyTheoDoi
            // 
            this.txtLyDoHuyTheoDoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLyDoHuyTheoDoi.Location = new System.Drawing.Point(138, 210);
            this.txtLyDoHuyTheoDoi.Margin = new System.Windows.Forms.Padding(2);
            this.txtLyDoHuyTheoDoi.Multiline = true;
            this.txtLyDoHuyTheoDoi.Name = "txtLyDoHuyTheoDoi";
            this.txtLyDoHuyTheoDoi.Size = new System.Drawing.Size(1058, 266);
            this.txtLyDoHuyTheoDoi.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 164);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lý do hủy theo dõi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(381, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(543, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "Xác nhận hủy theo dõi Lead";
            // 
            // frmXacNhanHuyTheoDoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 752);
            this.Controls.Add(this.btnHuyTheoDoi);
            this.Controls.Add(this.txtLyDoHuyTheoDoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmXacNhanHuyTheoDoi";
            this.Text = "frmXacNhanHuyTheoDoi";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmXacNhanHuyTheoDoi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHuyTheoDoi;
        private System.Windows.Forms.TextBox txtLyDoHuyTheoDoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}