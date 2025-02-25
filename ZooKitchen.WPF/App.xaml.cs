using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Data;
using System.Windows;
using ZooKitchen.Application.Contracts.Repositories;
using ZooKitchen.Infrastructure.Contracts.Repositories;
using ZooKitchen.Infrastructure.Contracts.Services;
using ZooKitchen.Infrastructure.Persistence;
using ZooKitchen.WPF.ViewModels;

namespace ZooKitchen.WPF;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : System.Windows.Application
{
    private readonly ServiceProvider _serviceProvider;
    public App()
    {
        var services = new ServiceCollection();

        services.AddDbContext<SiteContext>(options =>
                        options.UseSqlite("Data Source = ..//productTracking.db"));

        // Bağımlılıkları kaydet
        services.AddSingleton<IAnimalRepository, AnimalRepository>();
        services.AddSingleton<AnimalService>();
        services.AddSingleton<MainWindow>();

        services.AddSingleton<MainViewModel>();
        services.AddSingleton<MainWindow>();

        _serviceProvider = services.BuildServiceProvider();
    }

    protected override void OnStartup(StartupEventArgs e)
    {
        var mainWindow = _serviceProvider.GetRequiredService<MainWindow>();
        mainWindow.Show();
    }
}

