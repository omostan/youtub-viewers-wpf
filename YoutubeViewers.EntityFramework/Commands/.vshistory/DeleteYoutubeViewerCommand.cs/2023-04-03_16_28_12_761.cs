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
    public class DeleteYoutubeViewerCommand : IDeleteYoutubeViewerCommand
    {
        private readonly YoutubeViewersDbContextFactory _contextFactory;

        public DeleteYoutubeViewerCommand(YoutubeViewersDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task Execute(Guid id)
        {
            using (YoutubeViewersDbContext context = _contextFactory.Create())
            {
                YoutubeViewerDto youtubeViewerDto = new YoutubeViewerDto()
                {
                    Id = youtubeViewer.Id
                };

                context.YoutubeViewers.Update(youtubeViewerDto);
                await context.SaveChangesAsync();
            }
        }
    }
}
