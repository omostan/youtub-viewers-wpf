using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeViewers.WPF.ViewModels
{
    public class YoutubeViewersListingViewModel : ViewModelBase
    {
        private readonly ObservableCollection<YoutubeViewersListingItemViewModel> _YoutubeViewersListingItemViewModels

        public IEnumerable<YoutubeViewersListingItemViewModel> YoutubeViewersListingItemViewModels { get; }
    }
}
