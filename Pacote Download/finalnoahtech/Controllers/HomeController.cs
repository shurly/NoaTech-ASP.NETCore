using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MimeKit;
using Noahtech.Models;
using NoahTech.Models;

namespace Noahtech.Controllers
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
            return View();
        }


        public IActionResult Novidade()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }


        public IActionResult Profissoes()
        {
            return View();
        }

        public IActionResult Form()
        {
            return View();
        }

        public IActionResult Inspiracao()
        {
            return View();
        }

        public IActionResult Eventos()
        {
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


