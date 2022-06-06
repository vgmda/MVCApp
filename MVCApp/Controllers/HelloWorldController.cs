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
        // GET: /<controller>/
        public IActionResult Index()
        {
            DogViewModel doggo = new DogViewModel() { Name = "Boy", Age = 2 };
            return View(doggo);
        }

        public IActionResult Create()
        {
            return View();
        }

        public string Hello()
        {
            return "Who's there?";
        }
    }
}

