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

        public string Username => _selectedYoutubeViewerStore.SelectedYoutubeViewer.Username;
        public string IsSubscribedDisplay { get; }
        public string IsMemberDisplay { get; }

        public YoutubeViewersDetailsViewModel(SelectedYoutubeViewerStore selectedYoutubeViewerStore)
        {
            Username = "SingletonSean";
            IsSubscribedDisplay = "Yes";
            IsMemberDisplay = "No";
            _selectedYoutubeViewerStore = selectedYoutubeViewerStore;
        }
    }
}
