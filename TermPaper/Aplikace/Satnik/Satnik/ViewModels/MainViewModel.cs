using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Satnik.Support;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Satnik.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public ObservableCollection<ObleceniCustomCardViewModel> ObleceniCards { get; set; } = new ObservableCollection<ObleceniCustomCardViewModel>();
        private string _PocetObleceni;
        private RelayCommand _addObleceniCommand;

        public MainViewModel()
        {
            //pridani obleceni
            BitmapImage logo = new BitmapImage();
            logo.BeginInit();
            logo.UriSource = new Uri(@"/Satnik;component/Images/cold2.png", UriKind.Relative);
            logo.EndInit();
            ObleceniCards.Add(new ObleceniCustomCardViewModel(this, "tricko", "zelena", "sportovni", logo));
            ObleceniCards.Add(new ObleceniCustomCardViewModel(this, "tricko", "zelena", "sportovni", logo));


            PocetObleceni = "Ve vaší skříni je " + ObleceniCards.Count + " kusů oblečení";

        }

        public string PocetObleceni { get { return _PocetObleceni; } set { _PocetObleceni = value; OnPropertyChanged(); } }

        public RelayCommand NoveObleceniButton
        {
            get
            {
                return _addObleceniCommand ?? (_addObleceniCommand = new RelayCommand(AddObleceniItem));
            }
        }

        private void AddObleceniItem(object obj)
        {
            //add new window
            var noveObleceni = new NoveObleceni();
            if (noveObleceni.ShowDialog() == true)
            {
                //vezmu si data
                BitmapImage bitmapImage = noveObleceni.bitmapImage;
                ObleceniCards.Add(new ObleceniCustomCardViewModel(this, "tricko", "zelena", "sportovni", bitmapImage));

                //updatuju string
                PocetObleceni = "Ve vaší skříni je " + ObleceniCards.Count + " kusů oblečení";
            }
            //ObleceniCards.Add(new ObleceniCards(this, _cityToBeAdded));
        }

    }
}
