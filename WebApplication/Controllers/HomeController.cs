using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {

        private UserContext db = new UserContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Popular Flight Sectors: Kolkata to Delhi Flight |Hyderabad to Delhi Flight |Chennai to Hyderabad Flight |Delhi to Guwahati Flight |Lucknow to Delhi Flight |Nagpur to Mumbai Flight |Ranchi to Delhi Flight |Ahmedabad to Goa Flight |Mumbai to Chandigarh Flight |Pune to Kolkata Flight |Bangalore to Bhubaneshwar Flight |Bangalore to Guwahati Flight |Chennai to Goa Flight |Chennai to Kolkata Flight |Delhi to Jaipur Flight |Delhi to Leh Flight |Hyderabad to Goa Flight |Bangalore to Ranchi Flight |Delhi to Bagdogra Flight |Srinagar to Delhi Flight ";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login([Bind(Include = "UserID,UserName,UserPwd")] User user)
        {

            User u = db.user.FirstOrDefault(a => a.UserName == user.UserName && a.UserPwd == user.UserPwd);

            if (u != null)
                ViewBag.Message = "Login Success";
            else
                ViewBag.Message = "Login Fail";


            return View();
        }

        public ActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Register([Bind(Include = "UserID,UserName,UserPwd")] User user)
        {
            if (db.user.Where(a => a.UserName == user.UserName).Count() == 0)
            {
                db.user.Add(user);
                db.SaveChanges();
                ViewBag.Message = "Register Success";
            }
            else
                ViewBag.Message = "Register Fail";
            return View();
        }

    }
}