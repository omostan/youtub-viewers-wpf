using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeViewers.WPF.Stores;

namespace YoutubeViewers.WPF.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly ModalNavigationStore _modalNavigationStore;

        public ViewModelBase CurrentModalViewModel => _modalNavigationStore.CurrentViewModel;

        public bool IsModalOpen => _modalNavigationStore.IsOpen;

        public YoutubeViewersViewModel YoutubeViewersViewModel { get; }

        public MainViewModel(ModalNavigationStore modalNavigationStore, YoutubeViewersViewModel youtubeViewersViewModel)
        {
            _modalNavigationStore = modalNavigationStore;
            YoutubeViewersViewModel = youtubeViewersViewModel;

            _modalNavigationStore.CurrentViewModelChanged += _modalNavigationStore_CurrentViewModelChanged;

            _modalNavigationStore.CurrentViewModel
        }

        protected override void Dispose()
        {
            _modalNavigationStore.CurrentViewModelChanged += _modalNavigationStore_CurrentViewModelChanged;

            base.Dispose();
        }

        private void _modalNavigationStore_CurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentModalViewModel));
            OnPropertyChanged(nameof(IsModalOpen));
        }
    }
}
