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
    public class DeleteYoutubeViewerCommand : AsyncCommandBase
    {
        private readonly YoutubeViewersListingItemViewModel _youtubeViewersListingItemViewModel;
        private readonly YoutubeViewersStore _youtubeViewersStore;

        public DeleteYoutubeViewerCommand(YoutubeViewersListingItemViewModel youtubeViewersListingItemViewModel, YoutubeViewersStore youtubeViewersStore, ModalNavigationStore modalNavigationStore)
        {
            _youtubeViewersListingItemViewModel = youtubeViewersListingItemViewModel;
            _youtubeViewersStore = youtubeViewersStore;
            _modalNavigationStore = modalNavigationStore;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            YoutubeViewer youtubeViewer = _youtubeViewersListingItemViewModel.YoutubeViewer;
        }
    }
}
