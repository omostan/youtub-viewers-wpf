using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using YoutubeViewers.WPF.Commands;
using YoutubeViewers.WPF.Models;
using YoutubeViewers.WPF.Stores;

namespace YoutubeViewers.WPF.ViewModels
{
    public class YoutubeViewersListingViewModel : ViewModelBase
    {
        private readonly YoutubeViewersStore _youtubeViewersStore;
        private readonly SelectedYoutubeViewerStore _selectedYoutubeViewerStore;
        private readonly ModalNavigationStore modalNavigationStore;
        private readonly ObservableCollection<YoutubeViewersListingItemViewModel> _youtubeViewersListingItemViewModels;
        public IEnumerable<YoutubeViewersListingItemViewModel> YoutubeViewersListingItemViewModels => _youtubeViewersListingItemViewModels;

        private YoutubeViewersListingItemViewModel _selectedYoutubeViewerListingItemViewModel;

        public YoutubeViewersListingItemViewModel SelectedYoutubeViewerListingItemViewModel
        {
            get
            {
                return _selectedYoutubeViewerListingItemViewModel;
            }
            set
            {
                _selectedYoutubeViewerListingItemViewModel = value;
                OnPropertyChanged(nameof(SelectedYoutubeViewerListingItemViewModel));

                _selectedYoutubeViewerStore.SelectedYoutubeViewer = _selectedYoutubeViewerListingItemViewModel.YoutubeViewer;
            }
        }


        public YoutubeViewersListingViewModel(YoutubeViewersStore youtubeViewersStore, SelectedYoutubeViewerStore selectedYoutubeViewerStore, ModalNavigationStore modalNavigationStore)
        {
            _youtubeViewersStore = youtubeViewersStore;
            _selectedYoutubeViewerStore = selectedYoutubeViewerStore;
            this.modalNavigationStore = modalNavigationStore;
            _youtubeViewersListingItemViewModels = new ObservableCollection<YoutubeViewersListingItemViewModel>();

            _youtubeViewersStore.YoutubeViewerAdded += YoutubeViewersStore_YoutubeViewerAdded;

            AddYoutubeViewer(new YoutubeViewer("Mary", true, false), modalNavigationStore);
            AddYoutubeViewer(new YoutubeViewer("Sean", false, false), modalNavigationStore);
            AddYoutubeViewer(new YoutubeViewer("Alan", true, true), modalNavigationStore);
        }

        protected override void Dispose()
        {
            _youtubeViewersStore.YoutubeViewerAdded -= YoutubeViewersStore_YoutubeViewerAdded;
            base.Dispose();
        }

        private void YoutubeViewersStore_YoutubeViewerAdded(YoutubeViewer youtubeviewer, ModalNavigationStore modalNavigationStore)
        {
            AddYoutubeViewer(youtubeviewer, modalNavigationStore);
        }

        private void AddYoutubeViewer(YoutubeViewer youtubeviewer, ModalNavigationStore modalNavigationStore)
        {
            ICommand editCommand = new OpenEditYoutubeViewerCommand(youtubeviewer, modalNavigationStore);
            _youtubeViewersListingItemViewModels.Add(new YoutubeViewersListingItemViewModel(youtubeviewer, editCommand));
        }
    }
}
