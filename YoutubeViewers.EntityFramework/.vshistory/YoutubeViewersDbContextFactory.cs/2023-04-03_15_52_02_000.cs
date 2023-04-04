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

        public YoutubeViewersDbContextFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        // public string ConnectionString => _connectionString;

        public YoutubeViewersDbContext Create()
        {
            DbContextOptionsBuilder optionsBuilder = new DbContextOptionsBuilder().UseSqlite

            return new YoutubeViewersDbContext();
        }
    }
}
