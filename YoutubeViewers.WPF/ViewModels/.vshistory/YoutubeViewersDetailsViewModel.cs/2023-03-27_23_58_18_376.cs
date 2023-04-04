using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeViewers.WPF.Stores;

namespace YoutubeViewers.WPF.ViewModels
{
    public class YoutubeViewersDetailsViewModel : ViewModelBase
    {
        private readonly SelectedYoutubeViewerStore _selectedYoutubeViewerStore;

        public string Username => _selectedYoutubeViewerStore.SelectedYoutubeViewer?.Username;
        public string IsSubscribedDisplay => _selectedYoutubeViewerStore.SelectedYoutubeViewer?.Username;
        public string IsMemberDisplay => _selectedYoutubeViewerStore.SelectedYoutubeViewer?.IsMember

        public YoutubeViewersDetailsViewModel(SelectedYoutubeViewerStore selectedYoutubeViewerStore)
        {
            _selectedYoutubeViewerStore = selectedYoutubeViewerStore;
        }
    }
}
