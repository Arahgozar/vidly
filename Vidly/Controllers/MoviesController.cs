using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            Movie movie = new Movie();
            movie.Name = "Arash";
            ViewData["Movie"] = movie;
          //  ViewBag.Movie = movie;
            return View();
            
            //return View(movie);
            //return Content("Hello");
            //return HttpNotFound();
           // return new EmptyResult();
           // return RedirectToAction("Index", "Home", new { Page = 1, sortby = "name" });
        }
        public ActionResult Edit(int id) 
        {
            return Content("Id=" + id.ToString());
        }

        [Route("movies/released/chert/{year}/{month}")]
        public ActionResult Release(int year,int month) 
        {
            return Content(year+"/"+month);
        }

    }
}