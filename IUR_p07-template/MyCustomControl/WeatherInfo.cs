﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WeatherInfoCustomControl
{
    /// <summary>
    /// Follow steps 1a or 1b and then 2 to use this custom control in a XAML file.
    ///
    /// Step 1a) Using this custom control in a XAML file that exists in the current project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:MyCustomControl"
    ///
    ///
    /// Step 1b) Using this custom control in a XAML file that exists in a different project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:MyCustomControl;assembly=MyCustomControl"
    ///
    /// You will also need to add a project reference from the project where the XAML file lives
    /// to this project and Rebuild to avoid compilation errors:
    ///
    ///     Right click on the target project in the Solution Explorer and
    ///     "Add Reference"->"Projects"->[Select this project]
    ///
    ///
    /// Step 2)
    /// Go ahead and use your control in the XAML file.
    ///
    ///     <MyNamespace:CustomControl1/>
    ///
    /// </summary>
    public class WeatherInfo : ToggleButton
    {
        static WeatherInfo()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(WeatherInfo), new
               FrameworkPropertyMetadata(typeof(WeatherInfo)));
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

        public static readonly DependencyProperty CityProperty =
             DependencyProperty.Register("City", typeof(string), typeof(WeatherInfo));

        public static readonly DependencyProperty TemperatureProperty =
            DependencyProperty.Register("Temperature", typeof(int), typeof(WeatherInfo));

        public static readonly DependencyProperty HumidityProperty =
            DependencyProperty.Register("Humidity", typeof(int), typeof(WeatherInfo));

        public static readonly DependencyProperty TempMinProperty =
            DependencyProperty.Register("TempMin", typeof(int), typeof(WeatherInfo));

        public static readonly DependencyProperty TempMaxProperty =
            DependencyProperty.Register("TempMax", typeof(int), typeof(WeatherInfo));

        public static readonly DependencyProperty LabelProperty =
            DependencyProperty.Register("Label", typeof(string), typeof(WeatherInfo));

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(string), typeof(WeatherInfo));
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

            return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}
