using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace YoutubeViewers.WPF.ViewModels
{
    public class AddYoutubeViewerViewModel : ViewModelBase
    {   
        public YoutubeViewerDetailsFormViewModel YoutubeViewerDetailsFormViewModel { get; }

        public AddYoutubeViewerViewModel()
        {
            YoutubeViewerDetailsFormViewModel = new YoutubeViewerDetailsFormViewModel(null, cancelCommand);
        }
    }
}
