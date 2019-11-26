using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WindVane.PiliPala.Controllers
{
    public class VideoController : Controller
    {
        private readonly ILogger<VideoController> _logger;
        private readonly IWebHostEnvironment _env;
        public VideoController(ILogger<VideoController> logger, IWebHostEnvironment env)
        {
            _logger = logger;
            _env = env;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        [HttpGet]
        public IActionResult Upload()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Upload(IEnumerable<IFormFile> files)
        {
            List<string> videos = new List<string>();
            try
            {
                if (files != null && files.Count() > 0)
                {
                    string filePath = Path.Combine(_env.ContentRootPath, "wwwroot\\assets\\uploads\\videos");
                    foreach (var file in files)
                    {
                        string fileName = $"{DateTime.Now.ToString("yyyyMMddHHmmssfff")}{Path.GetExtension(file.FileName)}";
                        using (var fileStream = new FileStream(Path.Combine(filePath, fileName), FileMode.Create, FileAccess.Write))
                        {
                            file.CopyTo(fileStream);
                        }
                        videos.Add(fileName);
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            return Ok(videos);
        }

        [HttpGet]
        public IActionResult FormUpload() => View();
    }
}