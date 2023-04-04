﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using YoutubeViewers.WPF.Models;

namespace YoutubeViewers.WPF.ViewModels
{
    public class YoutubeViewersListingItemViewModel : ViewModelBase
    {
        public YoutubeViewer YoutubeViewer { get; }

        public YoutubeViewersListingItemViewModel(YoutubeViewer youtubeViewer)
        {
            YoutubeViewer = youtubeViewer;
        }

        public string Username => YoutubeViewer.Username;

        public ICommand? EditCommand { get; }

        public ICommand? DeleteCommand { get; }
    }
}
