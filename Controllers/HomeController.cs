﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using nctcdemoapp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace nctcdemoapp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmployee employee;
        public HomeController(ILogger<HomeController> logger,IEmployee _employee)
        {
            _logger = logger;
            employee = _employee;
        }

        public IActionResult Index()
        {
           var model= employee.GetEmployeeList();
            
            return View(model);
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
