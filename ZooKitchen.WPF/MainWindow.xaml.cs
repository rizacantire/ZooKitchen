using Microsoft.Extensions.DependencyInjection;
using ZooKitchen.WPF.ViewModels;
using System.Windows;

namespace ZooKitchen.WPF;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow(MainViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }
}