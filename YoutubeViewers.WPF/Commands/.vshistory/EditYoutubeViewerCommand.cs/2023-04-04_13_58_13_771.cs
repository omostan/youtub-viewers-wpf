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
    public class EditYoutubeViewerCommand : AsyncCommandBase

    {
        private readonly EditYoutubeViewerViewModel _editYoutubeViewerViewModel;
        private readonly YoutubeViewersStore _youtubeViewersStore;
        private readonly ModalNavigationStore _modalNavigationStore;

        public EditYoutubeViewerCommand(EditYoutubeViewerViewModel editYoutubeViewerViewModel, YoutubeViewersStore youtubeViewersStore, ModalNavigationStore modalNavigationStore)
        {
            _editYoutubeViewerViewModel = editYoutubeViewerViewModel;
            _youtubeViewersStore = youtubeViewersStore;
            _modalNavigationStore = modalNavigationStore;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            YoutubeViewerDetailsFormViewModel formViewModel = _editYoutubeViewerViewModel.YoutubeViewerDetailsFormViewModel;
            YoutubeViewer youtubeViewer = new YoutubeViewer(
                _editYoutubeViewerViewModel.YoutubeViewerId,
                formViewModel.Username,
                formViewModel.IsSubscribed,
                formViewModel.IsMember
            );

            try
            {
                // Add Youtube viewer to the database
                await _youtubeViewersStore.Update(youtubeViewer);
                _modalNavigationStore.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                formViewModel.IsSubmitting = false;
            }
        }
    }
}
