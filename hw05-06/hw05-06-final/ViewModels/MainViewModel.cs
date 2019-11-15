using IUR_p07.Support;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUR_p07
{
    public class MainViewModel : ViewModelBase
    {
        public ObservableCollection<WeatherCardViewModel> WeatherCards { get; set; } = new ObservableCollection<WeatherCardViewModel>();
        private RelayCommand _addCityCommand;
        private string _cityToBeAdded;


        public MainViewModel()
        {

            WeatherNet.ClientSettings.ApiUrl = "http://api.openweathermap.org/data/2.5/";
            WeatherNet.ClientSettings.ApiKey = "1bdfdfbac52feb077781c6b5ccaa3b31";

            WeatherCards.Add(new WeatherCardViewModel(this, "Praha"));
            WeatherCards.Add(new WeatherCardViewModel(this, "Brno"));
            WeatherCards.Add(new WeatherCardViewModel(this, "Ostrava"));
            WeatherCards.Add(new WeatherCardViewModel(this, "Jihlava"));
            WeatherCards.Add(new WeatherCardViewModel(this, "Rakovník"));

        }

        public RelayCommand AddCity
        {
            get
            {
                return _addCityCommand ?? (_addCityCommand = new RelayCommand(AddCityItem));
            }
        }

        private void AddCityItem(object obj)
        {
            WeatherCards.Add(new WeatherCardViewModel(this, _cityToBeAdded));
        }

        public string CityToBeAdded
        {
            get { return _cityToBeAdded; }
            set
            {
                _cityToBeAdded = value;
                OnPropertyChanged("CityToBeAdded");
            }
        }
    }
}

