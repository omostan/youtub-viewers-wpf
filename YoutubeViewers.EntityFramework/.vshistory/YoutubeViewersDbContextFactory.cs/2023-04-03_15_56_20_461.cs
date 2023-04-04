using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeViewers.EntityFramework
{
    public class YoutubeViewersDbContextFactory
    {
        private readonly DbContextOptions _options;

        public YoutubeViewersDbContextFactory(DbContextOptions options)
        {
            _options = options;
        }

        // public string ConnectionString => _connectionString;

        public YoutubeViewersDbContext Create()
        {
            return new YoutubeViewersDbContext(_options);
        }
    }
}
