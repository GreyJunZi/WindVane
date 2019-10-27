using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using WindVane.PiliPala.Application.ViewModels;
using WindVane.PiliPala.Domain.Models;

namespace WindVane.PiliPala.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Menu, MenuViewModel>();
        }
    }
}
