using System.Windows;
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
        private readonly SelectedYoutubeViewerStore _selectedYoutubeViewerStore;

        public App()
        {
            _modalNavigationStore = new ModalNavigationStore();
            _selectedYoutubeViewerStore = new SelectedYoutubeViewerStore();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_mo new YoutubeViewersViewModel(_selectedYoutubeViewerStore)
            };
            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
