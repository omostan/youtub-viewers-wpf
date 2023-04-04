﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeViewers.EntityFramework;

namespace YoutubeViewers.WPF.HostBuilders
{
    public static class AddDbContextHostBuilderExtensions
    {
        public static IHostBuilder AddDbContext(this IHostBuilder hostBuilder)
        {
            hostBuilder.ConfigureServices((context, services) =>
             {


                 string? connectionString = context.Configuration.GetConnectionString("sqlite");

                 DbContextOptions options = new DbContextOptionsBuilder().UseSqlite(connectionString).Options;
                 services.AddSingleton<DbContextOptions>(options);
                 services.AddSingleton<YoutubeViewersDbContextFactory>();
             });

                 return hostBuilder;
        }

        public static IHostBuilder AddDbContext(this IHostBuilder hostBuilder)
        {
            hostBuilder.ConfigureServices((context, services) =>
             {


                 string? connectionString = context.Configuration.GetConnectionString("sqlite");

                 DbContextOptions options = new DbContextOptionsBuilder().UseSqlite(connectionString).Options;
                 services.AddSingleton<DbContextOptions>(options);
                 services.AddSingleton<YoutubeViewersDbContextFactory>();
             });

                 return hostBuilder;
        }
    }
}
