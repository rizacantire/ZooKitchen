using AutoMapper;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooKitchen.Domain.Entities;
using ZooKitchen.Infrastructure.Contracts.Services;

namespace ZooKitchen.WPF.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private readonly AnimalService _animalService;


        public ObservableCollection<Animal> Animals { get; set; }

        public MainViewModel(AnimalService animalService)
        {
            _animalService = animalService;
     
            Animals = new ObservableCollection<Animal>();
            LoadAnimals();
        }

        private async void LoadAnimals()
        {
            var animals = await _animalService.GetAllAsync();
            foreach (var animal in animals)
            {
                Animals.Add(animal);
            }
            OnPropertyChanged(nameof(Animals));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
