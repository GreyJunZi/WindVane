using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WindVane.PiliPala.Application.ViewModels;

namespace WindVane.PiliPala.Application.Interfaces
{
    public interface IMenuService : IDisposable
    {
        IEnumerable<MenuViewModel> GetAll();
        MenuViewModel GetById(Guid Id);
        IEnumerable<MenuViewModel> GetMenus();
    }
}
