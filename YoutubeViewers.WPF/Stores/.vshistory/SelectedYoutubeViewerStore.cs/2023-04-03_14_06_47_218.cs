using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeViewers.WPF.Models;

namespace YoutubeViewers.WPF.Stores
{
    public class SelectedYoutubeViewerStore
    {
		private readonly YoutubeViewersStore _youtubeViewersStore;

		private YoutubeViewer _selectedYoutubeViewer;

		public YoutubeViewer SelectedYoutubeViewer
		{
			get
			{
				return _selectedYoutubeViewer;
			}
			set
			{
				_selectedYoutubeViewer = value;
                SelectedYoutubeViewerChanged?.Invoke();
			}
		}

        public event Action SelectedYoutubeViewerChanged;

        public SelectedYoutubeViewerStore(YoutubeViewersStore youtubeViewersStore)
        {
            _youtubeViewersStore = youtubeViewersStore;

            _youtubeViewersStore.YoutubeViewerUpdated += _youtubeViewersStore_YoutubeViewerUpdated;
        }

        private void _youtubeViewersStore_YoutubeViewerUpdated(YoutubeViewer youtubeViewer)
        {
            if
        }
    }
}
