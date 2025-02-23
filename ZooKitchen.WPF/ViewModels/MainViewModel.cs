using AutoMapper;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using ZooKitchen.Application.Contracts.Services;
using ZooKitchen.Domain.Entities;

namespace ZooKitchen.WPF.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        private readonly IAnimalService _animalService;

        [ObservableProperty]
        private ObservableCollection<Animal> animals = new ObservableCollection<Animal>(); // Initialize here to avoid CS8618
        private readonly IMapper _mapper;

        public MainViewModel(IAnimalService animalService, IMapper mapper)
        {
            _animalService = animalService;
            _mapper = mapper;
            LoadAnimalsCommand.Execute(null); // Uygulama başladığında LoadAnimals çalışsın
            LoadAnimals();
        }

        [RelayCommand]
        private async Task LoadAnimals()
        {
            var animalList = await _animalService.GetAllAsync();
            Animals = new ObservableCollection<Animal>(animalList);
        }
    }
}
