using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeViewers.Domain.Commands;
using YoutubeViewers.Domain.Models;

namespace YoutubeViewers.WPF.Stores
{
    public class YoutubeViewersStore
    {
        private ICreateYoutubeViewerCommand _createYoutubeViewerCommand;
        private IUpdateYoutubeViewerCommand UpdateYoutubeViewerCommand;

        public event Action<YoutubeViewer> YoutubeViewerCreated;
        public event Action<YoutubeViewer> YoutubeViewerUpdated;

        public async Task Create(YoutubeViewer youtubeViewer)
        {
            YoutubeViewerCreated?.Invoke(youtubeViewer);
        }

        public async Task Update(YoutubeViewer youtubeViewer)
        {
            YoutubeViewerUpdated?.Invoke(youtubeViewer);
        }
    }
}
