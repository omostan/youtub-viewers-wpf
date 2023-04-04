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
        public YoutubeViewersListingViewModel YoutubeViewersListingViewModel { get; }

        public YoutubeViewersDetailsViewModel YoutubeViewersDetailsViewModel { get; }

        public ICommand AddYoutubeViewersCommand { get; }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public YoutubeViewersViewModel()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            YoutubeViewersListingViewModel = new YoutubeViewersListingViewModel();
            YoutubeViewersDetailsViewModel = new YoutubeViewersDetailsViewModel();
        }
    }
}
