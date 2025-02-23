using AutoMapper;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ZooKitchen.Application.Contracts.Services;
using ZooKitchen.Infrastructure.Contracts.Services;
using ZooKitchen.WPF.ViewModels;

namespace ZooKitchen.WPF;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private readonly IAnimalService _animalService;
    private readonly IMapper _mapper;

    public MainWindow(IAnimalService animalService, IMapper mapper)
    {
        _animalService = animalService;
        _mapper = mapper;

        DataContext = new MainViewModel(animalService, mapper);
        InitializeComponent();
    }
}