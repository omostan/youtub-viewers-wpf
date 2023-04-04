using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using YoutubeViewers.WPF.Commands;
using YoutubeViewers.WPF.Models;
using YoutubeViewers.WPF.Stores;

namespace YoutubeViewers.WPF.ViewModels
{
    public class EditYoutubeViewerViewModel : ViewModelBase
    {

        public Guid YoutubeViewerId { get; }
        public YoutubeViewerDetailsFormViewModel YoutubeViewerDetailsFormViewModel { get; }

        public EditYoutubeViewerViewModel(YoutubeViewer youtubeViewer, YoutubeViewersStore youtubeViewersStore, ModalNavigationStore modalNavigationStore)
        {
            ICommand submitCommand = new EditYoutubeViewerCommand(this, youtubeViewersStore, modalNavigationStore);
            ICommand cancelCommand = new CloseModalCommand(modalNavigationStore);
            YoutubeViewerDetailsFormViewModel = new YoutubeViewerDetailsFormViewModel(submitCommand, cancelCommand)
            {
                Username = youtubeViewer.Username,
                IsSubscribed = youtubeViewer.IsSubscribed,
                IsMember = youtubeViewer.IsMember
            };
        }
    }
}
