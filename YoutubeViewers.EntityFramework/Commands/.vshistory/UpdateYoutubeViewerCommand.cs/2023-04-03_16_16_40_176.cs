using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeViewers.Domain.Commands;

namespace YoutubeViewers.EntityFramework.Commands
{
    public class UpdateYoutubeViewerCommand : IUpdateYoutubeViewerCommand
    {
        private readonly YoutubeViewersDbContextFactory _contextFactory;

        public UpdateYoutubeViewerCommand(YoutubeViewersDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }
    }
}
