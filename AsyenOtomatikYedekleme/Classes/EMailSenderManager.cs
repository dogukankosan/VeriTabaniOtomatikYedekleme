using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyenOtomatikYedekleme.Classes
{
    internal class EMailSenderManager
    {
        internal async static Task MailSendForm(string senderEmail, string recipientEmail, string senderPassword, string server, int port, bool ssl)
        {
            string subject = "Asyen Yedekleme Programından Test E-posta Başlığı";
            string body = "Bu bir test e-posta içeriğidir.";
            try
            {
                using (SmtpClient client = new SmtpClient(server, port))
                {
                    client.EnableSsl = ssl;
                    client.Credentials = new NetworkCredential(senderEmail, senderPassword);
                    MailMessage mail = new MailMessage
                    {
                        From = new MailAddress(senderEmail),
                        Subject = subject,
                        Body = body
                    };
                    mail.To.Add(recipientEmail);
                    await client.SendMailAsync(mail);
                    XtraMessageBox.Show("E-Mail Başarıyla Gönderildi.", "Başarılı Mail Gönderme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("E-Mail gönderilirken bir hata oluştu: " + ex.Message, "Hatalı E-Posta Gönderimi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextLog.TextLogging(ex.ToString());
            }
        }
        internal async static Task MailSend()
        {
            DataTable dt = SQLLiteConnection.GetDataFromSQLite("SELECT EMail,RecipientEmail,Password,Server,Port,SSL FROM EMailSetting LIMIT 1");
            if (dt.Rows.Count == 0)
            {
                TextLog.TextLogging("Mail Bilgileri Girilmemiştir Mail Gönderilemedi");
                XtraMessageBox.Show("Mail Bilgileri Girilmemiştir Mail Gönderilemedi", "Hatalı Mail Gönderme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string subject = "Yedekleme İşlemi Başarılı";
            string body = "Veritabanlarınız Başarılı Bir Şekilde Yedeklendi";
            try
            {
                using (SmtpClient client = new SmtpClient(dt.Rows[0][3].ToString(), int.Parse(dt.Rows[0][4].ToString())))
                {
                    client.EnableSsl = dt.Rows[0][5].ToString() == "1" ? true : false;
                    client.Credentials = new NetworkCredential(dt.Rows[0][0].ToString(), EncryptionHelper.Decrypt(dt.Rows[0][2].ToString()));

                    MailMessage mail = new MailMessage
                    {
                        From = new MailAddress(dt.Rows[0][0].ToString()),
                        Subject = subject,
                        Body = $@"
                <html>
                    <body style='font-family: Arial, sans-serif;'>
                        <h1 style='color: #4CAF50;'>Merhaba!</h1>
                        <p style='color: #333;'>
                            {body}
                        </p>
                        <footer style='margin-top: 20px;'>
                            <p style='color: #999;'>Bu bir otomatik e-posta'dır, lütfen yanıt vermeyin.</p>
                        </footer>
                    </body>
                </html>",
                        IsBodyHtml = true
                    };
                    mail.To.Add(dt.Rows[0][1].ToString());
                    await client.SendMailAsync(mail);
                }
            }
            catch (Exception ex)
            {
                TextLog.TextLogging(ex.ToString());
                XtraMessageBox.Show("Mail Gönderme İşlemi Hatalı Mail Gönderilemedi","Hatalı Mail Gönderme",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}