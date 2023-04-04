using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeViewers.WPF.Stores;
using YoutubeViewers.WPF.ViewModels;

namespace YoutubeViewers.WPF.Commands
{
    public class EditYoutubeViewerCommand : AsyncCommandBase

    {
        private readonly EditYoutubeViewerViewModel _editYoutubeViewerViewModel;
        private readonly YoutubeViewersStore _youtubeViewersStore;
        private readonly ModalNavigationStore _modalNavigationStore;

        public EditYoutubeViewerCommand(YoutubeViewersStore youtubeViewersStore, ModalNavigationStore modalNavigationStore)
        {
            _youtubeViewersStore = youtubeViewersStore;
            _modalNavigationStore = modalNavigationStore;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            YoutubeViewerDetailsFormViewModel formViewModel = _editYoutubeViewerViewModel.YoutubeViewerDetailsFormViewModel;
            // Edit Youtube viewer to the database

            _youtubeViewersStore.Update();
            _modalNavigationStore.Close();
        }
    }
}
