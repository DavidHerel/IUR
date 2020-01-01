using Satnik.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satnik.ViewModels
{
    public class ObleceniCustomCardViewModel:ViewModelBase
    {

        public ObleceniCustomCardViewModel(MainViewModel mainViewModelReference, string druh, string barva, string kategorie)
        {
            _mainViewModelReference = mainViewModelReference;
            Druh = druh;
            Barva = barva;
            Kategorie = kategorie;
        }

        private RelayCommand _removeCityCommand;
        private MainViewModel _mainViewModelReference;
        private string _druh;
        private string _barva;
        private string _kategorie;

        public string Druh { get { return _druh; } set { _druh = value; OnPropertyChanged(); } }

        public string Barva { get { return _barva; } set { _barva = value; OnPropertyChanged(); } }


        public string Kategorie { get { return _kategorie; } set { _kategorie = value; OnPropertyChanged(); } }

        public RelayCommand DeleteCity
        {
            get
            {
                return _removeCityCommand ?? (_removeCityCommand = new RelayCommand(DeleteCityItem));
            }
        }

        private void DeleteCityItem(object obj)
        {
            _mainViewModelReference.ObleceniCards.Remove(this);
        }

    }
}
