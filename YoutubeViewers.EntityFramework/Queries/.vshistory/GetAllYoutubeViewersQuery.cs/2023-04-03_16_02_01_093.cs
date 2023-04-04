using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeViewers.Domain.Models;
using YoutubeViewers.Domain.Queries;

namespace YoutubeViewers.EntityFramework.Queries
{
    public class GetAllYoutubeViewersQuery : IGetAllYoutubeViewersQuery
    {
        public Task<IEnumerable<YoutubeViewer>> Execute()
        {
            throw new NotImplementedException();
        }
    }
}
