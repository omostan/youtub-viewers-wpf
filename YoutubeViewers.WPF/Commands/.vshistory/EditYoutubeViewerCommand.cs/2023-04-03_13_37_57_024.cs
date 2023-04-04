using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeViewers.WPF.Stores;

namespace YoutubeViewers.WPF.Commands
{
    public class EditYoutubeViewerCommand : AsyncCommandBase

    {
        private readonly YoutubeViewersStore _youtubeViewersStore;
        private readonly ModalNavigationStore _modalNavigationStore;

        public EditYoutubeViewerCommand(YoutubeViewersStore youtubeViewersStore, ModalNavigationStore modalNavigationStore)
        {
            _youtubeViewersStore = youtubeViewersStore;
            _modalNavigationStore = modalNavigationStore;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            // Edit Youtube viewer to the database

            _youtubeViewersStore.YoutubeViewerUpdated();
            _modalNavigationStore.Close();
        }
    }
}
