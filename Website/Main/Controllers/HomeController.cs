﻿
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Main.Models;
using Microsoft.AspNetCore.Diagnostics;

namespace Main.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _config;

        public HomeController(ILogger<HomeController> logger, IConfiguration config)
        {
            _logger = logger;
            _config = config;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View();
        }
        //Uncomment to rickroll when a bad page is linked to
        /*
        [Route("/Home/Error/404")]
        public IActionResult Error404()
        {
            return Redirect("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
        }
        */
        public IActionResult Credits()
        {
            return View();
        }

    }

}