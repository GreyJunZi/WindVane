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

                    Code = "Anime",
                    Name = "动漫",
                    Description = ""
                },
                new Category
                {
                    Id  = Guid.NewGuid(),

                    Code = "Film",
                    Name = "电影",
                    Description = ""
                },
                new Category
                {
                    Id = Guid.NewGuid(),

                    Code = "TV",
                    Name  = "电视剧",
                    Description = ""
                },
                new Category
                {
                    Id = Guid.NewGuid(),

                    Code = "Documentary",
                    Name = "记录片",
                    Description  =""
                },
                new Category
                {
                    Id = Guid.NewGuid(),

                    Code = "PhysicalEducation",
                    Name  ="体育",
                    Description = ""
                },
                new Category
                {
                    Id = Guid.NewGuid(),

                    Code = "Military",
                    Name ="军事",
                    Description  =""
                },
                new Category
                {
                    Id = Guid.NewGuid(),

                    Code = "History",
                    Name = "历史",
                    Description = ""
                },
                new Category
                {
                    Id = Guid.NewGuid(),

                    Code = "Technology",
                    Name = "科技",
                    Description = ""
                },
                new Category
                {
                    Id = Guid.NewGuid(),

                    Code = "Program",
                    Name= "编程",
                    Description = ""
                },
                new Category
                {
                    Id = Guid.NewGuid(),

                    Code = "Game",
                    Name = "游戏",
                    Description = ""
                },
                new Category
                {
                    Id = Guid.NewGuid(),

                    Code = "Original",
                    Name = "原创",
                    Description = ""
                },
                new Category
                {
                    Id = Guid.NewGuid(),

                    Code = "Education",
                    Name = "教育",
                    Description = ""
                }
            });
        }
    }
}
