using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace IUR_p07
{
    public class WeatherCustomControl : ToggleButton
    {
        static WeatherCustomControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(WeatherCustomControl), new FrameworkPropertyMetadata(typeof(WeatherCustomControl)));
        }

        public ICommand RemoveCommand
        {
            get
            {
                return (ICommand)GetValue(RemoveCommandProperty);
            }
            set
            {
                SetValue(RemoveCommandProperty, value);
            }
        }

        public string Conditions
        {            
            get
            {
                return (string)GetValue(ConditionsProperty);
            }
            set
            {
                SetValue(ConditionsProperty, value);
            }
        }

        public string City
        {
            get
            {
                return (string)GetValue(CityProperty);
            }
            set
            {
                SetValue(CityProperty, value);
            }
        }

        public int Temperature
        {
            get
            {
                return (int)GetValue(TemperatureProperty);
            }
            set
            {
                SetValue(TemperatureProperty, value);
            }
        }

        public int Humidity
        {
            get
            {
                return (int)GetValue(HumidityProperty);
            }
            set
            {
                SetValue(HumidityProperty, value);
            }
        }

        public int TempMin
        {
            get
            {
                return (int)GetValue(TempMinProperty);
            }
            set
            {
                SetValue(TempMinProperty, value);
            }
        }

        public int TempMax
        {
            get
            {
                return (int)GetValue(TempMaxProperty);
            }
            set
            {
                SetValue(TempMaxProperty, value);
            }
        }

        public string Label
        {
            get
            {
                return (string)GetValue(LabelProperty);
            }
            set
            {
                SetValue(LabelProperty, value);
            }
        }

        public string Icon
        {
            get
            {
                return (string)GetValue(IconProperty);
            }
            set
            {
                SetValue(IconProperty, value);
            }
        }

        public static readonly DependencyProperty RemoveCommandProperty =
            DependencyProperty.Register("RemoveCommand", typeof(ICommand), typeof(WeatherCustomControl), new PropertyMetadata(default(ICommand)));

        public static readonly DependencyProperty ConditionsProperty =
            DependencyProperty.Register("Conditions", typeof(string), typeof(WeatherCustomControl));

        public static readonly DependencyProperty CityProperty =
             DependencyProperty.Register("City", typeof(string), typeof(WeatherCustomControl));

        public static readonly DependencyProperty TemperatureProperty =
            DependencyProperty.Register("Temperature", typeof(int), typeof(WeatherCustomControl));

        public static readonly DependencyProperty HumidityProperty =
            DependencyProperty.Register("Humidity", typeof(int), typeof(WeatherCustomControl));

        public static readonly DependencyProperty TempMinProperty =
            DependencyProperty.Register("TempMin", typeof(int), typeof(WeatherCustomControl));

        public static readonly DependencyProperty TempMaxProperty =
            DependencyProperty.Register("TempMax", typeof(int), typeof(WeatherCustomControl));

        public static readonly DependencyProperty LabelProperty =
            DependencyProperty.Register("Label", typeof(string), typeof(WeatherCustomControl));

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(string), typeof(WeatherCustomControl));

    }

    public class BoolToVisibiltyConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool parameterBool = bool.Parse(parameter.ToString());

            if ((bool)value ^ parameterBool)
            {
                return Visibility.Visible;
            }
            return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class WeatherAPIImageSourceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var image = new Image();
            var fullFilePath = String.Format("http://openweathermap.org/img/w/{0}.png",value); 

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(fullFilePath, UriKind.Absolute);
            bitmap.EndInit();

            return bitmap;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
