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

        public async Task Add(YoutubeViewer youtubeViewer)
        {
            YoutubeViewerAdded?.Invoke(youtubeViewer);
        }
    }
}
