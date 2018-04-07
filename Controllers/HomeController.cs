using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Popularity.Domain;
using Popularity.Models;

namespace Popularity.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new MostPopularModel
            {
                Users = new List<User>
                {
                    new User 
                    { 
                        FirstName = "Chandler",
                        LastName = "Watson",
                        Email = "johnchandlerwatson@gmail.com"
                    },
                    new User 
                    { 
                        FirstName = "Austin",
                        LastName = "Whitesell",
                        Email = "austinwhitesell@gmail.com"
                    },
                    new User 
                    { 
                        FirstName = "Nate",
                        LastName = "Whitesell",
                        Email = "natewhitesell@gmail.com"
                    }
                }
            };
            return View("Index", model);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
