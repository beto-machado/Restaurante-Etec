using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestauranteEtec.Models;

namespace RestauranteEtec.Controllers
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

        public IActionResult QuemSOmos()
        {
            return View();
        }

        public IActionResult Chefes()
        {
            return View();
        }

        public IActionResult Menu()
        {
            return View();
        }

        public IActionResult Reservas()
        {
            return View();
        }

        public IActionResult Blog()
        {
            return View();
        }

        public IActionResult Contatos()
        {
            return View();
        }
    }
}
