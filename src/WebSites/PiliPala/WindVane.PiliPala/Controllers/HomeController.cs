using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WindVane.PiliPala.Application.Interfaces;
using WindVane.PiliPala.Models;

namespace WindVane.PiliPala.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMenuService _menuService;

        public HomeController(ILogger<HomeController> logger,
                                            IMenuService menuService)
        {
            _logger = logger;
            _menuService = menuService;
        }

        public IActionResult Index()
        {
            return View(_menuService.GetAll());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
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
