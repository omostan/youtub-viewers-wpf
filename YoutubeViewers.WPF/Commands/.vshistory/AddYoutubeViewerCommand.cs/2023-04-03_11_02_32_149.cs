using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeViewers.WPF.Stores;

namespace YoutubeViewers.WPF.Commands
{
    public class AddYoutubeViewerCommand : AsyncCommandBase

    {
        private readonly YoutubeViewersStore _youtubeViewersStore;
        private readonly ModalNavigationStore _modalNavigationStore;

        public AddYoutubeViewerCommand(YoutubeViewersStore youtubeViewersStore, ModalNavigationStore modalNavigationStore)
        {
            _youtubeViewersStore = youtubeViewersStore;
            _modalNavigationStore = modalNavigationStore;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            // Add Youtube viewer to the database
            _youtubeViewersStore.Add(youtubeViewer);
            _modalNavigationStore.Close();
        }
    }
}
