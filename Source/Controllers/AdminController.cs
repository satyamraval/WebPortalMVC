using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebPortalMVC.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Layout = "~/Views/Shared/Admin/_LayoutAdmin.cshtml"; 
            return View();
        }
    }
}
