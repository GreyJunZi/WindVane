using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WindVane.Domain.Interfaces;
using WindVane.PiliPala.Domain.Interfaces.Repositories;
using WindVane.PiliPala.Domain.Models;

namespace WindVane.PiliPala.Infrastructure.Repositories
{
    public class MenuRepository : Repository<Menu>, IMenuRepository
    {
        public MenuRepository(PiliPalaDbContext dbContext) : base(dbContext)
        {

        }
    }
}
