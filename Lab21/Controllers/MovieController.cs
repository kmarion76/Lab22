using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab21.Models;
using Lab21.Repositories;

namespace Lab21.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieRepository _repository;
        public MovieController(IMovieRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            
            var movies = _repository.Get();
            return View(movies);
        }
        public IActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Registration(MovieViewModel model)
        {
            _repository.Save(model);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Create(MovieViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            _repository.Save(model);
            return RedirectToAction("Index");
        }
        public IActionResult SearchResultGenre(MovieSearchViewModel model)
        {
            var list = _repository.Get().Where(x => x.Genre == model.Genre);
            return View(list);

        }
        public IActionResult SearchResultTitle(MovieSearchViewModel model)
        {
            var list = _repository.Get().Where(x => x.Title.Contains(model.Title));
            return View(list);

        }
       


    }
}
