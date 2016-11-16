using System.Web.Mvc;
using MovieReviewer.Models;

namespace MovieReviewer.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {
            return View(Movie.ReadAll());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            Movie.Create(movie);
            return RedirectToAction("Index");
        }

    }
}