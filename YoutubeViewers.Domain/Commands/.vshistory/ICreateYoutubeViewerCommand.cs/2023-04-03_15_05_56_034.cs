using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeViewers.Domain.Commands
{
    public interface ICreateYoutubeViewerCommand
    {
        Task Execute(YoutubeViewers youtubeViewers);
    }
}
