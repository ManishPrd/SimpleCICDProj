using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SimpleCICDProj.Models;

namespace SimpleCICDProj.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            string build = string.Empty;
            bool blnPipline  = false;

            //build = "Sucess";
            //if (build == "Sucess")
            //    blnPipline = true;
            //else
            //    blnPipline = false;

            if (blnPipline)
                ViewBag.Work = "CI / CD Complete and Deployed";
            else
                ViewBag.Work = "CI / CD to be Configured ";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
