﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeViewers.WPF.Models;
using YoutubeViewers.WPF.Stores;

namespace YoutubeViewers.WPF.ViewModels
{
    public class YoutubeViewersListingViewModel : ViewModelBase
    {
        private readonly ObservableCollection<YoutubeViewersListingItemViewModel> _youtubeViewersListingItemViewModels;
        private readonly SelectedYoutubeViewerStore _selectedYoutubeViewerStore;

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


        public YoutubeViewersListingViewModel(SelectedYoutubeViewerStore selectedYoutubeViewerStore)
        {
            _selectedYoutubeViewerStore = selectedYoutubeViewerStore;

            _youtubeViewersListingItemViewModels = new ObservableCollection<YoutubeViewersListingItemViewModel>
            {
                new YoutubeViewersListingItemViewModel(new YoutubeViewer("Mary", true, false)),
                new YoutubeViewersListingItemViewModel(new YoutubeViewer("Sean", false, false)),
                new YoutubeViewersListingItemViewModel(new YoutubeViewer("Alan", true, true))
            };
        }

        private void AddYoutubeViewer(YoutubeViewer youtubeviewer)
    }
}
