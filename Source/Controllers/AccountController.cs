using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebPortalMVC.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult ListUsers()
        {
            return View();
        }

        public string CheckLogin(string Email,string Password)
        {
            Session["user_name"] = null;
            try
            {
                if (Email.ToLower() == "admin" && Password == "admin")
                {
                    Session["user_name"] = "admin";
                    return "true";
                }
                return "false";
            }
            catch (Exception)
            {
                Session["user_name"] = null;
                return "false";
            }
        }
        public string DoLogout(string Email, string Password)
        {
            Session["user_name"] = null;
            return "true";
        }
    }
}
