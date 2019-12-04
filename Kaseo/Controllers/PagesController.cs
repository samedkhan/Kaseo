using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kaseo.Controllers
{
    public class PagesController : Controller
    {
        // GET: About
        public ActionResult About()
        {
            return View();
        }

        public ActionResult PricingTable()
        {
            return View();
        }

        public ActionResult Testimonial()
        {
            return View();
        }
    }
}