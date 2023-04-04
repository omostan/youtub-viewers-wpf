using System.Windows;
using YoutubeViewers.WPF.ViewModels;

namespace YoutubeViewers.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly SelectedYoutubeViewerStore se

        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new YoutubeViewersViewModel()
            };
            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
