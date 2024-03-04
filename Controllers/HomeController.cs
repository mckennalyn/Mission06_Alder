using Microsoft.AspNetCore.Mvc;
using Mission06_Alder.Models;
using System.Diagnostics;

namespace Mission06_Alder.Controllers
{
    public class HomeController : Controller
    {
        private MovieFormContext _context;

        public HomeController(MovieFormContext temp)
        {
            _context = temp;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Movies()
        {
            return View("Movies", new Movie());
        }


        [HttpPost]
        public IActionResult Movies(Movie response)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(response);
                _context.SaveChanges();

                return View("Confirmation", response);
            }
            else
            {
                return View(response);
            }

        }

        public IActionResult GetToKnowJoel()
        {
            return View();
        }

        public IActionResult MovieList()
        {
            var movies = _context.Movies
                .OrderBy(x => x.Title).ToList();

            return View(movies);
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var recordToEdit = _context.Movies
                .Single(x => x.MovieId == Id);

            return View("Movies", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(Movie updatedInfo)
        {
            _context.Update(updatedInfo);
            _context.SaveChanges();

            return RedirectToAction("MovieList");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.Movies
                .Single(x => x.MovieId == id);

            return View(recordToDelete);
        }

        [HttpPost]
        public IActionResult Delete(Movie deletedInfo)
        {
            _context.Movies.Remove(deletedInfo);
            _context.SaveChanges();

            return RedirectToAction("MovieList");
        }
    }
}