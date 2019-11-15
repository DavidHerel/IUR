using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace IUR_p07
{
    /// <summary>
    /// Interaction logic for MyInputControl.xaml
    /// </summary>
    [ContentProperty("FileName")]
    public partial class MyInputControl : UserControl
    {
        public MyInputControl()
        {
            InitializeComponent();
        }

        public string FileName
        {
            get
            {
                return (string)GetValue(FileNameProperty);
            }
            set
            {
                SetValue(FileNameProperty, value);
            }
        }

        public static readonly DependencyProperty FileNameProperty = DependencyProperty.Register("FileName", typeof(string), typeof(MyInputControl));

        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                this.FileName = openFileDialog.FileName;
            }
        }
    }
}
