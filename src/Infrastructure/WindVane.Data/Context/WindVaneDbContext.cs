using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace WindVane.Data.Context
{
    public class WindVaneDbContext : DbContext
    {
        public WindVaneDbContext(DbContextOptions<WindVaneDbContext> options)
            : base(options)
        {

        }

    }
}
