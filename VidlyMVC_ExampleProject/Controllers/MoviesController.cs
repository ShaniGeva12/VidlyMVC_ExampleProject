using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyMVC_ExampleProject.Models;
using VidlyMVC_ExampleProject.ViewModels;

namespace VidlyMVC_ExampleProject.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies

        public ActionResult MoviesList()
        {
            var movies = new List<Movie>
            {
                new Movie {Name = "Shrek!" , Id = 1},
                new Movie {Name = "Shrek 2!" , Id = 2},
                new Movie {Name = "Shrek 3!" , Id = 3}
            };

            var viewModel_movies_list = new MoviesViewModel
            {
                Movies = movies
            };

            return View(viewModel_movies_list);
        }

        public ActionResult Random()
        {
            var movie = new Movie(){Name = "Shrek!"};

            var movies = new List<Movie>
            {
                new Movie {Name = "Shrek!" , Id = 1},
                new Movie {Name = "Shrek 2!" , Id = 2},
                new Movie {Name = "Shrek 3!" , Id = 3}
            };

            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}
            };


            var viewModel_movies = new MoviesViewModel
            {
                Movies = movies,
                Customers = customers
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };


            //more ways to move data to the view
            //ViewData["Movie"] = movie;
            //ViewBag.Movie = movie;

            /* how the data get transferred using the regular way
            var viewResult = new ViewResult();
            viewResult.ViewData.Model = movie;
            */



           return View(viewModel);
           // return View(viewModel_movies);
            
           // return HttpNotFound();
        }
    }
}