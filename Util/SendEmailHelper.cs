using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public class SendEmailHelper
    {
        private static readonly string _from = "daitoan2000@gmail.com";
        private static readonly string _pass = "daitoan2002.123";
 
        SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

        public bool SendEmail(string sendto, string subject, string body)
        {

            try
            {
                Task task = Task.Factory.StartNew(() =>
                {
                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress(_from);
                    mail.To.Add(sendto);
                    mail.Subject = subject;
                    mail.IsBodyHtml = true;
                    mail.Body = body;

                    mail.Priority = MailPriority.High;

                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential(_from, _pass);
                    SmtpServer.EnableSsl = true;
                    SmtpServer.Send(mail);
                });
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

    }
}
// "<h3>Please do not share the code to ensure safety and security.</h3> <h1> Your code: " + code.ToString() + "</h1>";
//"Your account to access the DanaTravel application";