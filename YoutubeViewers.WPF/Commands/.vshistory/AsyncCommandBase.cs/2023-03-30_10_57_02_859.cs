using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeViewers.WPF.Commands
{
    public abstract class AsyncCommandBase : CommandBase
    {
        public override async void Execute(object? parameter)
        {
            await ExecuteAsync(parameter);
        }

        public abstract Task ExecuteAsync(object parameter);
    }
}
