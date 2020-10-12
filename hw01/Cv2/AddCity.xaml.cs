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
    /// Interakční logika pro AddCity.xaml
    /// </summary>
    public partial class AddCity : Window
    {
        public String text;

        public String getText()
        {
            return text;
        }

        public AddCity()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            text = textBox.Text;
            DialogResult = true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            this.Close();
        }
    }
}
