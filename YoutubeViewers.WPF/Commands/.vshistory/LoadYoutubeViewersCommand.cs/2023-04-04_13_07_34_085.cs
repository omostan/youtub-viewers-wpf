﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeViewers.WPF.Stores;
using YoutubeViewers.WPF.ViewModels;

namespace YoutubeViewers.WPF.Commands
{
    public class LoadYoutubeViewersCommand : AsyncCommandBase
    {
        private readonly YoutubeViewersViewModel _youtubeViewersViewModel;
        private readonly YoutubeViewersStore _youtubeViewersStore;

        public LoadYoutubeViewersCommand(ViewModels.YoutubeViewersViewModel youtubeViewersViewModel, YoutubeViewersStore youtubeViewersStore)
        {
            this.youtubeViewersViewModel = youtubeViewersViewModel;
            _youtubeViewersStore = youtubeViewersStore;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            try
            {
                await _youtubeViewersStore.Load();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
