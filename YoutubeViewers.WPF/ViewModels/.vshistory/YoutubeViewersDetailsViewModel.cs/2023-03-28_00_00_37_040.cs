﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeViewers.WPF.Stores;

namespace YoutubeViewers.WPF.ViewModels
{
    public class YoutubeViewersDetailsViewModel : ViewModelBase
    {
        private readonly SelectedYoutubeViewerStore _selectedYoutubeViewerStore;

        private YoutubeViewer SelectedYoutubeViewer = _selectedYoutubeViewerStore.SelectedYoutubeViewer;

        public string Username => _selectedYoutubeViewerStore.SelectedYoutubeViewer?.Username;
        public string IsSubscribedDisplay => _selectedYoutubeViewerStore.SelectedYoutubeViewer?.IsSubscribedDisplay;
        public string IsMemberDisplay => _selectedYoutubeViewerStore.SelectedYoutubeViewer?.IsMemberDisplay;

        public YoutubeViewersDetailsViewModel(SelectedYoutubeViewerStore selectedYoutubeViewerStore)
        {
            _selectedYoutubeViewerStore = selectedYoutubeViewerStore;
        }
    }
}
