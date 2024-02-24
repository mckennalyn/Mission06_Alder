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
        public IActionResult form()
        {
            return View("form");
        }


        [HttpPost]
        public IActionResult form(Form response)
        {
            response.MovieLent = response.MovieLent ?? "";
            response.MovieNotes = response.MovieNotes ?? "";

            _context.Forms.Add(response); 
            _context.SaveChanges();

            return View("Confirmation");
        }

        public IActionResult GetToKnowJoel()
        {
            return View();
        }

    }
}