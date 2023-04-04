using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using YoutubeViewers.WPF.Commands;
using YoutubeViewers.Domain.Models;
using YoutubeViewers.WPF.Stores;

namespace YoutubeViewers.WPF.ViewModels
{
    public class YoutubeViewersListingItemViewModel : ViewModelBase
    {
        private YoutubeViewersStore _youtubeViewersStore;
        private ModalNavigationStore _modalNavigationStore;

        public YoutubeViewer YoutubeViewer { get; private set; }

        public string Username => YoutubeViewer.Username;

        public ICommand? EditCommand { get; }

        public ICommand? DeleteCommand { get; }

        public YoutubeViewersListingItemViewModel(YoutubeViewer youtubeviewer, YoutubeViewersStore youtubeViewersStore, ModalNavigationStore modalNavigationStore)
        {
            YoutubeViewer = youtubeviewer;

            EditCommand = new OpenEditYoutubeViewerCommand(this, youtubeViewersStore, modalNavigationStore);
            DeleteCommand = 
            //_youtubeViewersStore = youtubeViewersStore;
            //_modalNavigationStore = modalNavigationStore;
        }

        public void Update(YoutubeViewer youtubeviewer)
        {
            YoutubeViewer = youtubeviewer;

            OnPropertyChanged(nameof(Username));
        }
    }
}
