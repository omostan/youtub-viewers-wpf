using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeViewers.WPF.ViewModels
{
    public class EditYoutubeViewerViewModel : ViewModelBase
    {
        public YoutubeViewerDetailsFormViewModel YoutubeViewerDetailsFormViewModel { get; }
        public EditYoutubeViewerViewModel(YoutubeViewerDetailsFormViewModel youtubeViewerDetailsFormViewModel)
        {
            YoutubeViewerDetailsFormViewModel = youtubeViewerDetailsFormViewModel;
        }
    }
}
