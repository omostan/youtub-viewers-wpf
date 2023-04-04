using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeViewers.Domain.Models;
using YoutubeViewers.Domain.Queries;
using YoutubeViewers.EntityFramework.DTOs;

namespace YoutubeViewers.EntityFramework.Queries
{
    public class GetAllYoutubeViewersQuery : IGetAllYoutubeViewersQuery
    {
        private readonly YoutubeViewersDbContextFactory _contextFactory;

        public GetAllYoutubeViewersQuery(YoutubeViewersDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<IEnumerable<YoutubeViewer>> Execute()
        {
            using (YoutubeViewersDbContext context = _contextFactory.Create())
            {
                IEnumerable<YoutubeViewerDto> youtubeViewerDtos = await context.YoutubeViewers.ToListAsync();

                return youtubeViewerDtos.Select(x => new YoutubeViewerDto(x.Id, x.Username, x.IsSubscribed, x.IsMember))
            }
        }
    }
}
