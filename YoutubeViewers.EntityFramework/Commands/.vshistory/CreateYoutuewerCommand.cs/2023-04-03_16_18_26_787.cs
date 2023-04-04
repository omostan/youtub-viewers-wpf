using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeViewers.Domain.Commands;
using YoutubeViewers.Domain.Models;
using YoutubeViewers.EntityFramework.DTOs;

namespace YoutubeViewers.EntityFramework.Commands
{
    public class CreateYoutuewerCommand : ICreateYoutubeViewerCommand
    {
        private readonly YoutubeViewersDbContextFactory _contextFactory;

        public CreateYoutuewerCommand(YoutubeViewersDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task Execute(YoutubeViewer youtubeViewer)
        {
            using (YoutubeViewersDbContext context = _contextFactory.Create())
            {
                IEnumerable<YoutubeViewerDto> youtubeViewerDtos = await context.YoutubeViewers.ToListAsync();

                return youtubeViewerDtos.Select(x => new YoutubeViewer(x.Id, x.Username, x.IsSubscribed, x.IsMember));
            }
        }
    }
}
