using System.Windows;
using YoutubeViewers.Domain.Commands;
using YoutubeViewers.Domain.Queries;
using YoutubeViewers.EntityFramework.Commands;
using YoutubeViewers.EntityFramework.Queries;
using YoutubeViewers.WPF.Stores;
using YoutubeViewers.WPF.ViewModels;

namespace YoutubeViewers.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly ModalNavigationStore _modalNavigationStore;
        private readonly 

        private readonly IGetAllYoutubeViewersQuery _getAllYoutubeViewersQuery;
        private readonly ICreateYoutubeViewerCommand _createYoutubeViewerCommand;
        private readonly IUpdateYoutubeViewerCommand _updateYoutubeViewerCommand;
        private readonly IDeleteYoutubeViewerCommand _deleteYoutubeViewerCommand;

        private readonly YoutubeViewersStore _youtubeViewersStore;
        private readonly SelectedYoutubeViewerStore _selectedYoutubeViewerStore;

        public App()
        {
            _modalNavigationStore = new ModalNavigationStore();
            _getAllYoutubeViewersQuery = new GetAllYoutubeViewersQuery();
            _createYoutubeViewerCommand = new CreateYoutubeViewerCommand();
            _updateYoutubeViewerCommand = new UpdateYoutubeViewerCommand();
            _deleteYoutubeViewerCommand = new DeleteYoutubeViewerCommand();
            _youtubeViewersStore = new YoutubeViewersStore(_getAllYoutubeViewersQuery, _createYoutubeViewerCommand, _updateYoutubeViewerCommand, _deleteYoutubeViewerCommand);
            _selectedYoutubeViewerStore = new SelectedYoutubeViewerStore(_youtubeViewersStore);
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            YoutubeViewersViewModel youtubeViewersViewModel = new YoutubeViewersViewModel(
                _youtubeViewersStore, _selectedYoutubeViewerStore, _modalNavigationStore
            );

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_modalNavigationStore, youtubeViewersViewModel)
            };
            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
