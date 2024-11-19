
using System;
using System.Windows.Forms;

namespace QuanLyLichHoc
{
    partial class ThongBao
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblRecipientEmail;
        private TextBox txtRecipientEmail;
        private Label lblSubject;
        private TextBox txtSubject;
        private Label lblMessage;
        private TextBox txtMessage;
        private Button btnSend;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblRecipientEmail = new Label();
            this.txtRecipientEmail = new TextBox();
            this.lblSubject = new Label();
            this.txtSubject = new TextBox();
            this.lblMessage = new Label();
            this.txtMessage = new TextBox();
            this.btnSend = new Button();
            this.SuspendLayout();

           
            this.lblRecipientEmail.AutoSize = true;
            this.lblRecipientEmail.Location = new System.Drawing.Point(30, 30);
            this.lblRecipientEmail.Name = "lblRecipientEmail";
            this.lblRecipientEmail.Size = new System.Drawing.Size(91, 15);
            this.lblRecipientEmail.TabIndex = 0;
            this.lblRecipientEmail.Text = "Người nhận:";

            
            this.txtRecipientEmail.Location = new System.Drawing.Point(150, 27);
            this.txtRecipientEmail.Name = "txtRecipientEmail";
            this.txtRecipientEmail.Size = new System.Drawing.Size(250, 23);
            this.txtRecipientEmail.TabIndex = 1;

            
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(30, 70);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(49, 15);
            this.lblSubject.TabIndex = 2;
            this.lblSubject.Text = "Môn:";

            
            this.txtSubject.Location = new System.Drawing.Point(150, 67);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(250, 23);
            this.txtSubject.TabIndex = 3;

            
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(30, 110);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(60, 15);
            this.lblMessage.TabIndex = 4;
            this.lblMessage.Text = "Nội Dung:";


            this.txtMessage.Location = new System.Drawing.Point(150, 107);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(250, 100);
            this.txtMessage.TabIndex = 5;

            
            this.btnSend.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(150, 220);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 30);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Gửi";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);

            
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 300);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.txtRecipientEmail);
            this.Controls.Add(this.lblRecipientEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ThongBao";
            this.Text = "Thong Bao";
            this.Load += new System.EventHandler(this.ThongBao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
