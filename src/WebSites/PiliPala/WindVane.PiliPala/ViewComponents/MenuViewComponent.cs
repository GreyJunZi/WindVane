using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WindVane.PiliPala.Application.Interfaces;

namespace WindVane.PiliPala.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        private readonly IMenuService _menuService;

        public MenuViewComponent(IMenuService menuService)
        {
            _menuService = menuService;
        }

        public IViewComponentResult Invoke()
        {
            return View(_menuService.GetAll());
        }
    }
}
