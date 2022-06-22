using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EASendMail;

namespace Util
{
    public class SendEmailHelper
    {
        private static readonly string _from = "102200035@sv1.dut.udn.vn";
        private static readonly string _pass = "Daitoan2002.123";

        public bool SendEmail(string sendto, string subject, string body)
        {
            try
            {
                Task task = Task.Factory.StartNew(() =>
                {
                    SmtpMail mail = new SmtpMail("TryIt");
                    mail.From = _from;
                    mail.To = sendto;
                    mail.Subject = subject;
                    mail.HtmlBody = body;

                    SmtpServer server = new SmtpServer("smtp.office365.com");
                    server.Port = 587;
                    server.User = _from;
                    server.Password = _pass;
                    server.ConnectType = SmtpConnectType.ConnectSSLAuto;

                    SmtpClient smtp = new SmtpClient();
                    smtp.SendMail(server, mail);
                });
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
    }
}

