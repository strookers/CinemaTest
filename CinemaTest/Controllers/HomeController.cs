using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CinemaTest.Entity;
using CinemaTest.Models;
using TMDbLib.Client;

namespace CinemaTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About(DateTime dt)
        {
            List<Movie> mList = new List<Movie>();

            ViewData["dt"] = dt.ToString("yyyy-MM-dd");
            using (EntityContext db = new EntityContext())
            {
                DateTime date = DateTime.ParseExact("2016-12-06 15:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
                mList = db.Movies
                    .Where(x => x.Shows.Any(y => DbFunctions.CreateDateTime(y.DateTime.Year, y.DateTime.Month, y.DateTime.Day, 0, 0, 0) == DbFunctions.CreateDateTime(dt.Year, dt.Month, dt.Day, 0, 0, 0)))
                    .Include(s => s.Shows).ToList();
            }
            return View(mList);
        }

        public ActionResult Contact()
        {
            TMDbClient client = new TMDbClient("07219312fb0d0a753e0d2546be497010");

            TMDbLib.Objects.Movies.Movie movie = client.GetMovie(209112);
            ViewBag.Message = "Your contact page.";
            ViewData["Test1"] = DateTime.ParseExact("2016-12-06 15:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
            return View(movie);
        }
    }
}