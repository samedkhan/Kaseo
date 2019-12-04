using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kaseo.Controllers
{
    public class ProjectsController : Controller
    {
        // GET: Projects
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ProjectSingle()
        {
            return View();
        }
    }
}