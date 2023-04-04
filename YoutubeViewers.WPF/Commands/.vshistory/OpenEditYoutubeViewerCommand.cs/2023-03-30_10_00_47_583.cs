using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeViewers.WPF.Stores;
using YoutubeViewers.WPF.ViewModels;

namespace YoutubeViewers.WPF.Commands
{
    public class OpenEditYoutubeViewerCommand : CommandBase
    {
        private readonly ModalNavigationStore _modalNavigationStore;

        public OpenEditYoutubeViewerCommand(ModalNavigationStore modalNavigationStore)
        {
            _modalNavigationStore = modalNavigationStore;
        }

        public override void Execute(object? parameter)
        {
            EditYoutubeViewerViewModel addYoutubeViewerViewModel = new EditYoutubeViewerViewModel(_modalNavigationStore);
            _modalNavigationStore.CurrentViewModel = editYoutubeViewerViewModel;
        }
    }
}
