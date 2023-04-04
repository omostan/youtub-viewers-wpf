using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace YoutubeViewers.WPF.ViewModels
{
    public class YoutubeViewersViewModel : ViewModelBase
    {
        public YoutubeViewersViewModel() { }

        public YoutubeViewersListingViewModel YoutubeViewersListingViewModel { get; }

        public ICommand AddYoutubeViewersCommand { get; }
    }
}
