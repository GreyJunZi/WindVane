using AutoMapper;
using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindVane.PiliPala.Application.Interfaces;
using WindVane.PiliPala.Application.ViewModels;
using WindVane.PiliPala.Domain.Interfaces.Repositories;
using WindVane.PiliPala.Domain.Models;

namespace WindVane.PiliPala.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IMapper _mapper;
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(IMapper mapper, ICategoryRepository categoryRepository)
        {
            _mapper = mapper;
            _categoryRepository = categoryRepository;
        }

        public IEnumerable<CategoryViewModel> Get()
        {
            return _categoryRepository.GetAll().AsQueryable().ProjectTo<CategoryViewModel>(_mapper.ConfigurationProvider);
        }
        public IEnumerable<CategoryViewModel> Get(CategoryViewModel category)
        {
            return null;
        }
        public CategoryViewModel GetById(Guid Id)
        {
            return _mapper.Map<CategoryViewModel>(_categoryRepository.GetById(Id));
        }

        public void Created(CategoryViewModel category)
        {
            _categoryRepository.Add(_mapper.Map<Category>(category));
        }
        public void Updated(CategoryViewModel category)
        {
            _categoryRepository.Update(_mapper.Map<Category>(category));
        }
        public void Removed(Guid Id)
        {
            _categoryRepository.Remove(Id);
        }
    }
}
