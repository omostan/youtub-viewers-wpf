using System;
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
        private YoutubeViewer _youtubeViewer;

        public YoutubeViewersListingItemViewModel(string username)
        {
            Username = username;
        }

        public YoutubeViewersListingItemViewModel(YoutubeViewer youtubeViewer)
        {
            this._youtubeViewer = youtubeViewer;
        }

        public string Username { get; }

        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }
    }
}
