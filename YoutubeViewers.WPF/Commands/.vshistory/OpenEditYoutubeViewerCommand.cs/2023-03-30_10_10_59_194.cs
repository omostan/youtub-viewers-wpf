using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeViewers.WPF.Models;
using YoutubeViewers.WPF.Stores;
using YoutubeViewers.WPF.ViewModels;

namespace YoutubeViewers.WPF.Commands
{
    public class OpenEditYoutubeViewerCommand : CommandBase
    {
        private readonly ModalNavigationStore _modalNavigationStore;
        private readonly ModalNavigationStore _modalNavigationStore;

        public OpenEditYoutubeViewerCommand(YoutubeViewer youtubeViewer, ModalNavigationStore modalNavigationStore)
        {
            _youtubeViewer = youtubeViewer;
            _modalNavigationStore = modalNavigationStore;
        }

        public override void Execute(object? parameter)
        {
            EditYoutubeViewerViewModel editYoutubeViewerViewModel = new EditYoutubeViewerViewModel(_youtubeViewer, _modalNavigationStore);
            _modalNavigationStore.CurrentViewModel = editYoutubeViewerViewModel;
        }
    }
}
