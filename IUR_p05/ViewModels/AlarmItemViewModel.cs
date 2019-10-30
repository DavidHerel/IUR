using IUR_p05.Support;
using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace IUR_p05.ViewModels
{
    internal class AlarmItemViewModel:ViewModelBase
    {
        private AlarmType _type;
        private int _tresholdValue;
        private string _alarmName;
        private string _alarmMessage;
       // TODO: Implement
       public string AlarmName
        {
            get { return _alarmName; }
            set { _alarmName = value;
                OnPropertyChanged("AlarmName");
            }
        }
        public int TresholdValue
        {
            get { return _tresholdValue; }
            set
            {
                _tresholdValue = value;
                OnPropertyChanged("TresholdValue");
            }
        }

        public AlarmType Type
        {
            get { return _type; }
            set
            {
                _type = value;
                OnPropertyChanged("Type");
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