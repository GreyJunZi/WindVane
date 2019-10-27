using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindVane.PiliPala.Domain.Models;

namespace WindVane.PiliPala.Infrastructure
{
    public class PiliPalaDbContextSeed
    {
        public async Task SeedAsync(PiliPalaDbContext context, IServiceProvider service)
        {
            if (!context.Menus.Any())
            {
                context.Menus.AddRange(GetPreconfiguredMenus());

                await context.SaveChangesAsync();
            }
        }

        #region Menu

        public IEnumerable<Menu> GetPreconfiguredMenus()
        {
            return new List<Menu>{
                new Menu()
                {
                    Name = "动漫",
                    Link="",
                    Icon = "",
                    Description = "",

                    IsPublished  = true,
                    DisplayOrder = 100
                },
                new Menu()
                {
                    Name = "电影",
                    Link="",
                    Icon = "",
                    Description = "",

                    IsPublished  = true,
                    DisplayOrder = 200
                },
                new Menu()
                {
                    Name = "电视剧",
                    Link="",
                    Icon = "",
                    Description = "",

                    IsPublished  = true,
                    DisplayOrder = 300
                },
                new Menu()
                {
                    Name = "纪录片",
                    Link="",
                    Icon = "",
                    Description = "",

                    IsPublished  = true,
                    DisplayOrder = 400
                },
                new Menu()
                {
                    Name = "体育",
                    Link="",
                    Icon = "",
                    Description = "",

                    IsPublished  = true,
                    DisplayOrder = 500
                },
                new Menu()
                {
                    Name = "军事",
                    Link="",
                    Icon = "",
                    Description = "",

                    IsPublished  = true,
                    DisplayOrder = 600
                },
                new Menu()
                {
                    Name = "历史",
                    Link="",
                    Icon = "",
                    Description = "",

                    IsPublished  = true,
                    DisplayOrder = 700
                },
                new Menu()
                {
                    Name = "科技",
                    Link="",
                    Icon = "",
                    Description = "",

                    IsPublished  = true,
                    DisplayOrder = 800
                },
                new Menu()
                {
                    Name = "编程",
                    Link="",
                    Icon = "",
                    Description = "",

                    IsPublished  = true,
                    DisplayOrder = 900
                },
                new Menu()
                {
                    Name = "游戏",
                    Link="",
                    Icon = "",
                    Description = "",

                    IsPublished  = true,
                    DisplayOrder = 1000
                },
                new Menu()
                {
                    Name = "原创",
                    Link="",
                    Icon = "",
                    Description = "",

                    IsPublished  = true,
                    DisplayOrder = 1100
                },
                new Menu()
                {
                    Name = "教育",
                    Link="",
                    Icon = "",
                    Description = "",

                    IsPublished  = true,
                    DisplayOrder = 1200
                },
            };
        }

        #endregion
    }
}
