using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ZiggeoDemoApp.Models;

namespace ZiggeoDemoApp.Controllers
{
    public class HomeController : Controller
    {
        [ViewData]
        public Dictionary<string, Dictionary<string, string>> Routes { get; set; }

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        
        public IActionResult Index()
        {
            HomeViewModel ViewModel = new HomeViewModel();
            ViewModel.routes = new Dictionary<string, Dictionary<string, string>>() 
            {
                {
                    "Home",
                    new Dictionary<string, string>()
                    {
                        {"Home Page", "/home"},
                    }
                },
                {
                    "Profile",
                    new Dictionary<string, string>()
                    {
                        {"All Profiles", "/profile"},
                        {"Add A New Profile", "/profile/create"},
                    }
                },
                {
                    "Videos",
                    new Dictionary<string, string>()
                    {
                        {"All Videos", "/videos"},
                        {"Add A New Video", "/videos/create"},
                    }
                }
            };
            return View(ViewModel);
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
