﻿using App.Home.Data;
using MH_proj.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MH_proj.Controllers
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
            List<int> ints = new List<int>();
            List<int> int1 = new List<int>();
            List<int> int2 = new List<int>();
            List<int> int3 = new List<int>();
            List<int> int4 = new List<int>();
            List<int> int5 = new List<int>();
            List<int> int6 = new List<int>();
            List<int> int7 = new List<int>();
            List<int> int8 = new List<int>();
            List<int> int9 = new List<int>();
            List<int> int0 = new List<int>();
            List<int> int11 = new List<int>();
            List<int> int12 = new List<int>();
            List<int> int13 = new List<int>();
            List<int> int14 = new List<int>();
            List<int> int15 = new List<int>();
            List<int> int16 = new List<int>();
            List<int> int17 = new List<int>();


            return View();
        }

        public IActionResult Privacy()
        {
            List<int> ints = new List<int>();
            List<int> int1 = new List<int>();
            List<int> int2 = new List<int>();
            List<int> int3 = new List<int>();
            List<int> int4 = new List<int>();
            List<int> int5 = new List<int>();
            List<int> int6 = new List<int>();
            List<int> int7 = new List<int>();
            List<int> int8 = new List<int>();
            List<int> int9 = new List<int>();
            List<int> int0 = new List<int>();
            List<int> int11 = new List<int>();
            List<int> int12 = new List<int>();
            List<int> int13 = new List<int>();
            List<int> int14 = new List<int>();
            List<int> int15 = new List<int>();
            List<int> int16 = new List<int>();
            Console.WriteLine("Demo text");
            Console.WriteLine("Demo text");
            Console.WriteLine("Demo text");
            Console.WriteLine("Demo text");


            return Ok();
        }

        public IActionResult Privacy1()
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
