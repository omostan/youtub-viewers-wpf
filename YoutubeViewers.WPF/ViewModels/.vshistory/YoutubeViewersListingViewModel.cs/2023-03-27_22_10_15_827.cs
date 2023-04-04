using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeViewers.WPF.ViewModels
{
    public class YoutubeViewersListingViewModel : ViewModelBase
    {
        private re YoutubeViewersListingViewModel() { }

        public IEnumerable<YoutubeViewersListingItemViewModel> YoutubeViewersListingItemViewModels { get; }
    }
}
