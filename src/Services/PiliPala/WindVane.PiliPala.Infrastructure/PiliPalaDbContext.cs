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

        }
    }
}
