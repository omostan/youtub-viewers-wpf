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

                    services.AddSingleton<ModalNavigationStore>();
                    services.AddSingleton<YoutubeViewersStore>();
                    services.AddSingleton<SelectedYoutubeViewerStore>();
                })
                .Build();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            _host.Start();

            YoutubeViewersDbContextFactory? youtubeViewersDbContextFactory = _host.Services.GetRequiredService<YoutubeViewersDbContextFactory>();

            using (YoutubeViewersDbContext context = youtubeViewersDbContextFactory.Create())
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

            MainWindow = _host.Services.GetRequiredService<MainWindow>();
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
