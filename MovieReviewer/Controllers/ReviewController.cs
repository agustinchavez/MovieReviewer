using MovieReviewer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieReviewer.Controllers
{
    public class ReviewController : Controller
    {
        [HttpGet]
        public ActionResult Create(string movieName)
        {
            ViewData["Movie"] = movieName;
            return View();
        }

        [HttpPost]
        public ActionResult Create(Review review, string movieName)
        {
            var movie = Movie.Read(movieName);
            movie.AddReviewToMovie(review);
            return RedirectToAction("Index", "Movie");
        }
    }
}