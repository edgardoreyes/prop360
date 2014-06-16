using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prop360.web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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


        public ActionResult HAdministrator()
        {
          ViewBag.Message = "Message from HomeController-HAdministrator";
          ViewBag.Title = "Title from HomeController - HAdministrator";

          return View();
        }

        public ActionResult HBuyer()
        {
          return View();
        }

        public ActionResult HConsultant()
        {
          return View();
        }

        public ActionResult HOwner()
        {
          return View();
        }

        public ActionResult HProfessional1()
        {
          return View();
        }

        public ActionResult HProfessional2()
        {
          return View();
        }

    }
}