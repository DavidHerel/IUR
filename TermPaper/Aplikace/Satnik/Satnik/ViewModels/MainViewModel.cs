using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Satnik.Support;

namespace Satnik.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public ObservableCollection<ObleceniCustomCardViewModel> ObleceniCards { get; set; } = new ObservableCollection<ObleceniCustomCardViewModel>();

        public MainViewModel()
        {
            
            ObleceniCards.Add(new ObleceniCustomCardViewModel(this, "tricko", "zelena", "sportovni"));

        }

    }
}
