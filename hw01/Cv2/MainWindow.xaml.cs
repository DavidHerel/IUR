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

            //2nd date
            var today = DateTime.Now;
            var secondDay = today.AddDays(2);
            OtherTabItem.Header = secondDay.DayOfWeek.ToString() + " " + secondDay.ToShortDateString();

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
                if (allCities.SelectedIndex == -1)
                {
                    return;
                }
                var content = allCities.SelectedItem;//((sender as ComboBox).SelectedItem as ComboBoxItem).Content;
                var result = WeatherNet.Clients.CurrentWeather.GetByCityName(content.ToString(), "Czechia", "en", "metric");
                var resultTommorow = WeatherNet.Clients.FiveDaysForecast.GetByCityName(content.ToString(), "Czechia", "en", "metric"); //CurrentWeather.GetByCityName(content.ToString(), "Czechia", "en", "metric");
                if (result.Success)
                {

                    //Today
                    TemperatureTextBlock.Text = result.Item.Temp.ToString() + " °C";
                    HumidityTextBlock.Text = result.Item.Humidity.ToString() + " %";

                    //Tommorow
                    TommorowTemperatureTextBlock.Text = resultTommorow.Items[0].Temp.ToString() + " °C";
                    TommorowHumidityTextBlock.Text = resultTommorow.Items[0].Humidity.ToString() + " %";

                    //Other day
                    OtherTemperatureTextBlock.Text = resultTommorow.Items[1].Temp.ToString() + " °C";
                    OtherHumidityTextBlock.Text = resultTommorow.Items[1].Humidity.ToString() + " %";
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //add new window
            var manageCitiesWindow = new ManageCities(allCities);
            if (manageCitiesWindow.ShowDialog() == true)
            {
                //clear combobox and add values from listbox
                allCities.Items.Clear();
                var temp2 = manageCitiesWindow.cities.Items.Count;
                foreach (var temp in manageCitiesWindow.cities.Items) { 
                    allCities.Items.Add(temp);
                }
            }
        }
    }
}
