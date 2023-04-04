using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeViewers.WPF.ViewModels
{
    public class YoutubeViewersListingViewModel : ViewModelBase
    {
        public YoutubeViewersListingViewModel() { }

        public IEnumerable<YoutubeViewersListingItemViewModel> YoutubeViewersListingItemViewModels { get; }
    }
}
