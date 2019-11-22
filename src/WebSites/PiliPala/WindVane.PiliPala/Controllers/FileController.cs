using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WindVane.PiliPala.Controllers
{
    public class FileController : Controller
    {
        private readonly IWebHostEnvironment _env;
        public FileController(IWebHostEnvironment env)
        {
            _env = env;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SingleFileUpload(IFormFile file)
        {
            string path = $"{_env.ContentRootPath}/wwwroot/uploads/videos/";
            string fileName = $"";
            using (var fileStream = new FileStream(Path.Combine(path, fileName), FileMode.Create, FileAccess.Write))
            {
                file.CopyTo(fileStream);
            }
            return RedirectToAction("/Home/Index");
        }

        public IActionResult MultipleFileUpload(IEnumerable<IFormFile> files)
        {
            string path = $"{_env.ContentRootPath}/wwwroot/uploads/videos/";
            foreach (var file in files)
            {
                string fileName = $"{DateTime.Now.ToString("yyyyMMddHHmmssSSS")}{Path.GetExtension(file.FileName)}";
                using (var fileStream = new FileStream(Path.Combine(path, fileName), FileMode.Create, FileAccess.Write))
                {
                    file.CopyTo(fileStream);
                }
            }
            return RedirectToAction("/Home/Index");
        }

        public IActionResult Upload(IFormFile file)
        {
            return Ok();
        }

        public IActionResult Download()
        {
            return Ok();
        }
    }
}