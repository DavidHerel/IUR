using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace IUR_p04
{

    /// <summary>
    /// Interaction logic for UserProfile.xaml
    /// </summary>
    public partial class UserProfile : Window
    {
        public ObservableCollection<string> Hobbies { get; set; } = new ObservableCollection<string>();

        public string CurrentHobby { get; set; }

        public string FirstName { get; set; }

        public string Surname { get; set; }

        public string SelectedHobby { get; set; }
        public UserProfile()
        {
            InitializeComponent();
            DataContext = this;
           // Hobbies = new ObservableCollection<string>();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            //if it is not empty string
            if (CurrentHobby != "" && CurrentHobby != null)
            {
                Hobbies.Add(CurrentHobby);
                CurrentHobby = "";
            }
            AddHobbyBox.Clear();
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {            
            if (Hobbies.Count != 0)
            {
                Hobbies.Remove(SelectedHobby);
            }
        }

        private void ColorBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            //get index -> change color
            var content = ColorBox.SelectedIndex;
            if (content == 0)
            {
                this.Background = Brushes.White;
            }
            else if (content == 1)
            {
                this.Background = Brushes.Blue;
            }
            else if (content == 2)
            {
                this.Background = Brushes.Red;
            }
            else if (content == 3)
            {
                this.Background = Brushes.Yellow;
            }
        }

        private void GenderBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            var content = GenderBox.SelectedIndex;
            Image image = new Image();

            //Male option
            if (content == 0)
            {
                //Uri resourceUri = new Uri("/Images/men.png", UriKind.Relative);
                GenderImage.Source = new BitmapImage(new System.Uri("pack://application:,,,/Images/men.png"));
                GenderImage.Height = 30;
               // GenderImage = image;
            }

            //Female Option
            else if (content == 1)
            {
                Uri resourceUri = new Uri("/Images/women.png", UriKind.Relative);
                GenderImage.Source = new BitmapImage(new System.Uri("pack://application:,,,/Images/women.png"));
                GenderImage.Height = 30;
             //   GenderImage = image;
            }
        }
    }

    public class ReverseConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool val = (bool)value;
            return !val;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool val = (bool)value;
            return !val;
        }
    }
}
