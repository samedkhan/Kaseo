using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kaseo.Controllers
{
    public class ServicesController : Controller
    {
        // GET: Services
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ServiceSingle()
        {
            return View();
        }
    }
}