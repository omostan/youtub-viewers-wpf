﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace YoutubeViewers.WPF.ViewModels
{
    public class YoutubeViewersListingItemViewModel : ViewModelBase
    {
        public YoutubeViewersListingItemViewModel(string username)
        {
            Username = username;
        }

        public string Username { get; }

        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }
    }
}
