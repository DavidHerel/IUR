using IUR_p07.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherNet.Model;

namespace IUR_p07
{
    /// <summary>
    /// Needs to be extended to work properly
    /// </summary>
    public class WeatherCardViewModel:ViewModelBase
    {
        public WeatherCardViewModel(MainViewModel mainViewModelReference, string location)
        {
            _mainViewModelReference = mainViewModelReference;
            Location = location;
            CurrentWeatherResult currentWeather = WeatherNet.Clients.CurrentWeather.GetByCityName(Location, "czechia", "en", "metric").Item;
            Temperature = currentWeather.Temp;
            Humidity = currentWeather.Humidity;
            IconPath = currentWeather.Icon;
            Conditions = currentWeather.Description;
            

        }

        private RelayCommand _removeCityCommand;
        private MainViewModel _mainViewModelReference;
        private string _location;
        private double _temperature;
        private double _humidity;
        private string _conditions;
        private string _iconPath;

        public double Temperature { get { return _temperature; } set { _temperature = value; OnPropertyChanged(); } }
        public double Humidity { get { return _humidity; } set { _humidity = value; OnPropertyChanged(); } }
        public string Conditions { get { return _conditions; } set { _conditions = value; OnPropertyChanged(); } }
        public string IconPath { get { return _iconPath; } set { _iconPath = value; OnPropertyChanged(); } }

       
        public string Location
        {
            get => _location;
            set
            {
                _location = value;
                CurrentWeatherResult currentWeather = WeatherNet.Clients.CurrentWeather.GetByCityName(_location, "czechia", "en", "metric").Item;
                Temperature = currentWeather.Temp;
                Humidity = currentWeather.Humidity;
                IconPath = currentWeather.Icon;
                Conditions = currentWeather.Description;
                OnPropertyChanged();
            }
        }

        public RelayCommand DeleteCity
        {
            get
            {
                return _removeCityCommand ?? (_removeCityCommand = new RelayCommand(DeleteCityItem));
            }
        }

        private void DeleteCityItem(object obj)
        {
            _mainViewModelReference.WeatherCards.Remove(this);
        }

    }
}
