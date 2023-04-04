using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeViewers.Domain.Models;

namespace YoutubeViewers.EntityFramework
{
    public class YoutubeViewersDbContext : DbContext
    {
        public DbSet<YoutubeViewer> MyProperty { get; set;  }
    }
}
