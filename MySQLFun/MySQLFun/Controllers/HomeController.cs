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
      
        public HomeController()
        {

        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
