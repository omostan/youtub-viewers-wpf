﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
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


                    string connectionString = context.Configuration.GetConnectionString();

                    DbContextOptions options = new DbContextOptionsBuilder().UseSqlite(connectionString).Options;
                    services.AddSingleton<DbContextOptions>(options);
                    services.AddSingleton<YoutubeViewersDbContextFactory>();

                    services.AddSingleton<IGetAllYoutubeViewersQuery, GetAllYoutubeViewersQuery>();
                    services.AddSingleton<ICreateYoutubeViewerCommand, CreateYoutubeViewerCommand>();
                    services.AddSingleton<IUpdateYoutubeViewerCommand, UpdateYoutubeViewerCommand>();
                    services.AddSingleton<IDeleteYoutubeViewerCommand, DeleteYoutubeViewerCommand>();

                    services.AddSingleton<ModalNavigationStore>();
                    services.AddSingleton<YoutubeViewersStore>();
                    services.AddSingleton<SelectedYoutubeViewerStore>();


                    services.AddTransient<YoutubeViewersViewModel>(CreateYoutubeViewersViewModel);

                    services.AddSingleton<MainViewModel>();

                    services.AddSingleton<MainWindow>((services) => new MainWindow()
                    {
                        DataContext = services.GetRequiredService<MainViewModel>()
                    });
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

        private YoutubeViewersViewModel CreateYoutubeViewersViewModel(IServiceProvider services)
        {
            return YoutubeViewersViewModel.LoadViewModel(
                services.GetRequiredService<YoutubeViewersStore>(),
                services.GetRequiredService<SelectedYoutubeViewerStore>(),
                services.GetRequiredService<ModalNavigationStore>());
        }
    }
}
