﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeViewers.Domain.Commands;
using YoutubeViewers.Domain.Models;
using YoutubeViewers.EntityFramework.DTOs;

namespace YoutubeViewers.EntityFramework.Commands
{
    public class UpdateYoutubeViewerCommand : IUpdateYoutubeViewerCommand
    {
        private readonly YoutubeViewersDbContextFactory _contextFactory;

        public UpdateYoutubeViewerCommand(YoutubeViewersDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task Execute(YoutubeViewer youtubeViewer)
        {
            throw new Exception();
            using (YoutubeViewersDbContext context = _contextFactory.Create())
            {
                YoutubeViewerDto youtubeViewerDto = new YoutubeViewerDto()
                {
                    Id = youtubeViewer.Id,
                    Username = youtubeViewer.Username,
                    IsSubscribed = youtubeViewer.IsSubscribed,
                    IsMember = youtubeViewer.IsMember
                };

                context.YoutubeViewers.Update(youtubeViewerDto);
                await context.SaveChangesAsync();
            }
        }
    }
}
