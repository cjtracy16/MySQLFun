using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MySQLFun.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MySQLFun.Controllers
{
    public class HomeController : Controller
    {
        private IRecipesRepository repo { get; set; }
      
        public HomeController(IRecipesRepository temp)
        {
            repo = temp;
        }

        public IActionResult Index()
        {
            var x = repo.Recipes
                .ToList();
            
            return View(x);
        }
    }
}
