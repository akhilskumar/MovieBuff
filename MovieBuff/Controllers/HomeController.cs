using MovieBuff.Models;
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
            Movies movies = new Movies {MovieName="Sherk" };
              
            
            return View(movies);
        }

        public ActionResult Edit(string id)
        {
            return Content("id="+id);
        }

        public ActionResult Index(int? pageIndex, string sortby)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }
            if (string.IsNullOrWhiteSpace(sortby))
            {
                sortby = "Name";
            }
            return Content(string.Format("Page Index={0} & sortBy={1}", pageIndex, sortby));
        }

        public ActionResult ByReleasedDate(int year,int month)
        {
            return Content(year + "/ " + month);
        }
    }
}