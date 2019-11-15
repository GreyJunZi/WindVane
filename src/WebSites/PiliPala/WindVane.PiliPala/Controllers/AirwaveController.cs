using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WindVane.PiliPala.Controllers
{
    public class AirwaveController : Controller
    {
        [Route("Frequency/{frequencyName}")]
        public IActionResult Frequency(string frequencyName)
        {
            ViewData["FrequencyName"] = frequencyName;
            return View();
        }
    }
}