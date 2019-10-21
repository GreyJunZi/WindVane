using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace WindVane.Data.Context
{
    public class WindVaneContext : DbContext
    {
        public WindVaneContext(DbContextOptions<WindVaneContext> options)
            : base(options)
        {

        }

    }
}
