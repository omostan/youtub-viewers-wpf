using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeViewers.WPF.Stores
{
    public class SelectedYoutubeViewerStore
    {
		private YoutubeViewer myVar;

		public YoutubeViewer MyProperty
		{
			get { return myVar; }
			set { myVar = value; }
		}

	}
}
