using MovieBuff.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieBuff.ViewModels
{
    public class RandomMoviesViewModel
    {
        public Movies Movies { get; set; }
        public List<Customers> Customers { get; set; }

    }
}