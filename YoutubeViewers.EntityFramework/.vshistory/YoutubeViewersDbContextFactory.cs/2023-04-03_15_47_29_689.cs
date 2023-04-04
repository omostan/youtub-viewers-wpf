using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeViewers.EntityFramework
{
    public class YoutubeViewersDbContextFactory
    {
        private readonly string _dbContext;

        public YoutubeViewersDbContext Create()
        {
            return new YoutubeViewersDbContext();
        }
    }
}
