using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace Portfolio.Services
{
    public class MailService : IMailService
    {
        public string SendMail(string from, string to, string subject, string body)
        {
            var errorMessage = "";
            try
            {
                var msg = new MailMessage(from, to, subject, body);
                using (var smtp = new SmtpClient())
                {
                    var credential = new NetworkCredential
                    {
                        // Make sure to enter a valid email
                        UserName = "youremail@gmail.com",
                        // And a valid password
                        Password = "YourPassword"
                    };
                    smtp.Credentials = credential;
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    smtp.Send(msg);
                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return errorMessage;
        }
    }
}