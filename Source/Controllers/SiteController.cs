using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebPortalMVC.Controllers
{
    public class SiteController : Controller
    {
        //
        // GET: /Site/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Action1()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Action1(string id)
        {
            return View();
        }
    
    
    
    }
}
