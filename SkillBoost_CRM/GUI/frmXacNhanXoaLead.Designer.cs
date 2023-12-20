namespace GUI
{
    partial class frmXacNhanXoaLead
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
            this.btnXoaLead = new System.Windows.Forms.Button();
            this.txtLyDoXoaLead = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnXoaLead
            // 
            this.btnXoaLead.BackColor = System.Drawing.Color.Tomato;
            this.btnXoaLead.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaLead.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXoaLead.Location = new System.Drawing.Point(318, 555);
            this.btnXoaLead.Name = "btnXoaLead";
            this.btnXoaLead.Size = new System.Drawing.Size(885, 113);
            this.btnXoaLead.TabIndex = 7;
            this.btnXoaLead.Text = "Xác nhận xóa";
            this.btnXoaLead.UseVisualStyleBackColor = false;
            this.btnXoaLead.Click += new System.EventHandler(this.btnXoaLead_Click);
            // 
            // txtLyDoXoaLead
            // 
            this.txtLyDoXoaLead.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLyDoXoaLead.Location = new System.Drawing.Point(95, 169);
            this.txtLyDoXoaLead.Multiline = true;
            this.txtLyDoXoaLead.Name = "txtLyDoXoaLead";
            this.txtLyDoXoaLead.Size = new System.Drawing.Size(1410, 331);
            this.txtLyDoXoaLead.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 46);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lý do xóa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(420, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(506, 63);
            this.label1.TabIndex = 4;
            this.label1.Text = "Xác nhận xóa Lead";
            // 
            // frmXacNhanXoaLead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1593, 700);
            this.Controls.Add(this.btnXoaLead);
            this.Controls.Add(this.txtLyDoXoaLead);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmXacNhanXoaLead";
            this.Text = "XacNhanXoaLead";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXoaLead;
        private System.Windows.Forms.TextBox txtLyDoXoaLead;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}