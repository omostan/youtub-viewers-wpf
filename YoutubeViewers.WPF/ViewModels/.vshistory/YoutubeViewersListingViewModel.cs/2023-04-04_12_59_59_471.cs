using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using YoutubeViewers.WPF.Commands;
using YoutubeViewers.Domain.Models;
using YoutubeViewers.WPF.Stores;

namespace YoutubeViewers.WPF.ViewModels
{
    public class YoutubeViewersListingViewModel : ViewModelBase
    {
        private readonly YoutubeViewersStore _youtubeViewersStore;
        private readonly SelectedYoutubeViewerStore _selectedYoutubeViewerStore;
        private readonly ModalNavigationStore _modalNavigationStore;
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

        //public ICommand LoadYoutubeViewersCommand { get; }


        public YoutubeViewersListingViewModel(YoutubeViewersStore youtubeViewersStore, SelectedYoutubeViewerStore selectedYoutubeViewerStore, ModalNavigationStore modalNavigationStore)
        {
            _youtubeViewersStore = youtubeViewersStore;
            _selectedYoutubeViewerStore = selectedYoutubeViewerStore;
            _modalNavigationStore = modalNavigationStore;
            _youtubeViewersListingItemViewModels = new ObservableCollection<YoutubeViewersListingItemViewModel>();

            _youtubeViewersStore.YoutubeViewerLoaded += YoutubeViewersStore_YoutubeViewerLoaded;
            _youtubeViewersStore.YoutubeViewerCreated += YoutubeViewersStore_YoutubeViewerCreated;
            _youtubeViewersStore.YoutubeViewerUpdated += YoutubeViewersStore_YoutubeViewerUpdated;
            _youtubeViewersStore.YoutubeViewerDeleted += YoutubeViewersStore_YoutubeViewerDeleted;
        }

        protected override void Dispose()
        {
            _youtubeViewersStore.YoutubeViewerLoaded -= YoutubeViewersStore_YoutubeViewerLoaded;
            _youtubeViewersStore.YoutubeViewerCreated -= YoutubeViewersStore_YoutubeViewerCreated;
            _youtubeViewersStore.YoutubeViewerUpdated -= YoutubeViewersStore_YoutubeViewerUpdated;
            _youtubeViewersStore.YoutubeViewerDeleted -= YoutubeViewersStore_YoutubeViewerDeleted;
            base.Dispose();
        }

        private void YoutubeViewersStore_YoutubeViewerLoaded()
        {
            _youtubeViewersListingItemViewModels.Clear();

            foreach (YoutubeViewer youtubeViewer in _youtubeViewersStore.YoutubeViewers)
            {
                CreateYoutubeViewer(youtubeViewer);
            }
        }

        private void YoutubeViewersStore_YoutubeViewerCreated(YoutubeViewer youtubeviewer)
        {
            CreateYoutubeViewer(youtubeviewer);
        }

        private void YoutubeViewersStore_YoutubeViewerUpdated(YoutubeViewer youtubeViewer)
        {
            YoutubeViewersListingItemViewModel? youtubeViewerViewModel = _youtubeViewersListingItemViewModels.FirstOrDefault(y => y.YoutubeViewer.Id == youtubeViewer.Id);

            if (youtubeViewerViewModel != null)
            {
                youtubeViewerViewModel.Update(youtubeViewer);
            }
            //UpdateYoutubeViewer(youtubeViewerViewModel);
        }

        private void YoutubeViewersStore_YoutubeViewerDeleted(Guid id)
        {
            var itemViewModel = _youtubeViewersListingItemViewModels.FirstOrDefault(x => x.YoutubeViewer.Id == id);

            if (itemViewModel != null)
            {
                _youtubeViewersListingItemViewModels.Remove(itemViewModel);
            }
        }

        private void CreateYoutubeViewer(YoutubeViewer youtubeviewer)
        {
            //ICommand editCommand = new OpenEditYoutubeViewerCommand(youtubeviewer, _modalNavigationStore);
            YoutubeViewersListingItemViewModel itemViewModel = new YoutubeViewersListingItemViewModel(youtubeviewer, _youtubeViewersStore, _modalNavigationStore);
            _youtubeViewersListingItemViewModels.Add(itemViewModel);
        }
    }
}
