using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
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
    }
}