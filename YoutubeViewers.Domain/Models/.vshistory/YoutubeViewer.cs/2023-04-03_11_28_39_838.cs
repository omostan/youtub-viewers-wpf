using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeViewers.WPF.Models
{
    public class YoutubeViewer
    {
        public Guid Id { get; }

        public string Username { get; }

        public bool IsSubscribed { get; }

        public bool IsMember { get; }

        public YoutubeViewer(Guid Id, string username, bool isSubscribed, bool isMember)
        {
            Username = username;
            IsSubscribed = isSubscribed;
            IsMember = isMember;
        }
    }
}
