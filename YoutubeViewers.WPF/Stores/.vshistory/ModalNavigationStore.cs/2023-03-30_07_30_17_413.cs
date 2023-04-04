﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeViewers.WPF.ViewModels;

namespace YoutubeViewers.WPF.Stores
{
    public class ModalNavigationStore
    {

		private ViewModelBase _currentViewModel;

		public ViewModelBase CurrentViewModel
        {
			get
			{
				return _currentViewModel;
			}
			set
			{
                _currentViewModel = value;
			}
		}
    }
}
