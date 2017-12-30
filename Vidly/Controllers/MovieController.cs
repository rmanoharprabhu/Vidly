using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult All()
        {
            var movie = new Movie() { Name = "Jaws", Description = "Famous Shark Movie" };
            return View(movie);
        }
    }
}