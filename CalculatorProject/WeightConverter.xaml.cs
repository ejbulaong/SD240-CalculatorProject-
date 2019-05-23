using CalculatorProject.Models;
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
    /// Interaction logic for WeightConverter.xaml
    /// </summary>
    public partial class WeightConverter : Page
    {
        private WeightCalculator WeightCalc { get; set; }

        public WeightConverter()
        {
            WeightCalc = new WeightCalculator();
            InitializeComponent();
        }

        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            if (WeightCalc.EnteredValue != "0")
            {
                InputValue("0");
            }
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

        private void BtnDecimal_Click(object sender, RoutedEventArgs e)
        {
            if (!WeightCalc.EnteredValue.Contains("."))
            {
                if (WeightCalc.EnteredValue == string.Empty || WeightCalc.EnteredValue == "0")
                {
                    InputValue("0.");
                }
                else
                {
                    InputValue(".");
                }
            }
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {

            WeightCalc.EnteredValue = "";
            WeightCalc.MgValue = 0;
            WeightCalc.GValue = 0;
            WeightCalc.KgValue = 0;
            WeightCalc.OzValue = 0;
            WeightCalc.LbValue = 0;
            txtDisplay.Text = "";
            lblMgValue.Content = "";
            lblGValue.Content = "";
            lblKgValue.Content = "";
            lblOzValue.Content = "";
            lblLbValue.Content = "";
        }

        private void TextChangedEventHandler(object sender, TextChangedEventArgs args)
        {
            if (comboBox1 != null)
            {
                Calculate(comboBox1.Text);
            }
        }

        private void InputValue(string value)
        {
            if (WeightCalc.EnteredValue == "0")
            {
                WeightCalc.EnteredValue = "";
            }

            if (txtDisplay.Text.Length < 16)
            {
                WeightCalc.EnteredValue += value;
                txtDisplay.Text = WeightCalc.EnteredValue;
            }
        }

        private void ComboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBox1 != null)
            {
                var text = ((sender as ComboBox).SelectedItem as ComboBoxItem).Content as string;
                Calculate(text);
            }
        }

        private void Calculate(string text)
        {
            if (WeightCalc.EnteredValue == "" || WeightCalc.EnteredValue == ".")
            {
                return;
            }

            if (text == "Mg")
            {
                WeightCalc.MgValue = Convert.ToDouble(WeightCalc.EnteredValue);
                WeightCalc.GValue = WeightCalc.MgToG(WeightCalc.MgValue);
                WeightCalc.KgValue = WeightCalc.MgToKg(WeightCalc.MgValue);
                WeightCalc.OzValue = WeightCalc.MgToOz(WeightCalc.MgValue);
                WeightCalc.LbValue = WeightCalc.MgToLb(WeightCalc.MgValue);
            }
            else if (text == "G")
            {
                WeightCalc.GValue = Convert.ToDouble(WeightCalc.EnteredValue);
                WeightCalc.MgValue = WeightCalc.GToMg(WeightCalc.GValue);
                WeightCalc.KgValue = WeightCalc.GToKg(WeightCalc.GValue);
                WeightCalc.OzValue = WeightCalc.GToOz(WeightCalc.GValue);
                WeightCalc.LbValue = WeightCalc.GToLb(WeightCalc.GValue);
            }
            else if (text == "Kg")
            {
                WeightCalc.KgValue = Convert.ToDouble(WeightCalc.EnteredValue);
                WeightCalc.MgValue = WeightCalc.KgToMg(WeightCalc.KgValue);
                WeightCalc.GValue = WeightCalc.KgToG(WeightCalc.KgValue);
                WeightCalc.OzValue = WeightCalc.KgToOz(WeightCalc.KgValue);
                WeightCalc.LbValue = WeightCalc.KgToLb(WeightCalc.KgValue);
            }
            else if (text == "Oz")
            {
                WeightCalc.OzValue = Convert.ToDouble(WeightCalc.EnteredValue);
                WeightCalc.MgValue = WeightCalc.OzToMg(WeightCalc.OzValue);
                WeightCalc.GValue = WeightCalc.OzToG(WeightCalc.OzValue);
                WeightCalc.KgValue = WeightCalc.OzToKg(WeightCalc.OzValue);
                WeightCalc.LbValue = WeightCalc.OzToLb(WeightCalc.OzValue);
            }
            else if (text == "Lb")
            {
                WeightCalc.LbValue = Convert.ToDouble(WeightCalc.EnteredValue);
                WeightCalc.MgValue = WeightCalc.LbToMg(WeightCalc.LbValue);
                WeightCalc.GValue = WeightCalc.LbToG(WeightCalc.LbValue);
                WeightCalc.KgValue = WeightCalc.LbToKg(WeightCalc.LbValue);
                WeightCalc.OzValue = WeightCalc.LbToOz(WeightCalc.LbValue);
            }

            lblMgValue.Content = WeightCalc.MgValue.ToString();
            lblGValue.Content = WeightCalc.GValue.ToString();
            lblKgValue.Content = WeightCalc.KgValue.ToString();
            lblOzValue.Content = WeightCalc.OzValue.ToString();
            lblLbValue.Content = WeightCalc.LbValue.ToString();
        }
    }
}
