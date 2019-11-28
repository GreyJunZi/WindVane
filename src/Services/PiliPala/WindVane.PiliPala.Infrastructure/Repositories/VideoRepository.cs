using System;
using System.Collections.Generic;
using System.Text;
using WindVane.PiliPala.Domain.Interfaces.Repositories;
using WindVane.PiliPala.Domain.Models;

namespace WindVane.PiliPala.Infrastructure.Repositories
{
    public class VideoRepository : Repository<Video>, IVideoRepository
    {
        public VideoRepository(PiliPalaDbContext dbContext) : base(dbContext)
        {

        }
    }
}
