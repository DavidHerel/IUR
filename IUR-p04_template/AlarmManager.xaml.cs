using System;
using System.Collections.ObjectModel;
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
    /// 

    public partial class AlarmManager : Window
    {
        public ObservableCollection<string> AlarmList { get; set; }
        public string AlarmName { get; set; } // autoproperty, kompilator vygeneruje neco co existuje na pozadi

        public AlarmManager()
        {
            InitializeComponent();
            DataContext = this;
            AlarmName = "My tempreature alarm";

            AlarmList = new ObservableCollection<string>();

            Image image1 = new Image();
            image1.Source = new BitmapImage(new System.Uri("pack://application:,,,/Images/cold1.png")); //reference na assemble, kam se to sbilduje, tri ','jsou excapovaci znaky, ktere se zmeni na lomitka.
            image1.Height = 30;
            ComboBox_Images.Items.Add(image1);

            //Binding binding = new Binding();
            //binding.Source = mySlider;
            //binding.Path = new PropertyPath("Value"); //mySlider.Value
            //myTextBox.SetBinding(TextBox.TextProperty, binding);
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AlarmList.Add("New Alarm");
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
