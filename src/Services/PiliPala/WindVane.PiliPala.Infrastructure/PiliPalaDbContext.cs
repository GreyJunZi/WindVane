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
        }
    }
}
