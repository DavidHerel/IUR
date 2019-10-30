using IUR_p05.Support;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace IUR_p05.ViewModels
{
    class AlarmManagerViewModel:ViewModelBase
    {
        private RelayCommand _addCommand;
        private RelayCommand _deleteCommand;
        private AlarmItemViewModel _selectedAlarmDetail;
        public ObservableCollection<AlarmItemViewModel> AlarmList { get; set; } = new ObservableCollection<AlarmItemViewModel>();
        public ObservableCollection<BitmapImage> AlarmIcons { get; set; } = new ObservableCollection<BitmapImage>();
        public AlarmManagerViewModel()
        {
            AlarmList.Add(new AlarmItemViewModel() { AlarmName = "Alarm 1" });
            AlarmList.Add(new AlarmItemViewModel() { AlarmName = "Alarm 2" });
            AlarmList.Add(new AlarmItemViewModel() { AlarmName = "Alarm 3" });

            for (int i = 1; i < 3; i++)
            {
                AlarmIcons.Add(new BitmapImage(new System.Uri($"pack://application:,,,/Images/cold{i}.png")));
            }
            for (int i = 1; i < 3; i++)
            {
                AlarmIcons.Add(new BitmapImage(new System.Uri($"pack://application:,,,/Images/hot{i}.png")));
            }

            //SelectedAlarmDetail = AlarmList[1];
        }

        public AlarmItemViewModel SelectedAlarmDetail
        {
            get { return _selectedAlarmDetail; }
            set { _selectedAlarmDetail = value;
                OnPropertyChanged("SelectedAlarmDetail");
            }
        }

        public RelayCommand AddCommand
        {
            get { return _addCommand ?? (_addCommand = new RelayCommand(AddAlarmItem, AddCommandCantExecute)); }
        }

        private bool AddCommandCantExecute(object obj)
        {
            return !(AlarmList.Count >= 10);
        }

        private void AddAlarmItem(object obj)
        {
            AlarmList.Add(new AlarmItemViewModel() { AlarmName = "New Alarm" });
            SelectedAlarmDetail = AlarmList[AlarmList.Count - 1];
        }

        public RelayCommand DeleteCommand
        {
            get { return _deleteCommand ?? (_deleteCommand = new RelayCommand(DeleteAlarmItem, DeleteCommandCantExecute)); }
        }

        private bool DeleteCommandCantExecute(object obj)
        {
            return !(AlarmList.Count == 0);
        }

        private void DeleteAlarmItem(object obj)
        {
            AlarmList.Remove(SelectedAlarmDetail);
            if (AlarmList.Count > 0)
                SelectedAlarmDetail = AlarmList[AlarmList.Count-1];
        }
    }
}

