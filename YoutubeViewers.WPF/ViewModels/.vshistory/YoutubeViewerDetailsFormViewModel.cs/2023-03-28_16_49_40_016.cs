using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * Title:
 * Author:
 * Date:
 * Purpose:
 */
namespace YoutubeViewers.WPF.ViewModels
{
    public class YoutubeViewerDetailsFormViewModel : ViewModelBase
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

	}
}
