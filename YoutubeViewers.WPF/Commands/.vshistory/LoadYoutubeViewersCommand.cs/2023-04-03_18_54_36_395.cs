using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeViewers.WPF.Stores;

namespace YoutubeViewers.WPF.Commands
{
    public class LoadYoutubeViewersCommand : AsyncCommandBase
    {
        private readonly YoutubeViewersStore _youtubeViewersStore;

        public override Task ExecuteAsync(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}
