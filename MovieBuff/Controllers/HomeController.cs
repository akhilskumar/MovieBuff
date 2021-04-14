using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieBuff.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Movie()
        {

            return View();
        }
    }
}