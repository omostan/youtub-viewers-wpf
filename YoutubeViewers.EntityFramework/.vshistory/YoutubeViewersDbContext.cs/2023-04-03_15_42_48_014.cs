using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeViewers.Domain.Models;
using YoutubeViewers.EntityFramework.Dtos;

namespace YoutubeViewers.EntityFramework
{
    public class YoutubeViewersDbContext : DbContext
    {
        public DbSet<YoutubeViewerDto> Youtu { get; set;  }
    }
}
