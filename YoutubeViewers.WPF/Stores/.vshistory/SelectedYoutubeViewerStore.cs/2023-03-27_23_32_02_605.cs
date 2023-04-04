using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeViewers.WPF.Stores
{
    public class SelectedYoutubeViewerStore
    {
		private YoutubeViewer _youtubeViewer;

		public YoutubeViewer Yout
		{
			get { return _youtubeViewer; }
			set { _youtubeViewer = value; }
		}

	}
}
