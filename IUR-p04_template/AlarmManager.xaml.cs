using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace IUR_p04
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class AlarmManager : Window
    {

        public AlarmManager()
        {
            InitializeComponent();
            DataContext = this;

            Image image = new Image();
            image.Source = new BitmapImage(new System.Uri("pack://application:,,,/Images/hot1.png"));
            image.Height = 30;
            ComboBox_Images.Items.Add(image);

            Image image2 = new Image();
            image2.Source = new BitmapImage(new System.Uri("pack://application:,,,/Images/hot2.png"));
            image2.Height = 30;
            ComboBox_Images.Items.Add(image2);

            /*
            Binding binding = new Binding();
            // Set source object
            binding.Source = borderSlider;
            // Set source property
            binding.Path = new PropertyPath("Value");
            // Attach to target property
            borderTexbox.SetBinding(TextBox.TextProperty, binding);
            */

            AlarmName = "My morning Alarm";
        }

        public string AlarmName { get; set; }

        private void ComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
       
    }

    public class ToUpperConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
        object parameter, CultureInfo culture)
        {
            return (value as string).ToUpper();
        }
        public object ConvertBack(object value, Type
        targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
