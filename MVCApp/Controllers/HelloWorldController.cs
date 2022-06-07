using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCApp.Controllers
{
    public class HelloWorldController : Controller
    {

        private static List<DogViewModel> dogs = new List<DogViewModel>();

        public IActionResult Index()
        {
            // Pass the list with dogs models
            return View(dogs);
        }

        public IActionResult Create()
        {
            var dogVm = new DogViewModel();
            return View(dogVm);
        }

        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
            // return View("Index");
            // RedirectToAction helps to call or redirect to the specified View
            dogs.Add(dogViewModel);
            return RedirectToAction(nameof(Index));
        }

        public string Hello()
        {
            return "Who's there?";
        }
    }
}

