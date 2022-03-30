﻿using System;
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
        private int code;
        public bool SendCodeToEmail(string sendto, string subject)
        {
            //sendto: Email receiver (người nhận)
            //subject: Tiêu đề email
            //content: Nội dung của email, bạn có thể viết mã HTML
            //Nếu gửi email thành công, sẽ trả về kết quả: true, ngược lại trả về false
            try
            {
                code = Convert.ToInt32(new Random().Next(100000, 999999));
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress(_from);
                mail.To.Add(sendto);
                mail.Subject = subject;
                mail.IsBodyHtml = true;
                mail.Body = "<h3>Please do not share the code to ensure safety and security.</h3> <h1> Your code: " + code.ToString() + "</h1>";

                mail.Priority = MailPriority.High;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(_from, _pass);
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public int GetCode()
        {
            return code;
        }
    }
}