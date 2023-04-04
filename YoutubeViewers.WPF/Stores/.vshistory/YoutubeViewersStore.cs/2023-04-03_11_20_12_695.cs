using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeViewers.WPF.Models;

namespace YoutubeViewers.WPF.Stores
{
    public class YoutubeViewersStore
    {
        public event Action<YoutubeViewer> YoutubeViewerAdded;
        public event Action<YoutubeViewer> YoutubeViewerEdited;

        public async Task Create(YoutubeViewer youtubeViewer)
        {
            YoutubeViewerAdded?.Invoke(youtubeViewer);
        }

        public async Task Update(YoutubeViewer youtubeViewer)
        {
            YoutubeViewerAdded?.Invoke(youtubeViewer);
        }
    }
}
