using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeViewers.EntityFramework.Commands
{
    public class UpdateYoutubeViewerCommand : 
    {
        private readonly YoutubeViewersDbContextFactory _contextFactory;

        public UpdateYoutubeViewerCommand(YoutubeViewersDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }
    }
}
