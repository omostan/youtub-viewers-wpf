using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeViewers.WPF.Commands
{
    public abstract class AsyncCommandBase : CommandBase
    {

        private bool _isExecuting;

        public bool IsExecuting
        {
            get
            {
                return _isExecuting;
            }
            set
            {
                _isExecuting = value;
            }
        }

        public override async void Execute(object? parameter)
        {
            IsExecuting = true;

            try
            {
                await ExecuteAsync(parameter);
            }
            catch (Exception) { }            
        }

        public abstract Task ExecuteAsync(object parameter);
    }
}
