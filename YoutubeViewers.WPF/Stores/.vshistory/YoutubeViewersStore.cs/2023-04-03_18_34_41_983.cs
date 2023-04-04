using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeViewers.Domain.Commands;
using YoutubeViewers.Domain.Models;
using YoutubeViewers.Domain.Queries;

namespace YoutubeViewers.WPF.Stores
{
    public class YoutubeViewersStore
    {
        private readonly IGetAllYoutubeViewersQuery _getAllYoutubeViewersQuery;
        private readonly ICreateYoutubeViewerCommand _createYoutubeViewerCommand;
        private readonly IUpdateYoutubeViewerCommand _updateYoutubeViewerCommand;
        private readonly IDeleteYoutubeViewerCommand _deleteYoutubeViewerCommand;

        public event Action<YoutubeViewer> YoutubeViewerCreated;
        public event Action<YoutubeViewer> YoutubeViewerUpdated;

        public YoutubeViewersStore(
            IGetAllYoutubeViewersQuery getAllYoutubeViewersQuery,
            ICreateYoutubeViewerCommand createYoutubeViewerCommand,
            IUpdateYoutubeViewerCommand updateYoutubeViewerCommand,
            IDeleteYoutubeViewerCommand deleteYoutubeViewerCommand
        )
        {
            _getAllYoutubeViewersQuery = getAllYoutubeViewersQuery;
            _createYoutubeViewerCommand = createYoutubeViewerCommand;
            _updateYoutubeViewerCommand = updateYoutubeViewerCommand;
            _deleteYoutubeViewerCommand = deleteYoutubeViewerCommand;
        }

        public async Task Load()
        {
            IEnumerable <> await _getAllYoutubeViewersQuery.Execute();
        }

        public async Task Create(YoutubeViewer youtubeViewer)
        {
            await _createYoutubeViewerCommand.Execute(youtubeViewer);
            YoutubeViewerCreated?.Invoke(youtubeViewer);
        }

        public async Task Update(YoutubeViewer youtubeViewer)
        {
            await _updateYoutubeViewerCommand.Execute(youtubeViewer);
            YoutubeViewerUpdated?.Invoke(youtubeViewer);
        }
    }
}
