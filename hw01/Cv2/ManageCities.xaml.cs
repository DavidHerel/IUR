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
using System.Windows.Shapes;

namespace Cv2
{
    /// <summary>
    /// Interakční logika pro ManageCities.xaml
    /// </summary>
    public partial class ManageCities : Window
    {
        
        public ManageCities()
        {
            InitializeComponent();   
        }

        public ManageCities(ComboBox citiesFromMain)
        {
            InitializeComponent();
            foreach (String temp in citiesFromMain.Items)
            {
                cities.Items.Add(temp);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var AddCityWindow = new AddCity();
            if (AddCityWindow.ShowDialog() == true)
            {
                cities.Items.Add(AddCityWindow.getText());
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            cities.Items.RemoveAt(cities.Items.IndexOf(cities.SelectedItem));
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var temp = cities.Items.Count;
            DialogResult = true;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
