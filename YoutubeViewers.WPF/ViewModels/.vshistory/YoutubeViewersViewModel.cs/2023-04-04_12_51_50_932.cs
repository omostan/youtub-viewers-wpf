using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using YoutubeViewers.WPF.Commands;
using YoutubeViewers.WPF.Stores;

namespace YoutubeViewers.WPF.ViewModels
{
    public class YoutubeViewersViewModel : ViewModelBase
    {
        public YoutubeViewersListingViewModel YoutubeViewersListingViewModel { get; }
        public YoutubeViewersDetailsViewModel YoutubeViewersDetailsViewModel { get; }

        public ICommand AddYoutubeViewersCommand { get; }
        public ICommand LoadYoutubeViewersCommand { get; }

        public YoutubeViewersViewModel(YoutubeViewersStore youtubeViewersStore, SelectedYoutubeViewerStore selectedYoutubeViewerStore, ModalNavigationStore modalNavigationStore)
        {
            YoutubeViewersListingViewModel = YoutubeViewersListingViewModel.LoadViewModel(youtubeViewersStore, selectedYoutubeViewerStore, modalNavigationStore);
            YoutubeViewersDetailsViewModel = new YoutubeViewersDetailsViewModel(selectedYoutubeViewerStore);

            AddYoutubeViewersCommand = new OpenAddYoutubeViewerCommand(youtubeViewersStore, modalNavigationStore);
        }
    }
}
