using IUR_p05.Support;
using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace IUR_p05.ViewModels
{
    internal class AlarmItemViewModel:ViewModelBase
    {
        private string _alarmName;

        private string _alarmMessage;

        private string _alarmImage;

        private int _thresholdValue;

        private AlarmType _alarmType;

        public ObservableCollection<string> _alarmIcons { get; set; } = new ObservableCollection<string>();

        private string _selectedImage;

        private string _selectedItem;

        public ObservableCollection<string> AlarmIcons
        {
            get
            {
                _alarmIcons.Add("pack://application:,,,/Images/cold1.png");
                _alarmIcons.Add("pack://application:,,,/Images/cold2.png");
                _alarmIcons.Add("pack://application:,,,/Images/cold3.png");
                _alarmIcons.Add("pack://application:,,,/Images/hot1.png");
                _alarmIcons.Add("pack://application:,,,/Images/hot2.png");
                _alarmIcons.Add("pack://application:,,,/Images/hot3.png");
                return _alarmIcons;
            }
            set
            {
                _alarmIcons = value;
                OnPropertyChanged("AlarmIcons");
            }
        }

        public string SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;
                OnPropertyChanged("SelectedItem");
            }
        }

        public string SelectedImage
        {
            get { return _selectedImage; }
            set
            {
                _selectedImage = value;
                OnPropertyChanged("SelectedImage");
            }
        }

        public string AlarmName
        {
            get { return _alarmName; }
            set
            {
                _alarmName = value;
                OnPropertyChanged("AlarmName");
            }
        }

        public string AlarmMessage
        {
            get { return _alarmMessage; }
            set
            {
                _alarmMessage = value;
                OnPropertyChanged("AlarmMessage");
            }
        }

        public int ThresholdValue
        {
            get
            {
                return _thresholdValue;
            }
            set
            {
                _thresholdValue = value;
                OnPropertyChanged("ThresholdValue");
            }
        }

        public AlarmType Type
        {
            get { return _alarmType; }
            set
            {
                _alarmType = value;
                OnPropertyChanged("Type");
            }
        }

    }


    

    internal enum AlarmType
    {
        MIN = 0,
        MAX = 1
    }


    public class EnumBooleanConverter : IValueConverter
    {
        #region IValueConverter Members
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string parameterString = parameter as string;
            if (parameterString == null)
                return DependencyProperty.UnsetValue;

            if (Enum.IsDefined(value.GetType(), value) == false)
                return DependencyProperty.UnsetValue;

            object parameterValue = Enum.Parse(value.GetType(), parameterString);

            return parameterValue.Equals(value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string parameterString = parameter as string;
            if (parameterString == null)
                return DependencyProperty.UnsetValue;

            return Enum.Parse(targetType, parameterString);
        }
        #endregion
    }

}