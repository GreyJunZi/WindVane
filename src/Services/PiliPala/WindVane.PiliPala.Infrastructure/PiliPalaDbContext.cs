using Microsoft.EntityFrameworkCore;
using System;
using WindVane.PiliPala.Domain.Models;

namespace WindVane.PiliPala.Infrastructure
{
    public class PiliPalaDbContext : DbContext
    {
        public DbSet<Menu> Menus { get; set; }

        public PiliPalaDbContext(DbContextOptions<PiliPalaDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Menu>().HasData(new Menu[] {

                new Menu()
                {
                    Name = "动漫",
                    Link="/Channel/Anime",
                    Icon = "",
                    Description = "",

                    IsPublished  = true,
                    DisplayOrder = 100
                },
                new Menu()
                {
                    Name = "电影",
                    Link="/Channel/Film",
                    Icon = "",
                    Description = "",

                    IsPublished  = true,
                    DisplayOrder = 200
                },
                new Menu()
                {
                    Name = "电视剧",
                    Link="/Channel/TV",
                    Icon = "",
                    Description = "",

                    IsPublished  = true,
                    DisplayOrder = 300
                },
                new Menu()
                {
                    Name = "纪录片",
                    Link="/Channel/Documentary",
                    Icon = "",
                    Description = "",

                    IsPublished  = true,
                    DisplayOrder = 400
                },
                new Menu()
                {
                    Name = "体育",
                    Link="/Channel/PhysicalEducation",
                    Icon = "",
                    Description = "",

                    IsPublished  = true,
                    DisplayOrder = 500
                },
                new Menu()
                {
                    Name = "军事",
                    Link="/Channel/Military",
                    Icon = "",
                    Description = "",

                    IsPublished  = true,
                    DisplayOrder = 600
                },
                new Menu()
                {
                    Name = "历史",
                    Link="/Channel/History",
                    Icon = "",
                    Description = "",

                    IsPublished  = true,
                    DisplayOrder = 700
                },
                new Menu()
                {
                    Name = "科技",
                    Link="/Channel/Technology",
                    Icon = "",
                    Description = "",

                    IsPublished  = true,
                    DisplayOrder = 800
                },
                new Menu()
                {
                    Name = "编程",
                    Link="/Channel/Program",
                    Icon = "",
                    Description = "",

                    IsPublished  = true,
                    DisplayOrder = 900
                },
                new Menu()
                {
                    Name = "游戏",
                    Link="/Channel/Game",
                    Icon = "",
                    Description = "",

                    IsPublished  = true,
                    DisplayOrder = 1000
                },
                new Menu()
                {
                    Name = "原创",
                    Link="/Channel/Original",
                    Icon = "",
                    Description = "",

                    IsPublished  = true,
                    DisplayOrder = 1100
                },
                new Menu()
                {
                    Name = "教育",
                    Link="/Channel/Education",
                    Icon = "",
                    Description = "",

                    IsPublished  = true,
                    DisplayOrder = 1200
                }
            });

            modelBuilder.Entity<Category>().HasData(new Category[] {
                new Category
                {
                    Id = Guid.NewGuid(),

                    Name = "动漫",
                    Description = "",
                    Icon = "",
                    Link = "/Channel/Anime",
                    IsPublished = true,
                    DisplayOrder = 1
                },
                new Category
                {
                    Id  = Guid.NewGuid(),

                    Name = "电影",
                    Description = "",
                    Icon = "",
                    Link = "/Channel/Film",
                    IsPublished = true,
                    DisplayOrder = 2
                },
                new Category
                {
                    Id = Guid.NewGuid(),

                    Name  = "电视剧",
                    Description = "",
                    Icon = "",
                    Link = "/Channel/TV",
                    IsPublished = true,
                    DisplayOrder = 3
                },
                new Category
                {
                    Id = Guid.NewGuid(),

                    Name = "记录片",
                    Description  ="",
                    Icon = "",
                    Link = "/Channel/Documentary",
                    IsPublished = true,
                    DisplayOrder =4
                },
                new Category
                {
                    Id = Guid.NewGuid(),

                    Name  ="体育",
                    Description = "",
                    Icon  = "",
                    Link= "/Channel/PhysicalEducation",
                    IsPublished = true,
                    DisplayOrder = 5
                },
                new Category
                {
                    Id = Guid.NewGuid(),

                    Name ="军事",
                    Description  ="",
                    Icon = "",
                    Link = "/Channel/Military",
                    IsPublished = true,
                    DisplayOrder = 6
                },
                new Category
                {
                    Id = Guid.NewGuid(),

                    Name = "历史",
                    Description = "",
                    Icon = "",
                    Link= "/Channel/History",
                    IsPublished = true,
                    DisplayOrder = 7
                },
                new Category
                {
                    Id = Guid.NewGuid(),

                    Name = "科技",
                    Description = "",
                    Icon = "",
                    Link = "/Channel/Technology",
                    IsPublished = true,
                    DisplayOrder = 8
                },
                new Category
                {
                    Id = Guid.NewGuid(),

                    Name= "编程",
                    Description = "",
                    Icon = "",
                    Link = "/Channel/Program",
                    IsPublished = true,
                    DisplayOrder=9
                },
                new Category
                {
                    Id = Guid.NewGuid(),

                    Name = "游戏",
                    Description = "",
                    Icon = "",
                    Link = "/Channel/Game",
                    IsPublished = true,
                    DisplayOrder = 10
                },
                new Category
                {
                    Id = Guid.NewGuid(),

                    Name = "原创",
                    Description = "",
                    Icon = "",
                    Link = "/Channel/Original",
                    IsPublished = true,
                    DisplayOrder = 11
                },
                new Category
                {
                    Id = Guid.NewGuid(),

                    Name = "教育",
                    Description = "",
                    Icon = "",
                    Link = "/Channel/Education",
                    IsPublished = true,
                    DisplayOrder = 12
                }
            });
        }
    }
}
