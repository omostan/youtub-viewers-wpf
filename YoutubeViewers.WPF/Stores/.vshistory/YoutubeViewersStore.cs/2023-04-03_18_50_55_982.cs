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

        private readonly List<YoutubeViewer> _youtubeViewers;
        public IEnumerable<YoutubeViewer> YoutubeViewers => _youtubeViewers;

        public event Action YoutubeViewerLoaded;
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

            _youtubeViewers = new List<YoutubeViewer>();
        }

        public async Task Load()
        {
            IEnumerable<YoutubeViewer> youtubeViewers = await _getAllYoutubeViewersQuery.Execute();

            _youtubeViewers.Clear();

            _youtubeViewers.AddRange(youtubeViewers);

            YoutubeViewerLoaded?.Invoke();
        }

        public async Task Create(YoutubeViewer youtubeViewer)
        {
            await _createYoutubeViewerCommand.Execute(youtubeViewer);

            _youtubeViewers.Add(youtubeViewer);

            YoutubeViewerCreated?.Invoke(youtubeViewer);
        }

        public async Task Update(YoutubeViewer youtubeViewer)
        {
            await _updateYoutubeViewerCommand.Execute(youtubeViewer);

            int currentIndex = _youtubeViewers.FindIndex(x => x.Id == youtubeViewer.Id);

            if (currentIndex != -1)
            {
                _youtubeViewers[currentIndex] = youtubeViewer;
            }
            else
            {
                _youtubeViewers.Add()
            }

            YoutubeViewerUpdated?.Invoke(youtubeViewer);
        }
    }
}
