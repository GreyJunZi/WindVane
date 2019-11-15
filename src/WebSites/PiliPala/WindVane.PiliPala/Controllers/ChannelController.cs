using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WindVane.PiliPala.Controllers
{
    public class ChannelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 动画
        /// </summary>
        /// <returns></returns>
        public IActionResult Anime()
        {
            return View();
        }

        /// <summary>
        /// 电影
        /// </summary>
        /// <returns></returns>
        public IActionResult Film()
        {
            return View();
        }

        /// <summary>
        /// 电视剧
        /// </summary>
        /// <returns></returns>
        public IActionResult TV()
        {
            return View();
        }

        /// <summary>
        /// 纪录片
        /// </summary>
        /// <returns></returns>
        public IActionResult Documentary()
        {
            return View();
        }

        /// <summary>
        /// 体育
        /// </summary>
        /// <returns></returns>
        public IActionResult PhysicalEducation()
        {
            return View();
        }

        /// <summary>
        /// 军事
        /// </summary>
        /// <returns></returns>
        public IActionResult Military()
        {
            return View();
        }

        /// <summary>
        /// 历史
        /// </summary>
        /// <returns></returns>
        public IActionResult History()
        {
            return View();
        }

        /// <summary>
        /// 科技
        /// </summary>
        /// <returns></returns>
        public IActionResult Technology()
        {
            return View();
        }

        /// <summary>
        /// 编程
        /// </summary>
        /// <returns></returns>
        public IActionResult Program()
        {
            return View();
        }

        /// <summary>
        /// 游戏
        /// </summary>
        /// <returns></returns>
        public IActionResult Game()
        {
            return View();
        }

        /// <summary>
        /// 原创
        /// </summary>
        /// <returns></returns>
        public IActionResult Original()
        {
            return View();
        }

        /// <summary>
        /// 教育
        /// </summary>
        /// <returns></returns>
        public IActionResult Education()
        {
            return View();
        }
    }
}