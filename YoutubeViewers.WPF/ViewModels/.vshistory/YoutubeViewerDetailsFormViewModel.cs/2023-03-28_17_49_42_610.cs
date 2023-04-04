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

		private string _username;

		public string Username
		{
			get
			{
				return _username;
			}
			set
			{
				_username = value;
				OnPropertyChanged(nameof(Username));
			}
		}
	}
}
