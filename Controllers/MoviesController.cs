using exercise.Models;
using exercise.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace exercise.Controllers
{
    
    public class MoviesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Movies/list
        public ActionResult List()
        {
            var movies = db.Movies.Include("Genres").ToList();
            var header = new Headers() { Name = "Movies" };

            var viewModel = new MoviesViewModel
            {
                header = header,
                movies = movies,

            };
            return View(viewModel);
        }

        // GET: Movies/Detail/{id}
        public ActionResult Details(int id)
        {
            var movies = db.Movies.Find(id);
            if (movies == null)
            {
                return HttpNotFound();
            }
            var genre = db.Movies.Include("Genres").ToList();
            return View(movies);
        }
    }
}