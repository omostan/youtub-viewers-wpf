﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeViewers.Domain.Models;

namespace YoutubeViewers.Domain.Queries
{
    public internal interface IGetAllYoutubeViewersQuery
    {
        Task<IEnumerable<YoutubeViewer>> async
    }
}
