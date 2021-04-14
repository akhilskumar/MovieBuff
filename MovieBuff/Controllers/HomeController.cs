using MovieBuff.Models;
using MovieBuff.ViewModels;
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
            var movies = new Movies {MovieName="Sherk" };
            var customers = new List<Customers>
            {
                new Customers{CustomerName="Akhil" },
                new Customers{CustomerName="Achu"}
            };

            var viewModel = new RandomMoviesViewModel
            {
                Movies = movies,
                 Customers = customers
            };
              
            
            return View(viewModel);
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
        [Route("Home/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleasedDate(int year,int month)
        {
            return Content(year + "/ " + month);
        }
    }
}