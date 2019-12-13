using System;
using System.Collections.Generic;
using System.Text;
using WindVane.PiliPala.Application.ViewModels;
using WindVane.PiliPala.Domain.Models;

namespace WindVane.PiliPala.Application.Interfaces
{
    public interface ICategoryService
    {
        IEnumerable<CategoryViewModel> Get();
        IEnumerable<CategoryViewModel> Get(CategoryViewModel category);
        CategoryViewModel GetById(Guid Id);

        void Created(CategoryViewModel category);
        void Updated(CategoryViewModel category);
        void Removed(Guid Id);
    }
}
