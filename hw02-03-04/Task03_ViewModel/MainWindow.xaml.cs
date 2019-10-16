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

namespace Task03_ViewModel
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Remove current hobby from hobby list when button is clicked
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Only valid indexes
            if (HobbiesBox.Items.IndexOf(HobbiesBox.SelectedItem) >= 0)
            {
                HobbiesBox.Items.RemoveAt(HobbiesBox.Items.IndexOf(HobbiesBox.SelectedItem));
            }
        }

        //Adding hobby to hobbies list when button is clicked
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {       
            //Get rid of empty string
            if (AddHobbyBox.Text != ""){
                HobbiesBox.Items.Add(AddHobbyBox.Text);
            }
            //reset text
            AddHobbyBox.Text = "";
        }

        private void ColorBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //get index -> change color
            var content = ColorBox.SelectedIndex;
            if (content == 0)
            {
                this.Background = Brushes.White;
            }
            else if (content == 1)
            {
                this.Background = Brushes.Orange;
            }
            else if (content == 2)
            {
                this.Background = Brushes.Red;
            }
            else if (content == 3)
            {
                this.Background = Brushes.Black;
            }

        }

        //Change of image after changing Gender
        private void GenderBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var content = GenderBox.SelectedIndex;
            Image image = new Image();

            //Male option
            if(content == 0)
            {
                Uri resourceUri = new Uri("/Images/MaleIcon.png", UriKind.Relative);
                image.Source = new BitmapImage(resourceUri);
                image.Height = 30;
                GenderImage = image;
            }

            //Female Option
            else if (content == 1)
            {
                Uri resourceUri = new Uri("/Images/FemaleIcon.png", UriKind.Relative);
                image.Source = new BitmapImage(resourceUri);
                image.Height = 30;
                GenderImage = image;
            }
            
        }
    }
}
