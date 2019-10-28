using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace WindVane.PiliPala.Infrastructure
{
    public class PiliPalaDbContextFactory : IDesignTimeDbContextFactory<PiliPalaDbContext>
    {
        public PiliPalaDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<PiliPalaDbContext>();
            builder.UseSqlServer("Data Source=.;Initial Catalog=WindVane.PiliPala;User ID=sa;Password=123;");

            return new PiliPalaDbContext(builder.Options);
        }
    }
}
