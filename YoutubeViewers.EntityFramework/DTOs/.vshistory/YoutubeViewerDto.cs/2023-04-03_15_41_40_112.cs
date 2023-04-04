﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeViewers.EntityFramework.Dtos
{
    public class YoutubeViewerDto
    {
        [Key]
        public Guid Id { get; set;  }

        public string Username { get; set; }

        public bool IsSubscribed { get; set; }

        public bool IsMember { get; set; }
    }
}
