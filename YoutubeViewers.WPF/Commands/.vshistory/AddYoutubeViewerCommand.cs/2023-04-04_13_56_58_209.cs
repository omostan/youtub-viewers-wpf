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
    public class AddYoutubeViewerCommand : AsyncCommandBase

    {
        private readonly AddYoutubeViewerViewModel _addYoutubeViewerViewModel;
        private readonly YoutubeViewersStore _youtubeViewersStore;
        private readonly ModalNavigationStore _modalNavigationStore;

        public AddYoutubeViewerCommand(AddYoutubeViewerViewModel addYoutubeViewerViewModel, YoutubeViewersStore youtubeViewersStore, ModalNavigationStore modalNavigationStore)
        {
            _addYoutubeViewerViewModel = addYoutubeViewerViewModel;
            _youtubeViewersStore = youtubeViewersStore;
            _modalNavigationStore = modalNavigationStore;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            YoutubeViewerDetailsFormViewModel formViewModel = _addYoutubeViewerViewModel.YoutubeViewerDetailsFormViewModel;

            formViewModel.IsSubmitting = false;

            YoutubeViewer youtubeViewer = new YoutubeViewer(
                Guid.NewGuid(),
                formViewModel.Username,
                formViewModel.IsSubscribed,
                formViewModel.IsMember
            );

            try
            {
                // Add Youtube viewer to the database
                await _youtubeViewersStore.Create(youtubeViewer);
                _modalNavigationStore.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
