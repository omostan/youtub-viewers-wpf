﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeViewers.WPF.Stores
{
    public class SelectedYoutubeViewerStore
    {
		private YoutubeViewer _selectedYoutubeViewer;

		public YoutubeViewer YoutubeViewer
		{
			get { return _youtubeViewer; }
			set { _youtubeViewer = value; }
		}

	}
}
