using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeViewers.WPF.Stores;

namespace YoutubeViewers.WPF.ViewModels
{
    public class YoutubeViewersListingViewModel : ViewModelBase
    {
        private readonly ObservableCollection<YoutubeViewersListingItemViewModel> _youtubeViewersListingItemViewModels;

        public IEnumerable<YoutubeViewersListingItemViewModel> YoutubeViewersListingItemViewModels => _youtubeViewersListingItemViewModels;

        private YoutubeViewersListingItemViewModel myVar;

        public YoutubeViewersListingItemViewModel MyProperty
        {
            get
            {
                return myVar;
            }
            set
            {
                myVar = value;
                OnePropertyChanged(nameof(MyProperty);
            }
        }


        public YoutubeViewersListingViewModel(SelectedYoutubeViewerStore _selectedYoutubeViewerStore)
        {
            _youtubeViewersListingItemViewModels = new ObservableCollection<YoutubeViewersListingItemViewModel>
            {
                new YoutubeViewersListingItemViewModel("Mary"),
                new YoutubeViewersListingItemViewModel("Sean"),
                new YoutubeViewersListingItemViewModel("Alan")
            };
        }
    }
}
