﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using YoutubeViewers.WPF.Commands;
using YoutubeViewers.WPF.Stores;

namespace YoutubeViewers.WPF.ViewModels
{
    public class EditYoutubeViewerViewModel : ViewModelBase
    {
        public YoutubeViewerDetailsFormViewModel YoutubeViewerDetailsFormViewModel { get; }

        public EditYoutubeViewerViewModel(YoutubeViewer youtubeViewer, ModalNavigationStore modalNavigationStore)
        {
            ICommand cancelCommand = new CloseModalCommand(modalNavigationStore);
            YoutubeViewerDetailsFormViewModel = new YoutubeViewerDetailsFormViewModel(null, cancelCommand);
        }
    }
}
