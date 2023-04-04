using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeViewers.WPF.Stores
{
    public class ModalNavigationStore
    {

		private ViewModelBase myVar;

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
    }
}
