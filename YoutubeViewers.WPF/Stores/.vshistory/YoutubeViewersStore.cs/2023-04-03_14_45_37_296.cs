using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeViewers.Domain.Models;

namespace YoutubeViewers.WPF.Stores
{
    public class YoutubeViewersStore
    {
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
