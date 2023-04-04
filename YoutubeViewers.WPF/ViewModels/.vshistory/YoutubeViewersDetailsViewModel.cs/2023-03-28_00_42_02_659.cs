using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeViewers.WPF.Models;
using YoutubeViewers.WPF.Stores;

namespace YoutubeViewers.WPF.ViewModels
{
    public class YoutubeViewersDetailsViewModel : ViewModelBase
    {
        private readonly SelectedYoutubeViewerStore _selectedYoutubeViewerStore;

        private YoutubeViewer SelectedYoutubeViewer => _selectedYoutubeViewerStore.SelectedYoutubeViewer;


        public bool HasSelectedYoutubeViewer => SelectedYoutubeViewer != null;
        public string Username => SelectedYoutubeViewer?.Username ?? "Unknown";
        public string IsSubscribedDisplay => (SelectedYoutubeViewer?.IsSubscribed ?? false) ? "Yes" : "No";
        public string IsMemberDisplay => (_selectedYoutubeViewerStore.SelectedYoutubeViewer?.IsMember ?? false) ? "Yes" : "No";

        public YoutubeViewersDetailsViewModel(SelectedYoutubeViewerStore selectedYoutubeViewerStore)
        {
            _selectedYoutubeViewerStore = selectedYoutubeViewerStore;

            _selectedYoutubeViewerStore.SelectedYoutubeViewerChanged += _selectedYoutubeViewerStore_SelectedYoutubeViewerChanged;
        }

        private void _selectedYoutubeViewerStore_SelectedYoutubeViewerChanged()
        {
            OnePropertyChanged(nameof(HasSelectedYoutubeViewer));
            OnePropertyChanged(nameof(Username));
            OnePropertyChanged(nameof(HasSelectedYoutubeViewer));
            OnePropertyChanged(nameof(HasSelectedYoutubeViewer));
        }
    }
}
