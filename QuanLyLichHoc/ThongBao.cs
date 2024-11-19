// ThongBao.cs
using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace QuanLyLichHoc
{
    public partial class ThongBao : Form
    {
        private string currentUserRole;

        public ThongBao(string userRole)
        {
            InitializeComponent();
            currentUserRole = userRole;
        }

        private void ThongBao_Load(object sender, EventArgs e)
        {
           
            if (currentUserRole != "Teacher")
            {
                MessageBox.Show("Bạn không được thông báo.");
                this.Close(); 
            }
        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lblRecipientEmail_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (currentUserRole != "Teacher")
            {
                MessageBox.Show("Chỉ giáo viên có quyền gửi thông báo.");
                return; 
            }

            
            string recipientEmail = txtRecipientEmail.Text;
            string subject = txtSubject.Text;
            string message = txtMessage.Text;

            
            string smtpServer = "smtp.gmail.com";
            int smtpPort = 587; 
            string senderEmail = "vanthien03022004@gmail.com";  
            string senderPassword = "krio aaxp sevx molc";  

            try
            {
                
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(senderEmail);
                mail.To.Add(recipientEmail);
                mail.Subject = subject;
                mail.Body = message;

                
                SmtpClient smtp = new SmtpClient(smtpServer, smtpPort)
                {
                    EnableSsl = true,  
                    Credentials = new NetworkCredential(senderEmail, senderPassword)  
                };

                
                smtp.Send(mail);
                MessageBox.Show("Gửi thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
