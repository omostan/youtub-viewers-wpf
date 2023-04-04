using Microsoft.Extensions.Configuration;
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
        private readonly IConfiguration _config;

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

		public YoutubeViewerDetailsFormViewModel(IConfiguration config)
		{
            _config = config;
        }

		public void OnGet()
		{
			_config.GetValue
		}

	}
}
