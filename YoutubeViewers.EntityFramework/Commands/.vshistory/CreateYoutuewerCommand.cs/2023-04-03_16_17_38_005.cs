using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeViewers.Domain.Commands;
using YoutubeViewers.Domain.Models;

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
            throw new NotImplementedException();
        }
    }
}
