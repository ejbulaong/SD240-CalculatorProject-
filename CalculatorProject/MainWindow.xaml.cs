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

namespace CalculatorProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Main.Content = new Standard();
        }

        private void main_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = null;
        }

        private void standard_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Standard();
        }

        private void programmer_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Programmer();
        }

        private void percentageConverter_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new PercentageConverter();
        }

        private void weigthConverter_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new WeightConverter();
        }

        private void temperatureConverter_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new TemperatureConverter();
        }

        private void lengthConverter_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new LengthConverter();
        }

        private void filesizeConverter_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new FileSizeConverter();
        }

        private void timeConverter_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new TimeConverter();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
