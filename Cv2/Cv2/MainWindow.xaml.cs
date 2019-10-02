using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Cv2
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WeatherNet.ClientSettings.ApiKey = "1bdfdfbac52feb077781c6b5ccaa3b31";
            WeatherNet.ClientSettings.ApiUrl = "https://api.openweathermap.org/data/2.5/";

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.IsInitialized)
            {
                var content = ((sender as ComboBox).SelectedItem as ComboBoxItem).Content;
                var result = WeatherNet.Clients.CurrentWeather.GetByCityName(content.ToString(), "Czechia", "en", "metric");
                if (result.Success)
                {
                    TemperatureTextBlock.Text = result.Item.Temp.ToString();
                    HumidityTextBlock.Text = result.Item.Humidity.ToString();
                }
            }
        }
    }
}
