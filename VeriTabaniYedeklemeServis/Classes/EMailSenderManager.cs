using AsyenOtomatikYedekleme.Classes;
using System;
using System.Data;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace VeriTabaniYedeklemeServis.Classes
{
    internal class EMailSenderManager
    {
        internal async static Task MailSendService(string status)
        {
            DataTable dt = SQLLiteConnection.GetDataFromSQLite("SELECT EMail,RecipientEmail,Password,Server,Port,SSL FROM EMailSetting LIMIT 1");
            if (dt.Rows.Count == 0)
            {
                TextLog.TextLogging("Mail Bilgileri Girilmemiştir Mail Gönderilemedi", "Hatalı");
                return;
            }
            try
            {//todo buraya önem derecesi koy hatalı ise
                using (SmtpClient client = new SmtpClient(dt.Rows[0][3].ToString(), int.Parse(dt.Rows[0][4].ToString())))
                {
                    client.EnableSsl = dt.Rows[0][5].ToString() == "1" ? true : false;
                    client.Credentials = new NetworkCredential(dt.Rows[0][0].ToString(), EncryptionHelper.Decrypt(dt.Rows[0][2].ToString()));
                    MailMessage mail = new MailMessage
                    {
                        From = new MailAddress(dt.Rows[0][0].ToString()),
                        IsBodyHtml = true
                    };
                    if ("Başarılı" == status)
                    {
                        mail.Subject = "Yedekleme İşlemi Başarılı";
                        mail.Body = "Veritabanlarınız Başarılı Bir Şekilde Yedeklendi";
                        mail.Body = $@"
                <html>
                    <body style='font-family: Arial, sans-serif;'>
                        <h1 style='color: #4CAF50;'>Merhaba!</h1>
                        <p style='color: #333;'>
                           Veritabanlarınız Başarılı Bir Şekilde Yedeklendi
                        </p>
                        <footer style='margin-top: 20px;'>
                            <p style='color: #999;'>Bu bir otomatik e-posta'dır, lütfen yanıt vermeyin.</p>
                        </footer>
                    </body>
                </html>";
                    }
                    else
                    {
                        mail.Priority = MailPriority.High;
                        mail.Subject = "Yedekleme İşlemi Hatalı";
                        mail.Body = "Veritabanlarınız Hatalı Bir Şekilde Yedeklendi Lütfen Kontrol Ediniz";
                        mail.Body = $@"
                <html>
                    <body style='font-family: Arial, sans-serif;'>
                        <h1 style='color: #FF0000;'>Merhaba!</h1>
                        <p style='color: #333;'>
                       Veritabanlarınız Hatalı Bir Şekilde Yedeklendi Lütfen Kontrol Ediniz
                        </p>
                        <footer style='margin-top: 20px;'>
                            <p style='color: #999;'>Bu bir otomatik e-posta'dır, lütfen yanıt vermeyin.</p>
                        </footer>
                    </body>
                </html>";
                    }
                    mail.To.Add(dt.Rows[0][1].ToString());
                    await client.SendMailAsync(mail);
                }
            }
            catch (Exception ex)
            {
                TextLog.TextLogging(ex.ToString(), "Hatalı");
                return;
            }
        }
    }
}