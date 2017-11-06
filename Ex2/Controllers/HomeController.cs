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
using Ex1.Models;
using Newtonsoft.Json;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index([FromServices] PersonService ps)
        {
            return View(ps.GetPersons());
        }

        [HttpGet]
        public IActionResult Store()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Store(Person person, [FromServices] PersonService ps)
        {
            if (ModelState.IsValid) { 
                ps.AddPerson(person);
                return View();
            }
            return View();
        }

        [HttpPost]
        public IActionResult StoreJSON([FromBody]Person person, [FromServices] PersonService ps)
        {
            if (person != null)
            {
                ps.AddPerson(person);
                return View();
            }
            //Request
            /*
            POST http://localhost:6689/Home/StoreJSON HTTP/1.1
User-Agent: Fiddler
Host: localhost:6689
Content-Length: 72
Content-Type: application/json; charset=utf-8

{"Name":"poi","Birthday":"2017-10-31","Email":"poi@poi","Phone":1234567}
            */
            return View();
        }
    }
}
