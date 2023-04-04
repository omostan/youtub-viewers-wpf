using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeViewers.Domain.Commands;

namespace YoutubeViewers.EntityFramework.Commands
{
    public class DeleteYoutubeViewerCommand : IDeleteYoutubeViewerCommand
    {
        private readonly YoutubeViewersDbContextFactory _contextFactory;

        public DeleteYoutubeViewerCommand(YoutubeViewersDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public Task Execute(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
