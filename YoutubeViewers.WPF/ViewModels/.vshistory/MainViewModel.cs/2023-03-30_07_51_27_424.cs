﻿using System;
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

        public ViewModelBase CurrentModalViewModel => 

        public YoutubeViewersViewModel YoutubeViewersViewModel { get; }

        public MainViewModel(ModalNavigationStore modalNavigationStore, YoutubeViewersViewModel youtubeViewersViewModel)
        {
            _modalNavigationStore = modalNavigationStore;
            YoutubeViewersViewModel = youtubeViewersViewModel;
        }
    }
}
