using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebPortalMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Layout = "~/Views/Shared/Public/_LayoutPublic.cshtml";
            return View();
        }
    }
}
