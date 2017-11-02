using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using Microsoft.AspNetCore.Http;
using System.Runtime.Serialization.Formatters.Binary;
using Ex1;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(HttpContext.Session.Get<Ex1.Models.Person>("Person"));
        }

        [HttpGet]
        public IActionResult Store()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Store(Ex1.Models.Person person)
        {
            HttpContext.Session.Set("Person", person);
            return View();
        }
    }
}
