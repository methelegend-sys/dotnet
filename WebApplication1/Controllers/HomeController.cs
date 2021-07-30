using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Sum()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add()
        {
            int num1 = Convert.ToInt32(HttpContext.Request.Form["txtFirst"].ToString());
            int num2 = Convert.ToInt32(HttpContext.Request.Form["txtSecond"].ToString());
            int result = num1 - num2;
            ViewBag.SumResult = result.ToString();
            return View("Sum");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
