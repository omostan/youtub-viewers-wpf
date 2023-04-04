﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeViewers.EntityFramework
{
    public class YoutubeViewersDbContextFactory
    {
        private readonly string _connectionString;
        private readonly DbContextOptions options;

        public YoutubeViewersDbContextFactory(DbContextOptions options)
        {
            _connectionString = connectionString;
            this.options = options;
        }

        // public string ConnectionString => _connectionString;

        public YoutubeViewersDbContext Create()
        {
            DbContextOptions options = new DbContextOptionsBuilder()
                .UseSqlite(_connectionString)
                .Options;

            return new YoutubeViewersDbContext(options);
        }
    }
}
