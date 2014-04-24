using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using prop360.web.Models;
using prop360.web.Services;

namespace prop360.web.Controllers
{
    public class HomeController : Controller
    {
        Prop360Db _db = new Prop360Db();

        //private IMailService _mail;

        //public HomeController(IMailService mail)
        //{
        //    _mail = mail;
        //}
        public ActionResult Index()
        {
            //var model = _db.Properties.ToList();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //[HttpPost]
        //public ActionResult Contact(ContactUsViewModel model)
        //{
        //    var msg = string.Format("Comment from: {1}{0}Email:{2}{0}Website: {3}{0}Comment:{4}",
        //        Environment.NewLine,
        //        model.Name,
        //        model.Email,
        //        model.Website,
        //        model.Comment);

        //    if (_mail.SendMail("noreply@yourdomain.com", "foo@yourdomain.com", "Website contact", msg))
        //    {
        //        ViewBag.MailSent = true;
        //    }
        //    return View();
        //}

        [Authorize]
        public ActionResult MyMessages()
        {
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}