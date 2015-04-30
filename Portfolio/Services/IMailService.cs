using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfolio.Services
{
    public interface IMailService
    {
        string SendMail(string from, string to, string subject, string body);
    }
}