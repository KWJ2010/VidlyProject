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
        // GET: Movies/Random
        public ActionResult Random()
        {
            //ActionResult contains: ViewResult + View(), PartialViewResult + PartialView(), ContentResult + Content(),
            //RedirectResult + Redirect(), RedirectToRouteResult + RedirectToAction(), JsonResult + Json(), FileResult + File(), 
            //HttpNotFoundResult + HttpNotFound(), EmptyResult = void

            //If emptyResult...
            //return new EmptyResult();

            //ToDo: this model should come from a database full of Movie objects
            var movie = new Movie() { Name = "Shrek!" }; 

            return View(movie);
        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleasedByYear(int year, int month)
        {
            return Content(year + "/" + month);
        }


        //movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }
            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }
            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }
    }
}