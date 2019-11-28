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
            modelBuilder.Entity<Category>().HasData(new Category[] {
                new Category
                {
                    Id = Guid.NewGuid(),

                    Name = "动漫",
                    Description = "",
                    Icon = "",
                    Link = "/Category/Anime",
                    IsPublished = true,
                    DisplayOrder = 1
                },
                new Category
                {
                    Id  = Guid.NewGuid(),

                    Name = "电影",
                    Description = "",
                    Icon = "",
                    Link = "/Category/Film",
                    IsPublished = true,
                    DisplayOrder = 2
                },
                new Category
                {
                    Id = Guid.NewGuid(),

                    Name  = "电视剧",
                    Description = "",
                    Icon = "",
                    Link = "/Category/TV",
                    IsPublished = true,
                    DisplayOrder = 3
                },
                new Category
                {
                    Id = Guid.NewGuid(),

                    Name = "记录片",
                    Description  ="",
                    Icon = "",
                    Link = "/Category/Documentary",
                    IsPublished = true,
                    DisplayOrder =4
                },
                new Category
                {
                    Id = Guid.NewGuid(),

                    Name  ="体育",
                    Description = "",
                    Icon  = "",
                    Link= "/Category/PhysicalEducation",
                    IsPublished = true,
                    DisplayOrder = 5
                },
                new Category
                {
                    Id = Guid.NewGuid(),

                    Name ="军事",
                    Description  ="",
                    Icon = "",
                    Link = "/Category/Military",
                    IsPublished = true,
                    DisplayOrder = 6
                },
                new Category
                {
                    Id = Guid.NewGuid(),

                    Name = "历史",
                    Description = "",
                    Icon = "",
                    Link= "/Category/History",
                    IsPublished = true,
                    DisplayOrder = 7
                },
                new Category
                {
                    Id = Guid.NewGuid(),

                    Name = "科技",
                    Description = "",
                    Icon = "",
                    Link = "/Category/Technology",
                    IsPublished = true,
                    DisplayOrder = 8
                },
                new Category
                {
                    Id = Guid.NewGuid(),

                    Name= "编程",
                    Description = "",
                    Icon = "",
                    Link = "/Category/Program",
                    IsPublished = true,
                    DisplayOrder=9
                },
                new Category
                {
                    Id = Guid.NewGuid(),

                    Name = "游戏",
                    Description = "",
                    Icon = "",
                    Link = "/Category/Game",
                    IsPublished = true,
                    DisplayOrder = 10
                },
                new Category
                {
                    Id = Guid.NewGuid(),

                    Name = "原创",
                    Description = "",
                    Icon = "",
                    Link = "/Category/Original",
                    IsPublished = true,
                    DisplayOrder = 11
                },
                new Category
                {
                    Id = Guid.NewGuid(),

                    Name = "教育",
                    Description = "",
                    Icon = "",
                    Link = "/Category/Education",
                    IsPublished = true,
                    DisplayOrder = 12
                }
            });
        }
    }
}
