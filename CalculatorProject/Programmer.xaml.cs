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
    /// Interaction logic for Programmer.xaml
    /// </summary>
    public partial class Programmer : Page
    {
        private ProgrammerCalculator ProgrammerCalculator { get; set; }

        public Programmer()
        {
            InitializeComponent();
            ProgrammerCalculator = new ProgrammerCalculator();
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            InputValue("1");
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            InputValue("2");
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            InputValue("3");
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            InputValue("4");
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            InputValue("5");
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            InputValue("6");
        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            InputValue("7");
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            InputValue("8");
        }

        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            InputValue("9");
        }

        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            if (ProgrammerCalculator.EnteredValue != "0")
            {
                InputValue("0");
            }
        }

        private void InputValue(string value)
        {
            if (ProgrammerCalculator.EnteredValue == "0")
            {
                ProgrammerCalculator.EnteredValue = "";
            }

            if (txtDisplay.Text.Length < 16)
            {
                ProgrammerCalculator.EnteredValue += value;
                txtDisplay.Text = ProgrammerCalculator.EnteredValue;
            }
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            ProgrammerCalculator.EnteredValue = "";
            ProgrammerCalculator.HexValue = "";
            ProgrammerCalculator.OctValue = "";
            ProgrammerCalculator.BinValue = "";
            txtDisplay.Text = "";
            txtBinValue.Text = "";
            lblHexValue.Content = "";
            lblOctValue.Content = "";
        }

        private void TextChangedEventHandler(object sender, TextChangedEventArgs args)
        {
            if (ProgrammerCalculator == null)
            {
                txtBinValue.Text = "";
                lblHexValue.Content = "";
                lblOctValue.Content = "";
            }
            else if (ProgrammerCalculator.EnteredValue != "")
            {
                ProgrammerCalculator.EnteredValue = txtDisplay.Text;
                var number = Convert.ToInt64(ProgrammerCalculator.EnteredValue);

                ProgrammerCalculator.BinValue = ProgrammerCalculator.ConvertToBin(number);
                ProgrammerCalculator.HexValue = ProgrammerCalculator.ConvertToHex(number);
                ProgrammerCalculator.OctValue = ProgrammerCalculator.ConvertToOct(number);

                txtBinValue.Text = ProgrammerCalculator.BinValue;
                lblHexValue.Content = ProgrammerCalculator.HexValue;
                lblOctValue.Content = ProgrammerCalculator.OctValue;
            }
        }
    }
}
