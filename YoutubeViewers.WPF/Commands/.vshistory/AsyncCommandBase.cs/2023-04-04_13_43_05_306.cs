using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeViewers.WPF.Commands
{
    public abstract class AsyncCommandBase : CommandBase
    {

        private int myVar;

        public int MyProperty
        {
            get
            {
                return myVar;
            }
            set
            {
                myVar = value;
                OnPropertyChanged(nameof(MyProperty));
            }
        }

        public override async void Execute(object? parameter)
        {
            try
            {
                await ExecuteAsync(parameter);
            }
            catch (Exception) { }            
        }

        public abstract Task ExecuteAsync(object parameter);
    }
}
