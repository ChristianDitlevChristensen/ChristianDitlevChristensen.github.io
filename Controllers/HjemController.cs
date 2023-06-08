using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Vildmosemanden.Models;

namespace Vildmosemanden.Controllers
{
    public class HjemController : Controller
    {
        private readonly ILogger<HjemController> _logger;

        public HjemController(ILogger<HjemController> logger)
        {
            _logger = logger;
        }

        public IActionResult Vildmosemanden()
        {
            return View();
        }

        public IActionResult Sagnet()
        {
            return View();
        }

        public IActionResult Sang()
        {
            return View();
        }

        public IActionResult Skål()
        {
            return View();
        }

        public IActionResult HvadSigerVildmosemanden()
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