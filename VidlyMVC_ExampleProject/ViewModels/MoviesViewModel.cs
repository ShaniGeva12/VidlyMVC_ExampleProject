using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyMVC_ExampleProject.Models;

namespace VidlyMVC_ExampleProject.ViewModels
{
    public class MoviesViewModel
    {
        public List<Movie> Movies { get; set; }
        public List<Customer> Customers { get; set; }
    }
}