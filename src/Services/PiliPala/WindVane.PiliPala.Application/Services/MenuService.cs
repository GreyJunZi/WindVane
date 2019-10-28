using AutoMapper;
using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using WindVane.PiliPala.Application.Interfaces;
using WindVane.PiliPala.Application.ViewModels;
using WindVane.PiliPala.Domain.Interfaces.Repositories;

namespace WindVane.PiliPala.Application.Services
{
    public class MenuService : IMenuService
    {
        private IMapper _mapper;
        private IMenuRepository _menuRepository;
        public MenuService(
            IMapper mapper,
            IMenuRepository menuRepository
        )
        {
            _mapper = mapper;
            _menuRepository = menuRepository;
        }
        public IEnumerable<MenuViewModel> GetAll()
        {
            return _menuRepository.Query()
                .OrderBy(order => order.DisplayOrder)
                .ProjectTo<MenuViewModel>(_mapper.ConfigurationProvider);
        }
        public MenuViewModel GetById(Guid Id)
        {
            return _mapper.Map<MenuViewModel>(_menuRepository.GetById(Id));
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {

            }
        }
    }
}
