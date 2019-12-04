using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kaseo.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LeftSideBar()
        {
            return View();
        }

        public ActionResult BlogFullWidth()
        {
            return View();
        }

        public ActionResult BlogDetails()
        {
            return View();
        }

        public ActionResult BlogDetailsFullWidth()
        {
            return View();
        }
    }
}