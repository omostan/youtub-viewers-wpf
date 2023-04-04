using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using YoutubeViewers.WPF.Commands;
using YoutubeViewers.WPF.Stores;

namespace YoutubeViewers.WPF.ViewModels
{
    public class AddYoutubeViewerViewModel : ViewModelBase
    {   
        public YoutubeViewerDetailsFormViewModel YoutubeViewerDetailsFormViewModel { get; }

        public AddYoutubeViewerViewModel(ModalNavigationStore modalNavigationStore)
        {
            ICommand submitCommand = AddYoutubeViewerCommand;
            ICommand cancelCommand = new CloseModalCommand(modalNavigationStore);
            YoutubeViewerDetailsFormViewModel = new YoutubeViewerDetailsFormViewModel(submitCommand, cancelCommand);
        }
    }
}
