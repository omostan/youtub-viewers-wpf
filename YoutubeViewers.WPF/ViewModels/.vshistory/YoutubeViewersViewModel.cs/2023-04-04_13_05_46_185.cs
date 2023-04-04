using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using YoutubeViewers.WPF.Commands;
using YoutubeViewers.WPF.Stores;

namespace YoutubeViewers.WPF.ViewModels
{
    public class YoutubeViewersViewModel : ViewModelBase
    {
        public YoutubeViewersListingViewModel YoutubeViewersListingViewModel { get; }
        public YoutubeViewersDetailsViewModel YoutubeViewersDetailsViewModel { get; }


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

        public ICommand AddYoutubeViewersCommand { get; }
        public ICommand LoadYoutubeViewersCommand { get; }

        public YoutubeViewersViewModel(YoutubeViewersStore youtubeViewersStore, SelectedYoutubeViewerStore selectedYoutubeViewerStore, ModalNavigationStore modalNavigationStore)
        {
            YoutubeViewersListingViewModel = new YoutubeViewersListingViewModel(youtubeViewersStore, selectedYoutubeViewerStore, modalNavigationStore);
            YoutubeViewersDetailsViewModel = new YoutubeViewersDetailsViewModel(selectedYoutubeViewerStore);

            LoadYoutubeViewersCommand = new LoadYoutubeViewersCommand(youtubeViewersStore);
            AddYoutubeViewersCommand = new OpenAddYoutubeViewerCommand(youtubeViewersStore, modalNavigationStore);
        }

        public static YoutubeViewersViewModel LoadViewModel(YoutubeViewersStore youtubeViewersStore, SelectedYoutubeViewerStore selectedYoutubeViewerStore, ModalNavigationStore modalNavigationStore)
        {
            YoutubeViewersViewModel viewModel = new YoutubeViewersViewModel(youtubeViewersStore, selectedYoutubeViewerStore, modalNavigationStore);

            viewModel.LoadYoutubeViewersCommand.Execute(null);

            return viewModel;
        }
    }
}
