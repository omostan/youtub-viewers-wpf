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
        public YoutubeViewer _youtubeViewer;

        public YoutubeViewersListingItemViewModel(YoutubeViewer youtubeViewer)
        {
            _youtubeViewer = youtubeViewer;
        }

        public string Username => _youtubeViewer.Username;

        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }
    }
}
