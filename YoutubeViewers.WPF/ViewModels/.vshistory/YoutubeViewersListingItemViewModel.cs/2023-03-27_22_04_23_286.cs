using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace YoutubeViewers.WPF.ViewModels
{
    public class YoutubeViewersListingItemViewModel : ViewModelBase
    {
        public string Username { get; }

        public ICommand Edit { get; }
        public ICommand Delete { get; }
    }
}
