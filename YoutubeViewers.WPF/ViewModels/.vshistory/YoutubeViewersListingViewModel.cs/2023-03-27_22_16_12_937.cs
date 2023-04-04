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
        private readonly ObservableCollection<YoutubeViewersListingItemViewModel> _youtubeViewersListingItemViewModels;

        public IEnumerable<YoutubeViewersListingItemViewModel> YoutubeViewersListingItemViewModels => _youtubeViewersListingItemViewModels;

        public YoutubeViewersListingViewModel()
        {
            _youtubeViewersListingItemViewModels = new ObservableCollection<YoutubeViewersListingItemViewModel>();

            _youtubeViewersListingItemViewModels
        }
    }
}
