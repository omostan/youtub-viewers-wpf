﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using YoutubeViewers.WPF.Commands;
using YoutubeViewers.Domain.Models;
using YoutubeViewers.WPF.Stores;

namespace YoutubeViewers.WPF.ViewModels
{
    public class YoutubeViewersListingItemViewModel : ViewModelBase
    {
        private YoutubeViewersStore _youtubeViewersStore;
        private ModalNavigationStore _modalNavigationStore;

        public YoutubeViewer? YoutubeViewer { get; private set; }

        public string? Username => YoutubeViewer?.Username;


        private bool _isDeleting;

        public bool IsDeleting
        {
            get
            {
                return _isDeleting;
            }
            set
            {
                _isDeleting = value;
                OnPropertyChanged(nameof(IsDeleting));
            }
        }

        private string _errorMessage;

        public string ErrorMessage
        {
            get
            {
                return _errorMessage;
            }
            set
            {
                _errorMessage = value;
                OnPropertyChanged(nameof(ErrorMessage));
                OnPropertyChanged(nameof(HasErrorMessage));
            }
        }

        public bool HasErrorMessage => !string.IsNullOrEmpty(ErrorMessage);

        public ICommand? EditCommand { get; }

        public ICommand? DeleteCommand { get; }

        public YoutubeViewersListingItemViewModel(YoutubeViewer youtubeviewer, YoutubeViewersStore youtubeViewersStore, ModalNavigationStore modalNavigationStore)
        {
            YoutubeViewer = youtubeviewer;

            EditCommand = new OpenEditYoutubeViewerCommand(this, youtubeViewersStore, modalNavigationStore);
            DeleteCommand = new DeleteYoutubeViewerCommand(this, youtubeViewersStore);
        }

        public void Update(YoutubeViewer youtubeviewer)
        {
            YoutubeViewer = youtubeviewer;

            OnPropertyChanged(nameof(Username));
        }
    }
}
