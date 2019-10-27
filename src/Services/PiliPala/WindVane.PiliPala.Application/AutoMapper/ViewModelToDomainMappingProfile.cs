using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using WindVane.PiliPala.Application.ViewModels;
using WindVane.PiliPala.Domain.Models;

namespace WindVane.PiliPala.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<MenuViewModel, Menu>();
        }
    }
}
