using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeViewers.WPF.ViewModels
{
    public class YoutubeViewersDetailsViewModel : ViewModelBase
    {
        public string Username { get; }
        public string IsSubscribedDisplay { get; }
        public string IsMemberDisplay { get; }
    }
}
