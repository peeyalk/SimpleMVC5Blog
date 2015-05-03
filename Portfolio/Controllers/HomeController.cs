using Portfolio.Models;
using Portfolio.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {

        private IMailService _mailService;

        public HomeController(IMailService mailService)
        {
            _mailService = mailService;
        }

        /// <summary>
        /// Home page
        /// </summary>
        /// <returns>index view</returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Contact page
        /// </summary>
        /// <returns>Contact view</returns>
        [HttpGet]
        public ActionResult Contact()
        {
            return View();
        }

        /// <summary>
        /// Get information from contact forms
        /// and send email using mail service.
        /// </summary>
        /// <param name="model">contact view model</param>
        /// <returns>return to contact view</returns>
        [HttpPost]
        public ActionResult Contact(ContactViewModels model)
        {
            var msg = String.Format("Contact from: {1}{0}Email: {2}{0}Comment: {3}",
                Environment.NewLine,
                model.Name,
                model.Email,
                model.Message
            );

            if (_mailService.SendMail(model.Email, "yourdomain@foo.com", "Contact from website", msg).Equals(""))
            {
                TempData["message"] = "Thanks for contacting me.";
            }
            else
            {
                TempData["message"] = "Oops! Something went wrong, please try again.";
            }

            return View();
        }
    }
}