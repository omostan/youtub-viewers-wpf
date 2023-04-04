using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeViewers.Domain.Models;
using YoutubeViewers.WPF.Stores;
using YoutubeViewers.WPF.ViewModels;

namespace YoutubeViewers.WPF.Commands
{
    public class OpenEditYoutubeViewerCommand : CommandBase
    {
        private readonly YoutubeViewersListingItemViewModel _youtubeViewersListingItemViewModel;
        private readonly YoutubeViewersStore _youtubeViewersStore;
        private readonly ModalNavigationStore _modalNavigationStore;

        public OpenEditYoutubeViewerCommand(YoutubeViewersListingItemViewModel youtubeViewersListingItemViewModel, YoutubeViewersStore youtubeViewersStore, ModalNavigationStore modalNavigationStore)
        {
            _youtubeViewersListingItemViewModel = youtubeViewersListingItemViewModel;
            _youtubeViewersStore = youtubeViewersStore;
            _modalNavigationStore = modalNavigationStore;
        }

        public override void Execute(object? parameter)
        {
            YoutubeViewer youtubeViewer = _youtubeViewersListingItemViewModel.YoutubeViewer;

            EditYoutubeViewerViewModel editYoutubeViewerViewModel = new EditYoutubeViewerViewModel(youtubeViewer, _youtubeViewersStore, _modalNavigationStore);
            _modalNavigationStore.CurrentViewModel = editYoutubeViewerViewModel;
        }
    }
}
