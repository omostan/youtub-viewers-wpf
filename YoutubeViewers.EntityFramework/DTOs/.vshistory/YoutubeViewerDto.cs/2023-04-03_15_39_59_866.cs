using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeViewers.EntityFramework.Dtos
{
    public class YoutubeViewerDto
    {
        public Guid Id { get; }

        public string Username { get; }

        public bool IsSubscribed { get; }

        public bool IsMember { get; }
    }
}
