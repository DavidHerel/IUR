using IUR_p05.Support;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace IUR_p05.ViewModels
{
    class AlarmManagerViewModel:ViewModelBase
    {
        private AlarmItemViewModel _selectedAlarmDetail;

      //  private int _selectedAlarmIndex;
        private RelayCommand _addCommand;
        private RelayCommand _deleteCommand;

        public ObservableCollection<AlarmItemViewModel> AlarmList { get; set; } = new ObservableCollection<AlarmItemViewModel>();
        public AlarmManagerViewModel()
        {
            AlarmList.Add(new AlarmItemViewModel() { AlarmName = "Alarm 1" });
            AlarmList.Add(new AlarmItemViewModel() { AlarmName = "Alarm 2" });
            AlarmList.Add(new AlarmItemViewModel() { AlarmName = "Alarm 3" });
            SelectedAlarmDetail = AlarmList[0];
        }
        /*
        public int SelectedAlarmIndex
        {
            get
            {
                return _selectedAlarmIndex;
            }
            set
            {
                _selectedAlarmIndex = value;
                OnPropertyChanged("SelectedAlarmIndex");
            }
        }
        */

        public AlarmItemViewModel SelectedAlarmDetail
        {
            get { 
           /*     if (_selectedAlarmDetail == null && AlarmList.Count>0) 
                {
                    _selectedAlarmDetail = AlarmList[0];
                }*/
                return _selectedAlarmDetail;
                }
            set {
                _selectedAlarmDetail = value;
                OnPropertyChanged("SelectedAlarmDetail");
                }
        }

        public RelayCommand AddCommand
        {
            get
            {
                return _addCommand ?? (_addCommand = new RelayCommand(AddAlarmItem, AddCommandCanExecute));
            }
        }

        private void AddAlarmItem(object obj)
        {
            AlarmList.Add(new AlarmItemViewModel() { AlarmName = "New Alarm" });
            SelectedAlarmDetail = AlarmList[AlarmList.Count - 1];
        }

        private bool AddCommandCanExecute(object obj)
        {
            if (AlarmList.Count >= 10) return false;
            return true;
        }

        public RelayCommand DeleteCommand
        {
            get
            {
                return _deleteCommand ?? (_deleteCommand = new RelayCommand(DeleteAlarmItem, DeleteCommandCanExecute));
            }
        }

        private void DeleteAlarmItem(object obj)
        {
            AlarmList.Remove(SelectedAlarmDetail);
            if (AlarmList.Count > 0)
            {
                SelectedAlarmDetail = AlarmList[0];
            }
        }

        private bool DeleteCommandCanExecute(object obj)
        {
            if (AlarmList.Count <= 0) return false;
            return true;
        }
    }
}

