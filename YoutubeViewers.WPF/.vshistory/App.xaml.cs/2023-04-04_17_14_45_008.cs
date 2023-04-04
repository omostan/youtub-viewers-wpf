using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Windows;
using YoutubeViewers.Domain.Commands;
using YoutubeViewers.Domain.Queries;
using YoutubeViewers.EntityFramework;
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
        private readonly YoutubeViewersDbContextFactory _youtubeViewersDbContextFactory;

        private readonly IGetAllYoutubeViewersQuery _getAllYoutubeViewersQuery;
        private readonly ICreateYoutubeViewerCommand _createYoutubeViewerCommand;
        private readonly IUpdateYoutubeViewerCommand _updateYoutubeViewerCommand;
        private readonly IDeleteYoutubeViewerCommand _deleteYoutubeViewerCommand;

        private readonly YoutubeViewersStore _youtubeViewersStore;
        private readonly SelectedYoutubeViewerStore _selectedYoutubeViewerStore;

        private readonly IHost _host;

        public App()
        {
            _host = Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {


                    string connectionString = "Data Source=YoutubeViewers.db";

                    DbContextOptions options = new DbContextOptionsBuilder().UseSqlite(connectionString).Options;
                    services.AddSingleton<DbContextOptions>(options);
                    services.AddSingleton<YoutubeViewersDbContextFactory>();

                    services.AddSingleton<GetAllYoutubeViewersQuery>();
                    services.AddSingleton<CreateYoutubeViewerCommand>();
                    services.AddSingleton<UpdateYoutubeViewerCommand>();
                    services.AddSingleton<DeleteYoutubeViewerCommand>();
                })
                .Build();

            _modalNavigationStore = new ModalNavigationStore();
            _youtubeViewersStore = new YoutubeViewersStore(
                _getAllYoutubeViewersQuery,
                _createYoutubeViewerCommand,
                _updateYoutubeViewerCommand,
                _deleteYoutubeViewerCommand);
            _selectedYoutubeViewerStore = new SelectedYoutubeViewerStore(_youtubeViewersStore);
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            _host.Start();

            using (YoutubeViewersDbContext context = _youtubeViewersDbContextFactory.Create())
            {
                context.Database.Migrate();
            }

            YoutubeViewersViewModel youtubeViewersViewModel = YoutubeViewersViewModel.LoadViewModel(
                _youtubeViewersStore, _selectedYoutubeViewerStore, _modalNavigationStore
            );

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_modalNavigationStore, youtubeViewersViewModel)
            };
            MainWindow.Show();

            base.OnStartup(e);
        }

        protected override void OnExit(ExitEventArgs e)
        {
            _host.StopAsync();
            _host.Dispose();

            base.OnExit(e);
        }
    }
}
