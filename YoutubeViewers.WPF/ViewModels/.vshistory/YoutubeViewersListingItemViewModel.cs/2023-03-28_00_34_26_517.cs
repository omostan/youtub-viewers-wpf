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
        private readonly YoutubeViewer _youtubeViewer;

        public YoutubeViewersListingItemViewModel(YoutubeViewer youtubeViewer)
        {
            _youtubeViewer = youtubeViewer;
        }

        public string Username { get; }

        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }
    }
}
