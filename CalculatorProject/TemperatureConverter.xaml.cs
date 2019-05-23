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
    /// Interaction logic for TemperatureConverter.xaml
    /// </summary>
    public partial class TemperatureConverter : Page
    {
        private TemperatureCalculator TempCalc { get; set; }

        public TemperatureConverter()
        {
            TempCalc = new TemperatureCalculator();
            InitializeComponent();
        }

        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            if (TempCalc.EnteredValue != "0")
            {
                InputValue("0");
                Calculate(comboBox1.Text, comboBox2.Text);
            }
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            InputValue("1");
            Calculate(comboBox1.Text, comboBox2.Text);
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            InputValue("2");
            Calculate(comboBox1.Text, comboBox2.Text);
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            InputValue("3");
            Calculate(comboBox1.Text, comboBox2.Text);
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            InputValue("4");
            Calculate(comboBox1.Text, comboBox2.Text);
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            InputValue("5");
            Calculate(comboBox1.Text, comboBox2.Text);
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            InputValue("6");
            Calculate(comboBox1.Text, comboBox2.Text);
        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            InputValue("7");
            Calculate(comboBox1.Text, comboBox2.Text);
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            InputValue("8");
            Calculate(comboBox1.Text, comboBox2.Text);
        }

        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            InputValue("9");
            Calculate(comboBox1.Text, comboBox2.Text);
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            Clear();
        }

        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {
            if (TempCalc.EnteredValue.Length > 0)
            {
                TempCalc.EnteredValue = TempCalc.EnteredValue.Substring(0, TempCalc.EnteredValue.Length - 1);
                lblEnteredValue.Content = TempCalc.EnteredValue;

                if (TempCalc.EnteredValue.Length == 0)
                {
                    lblEnteredValue.Content = "0";
                }
            }
            else
            {
                TempCalc.EnteredValue = "";
                lblEnteredValue.Content = "0";
            }
            Calculate(comboBox1.Text, comboBox2.Text);
        }

        private void BtnDecimal_Click(object sender, RoutedEventArgs e)
        {
            if (!TempCalc.EnteredValue.Contains("."))
            {
                if (TempCalc.EnteredValue == string.Empty || TempCalc.EnteredValue == "0")
                {
                    InputValue("0.");
                }
                else
                {
                    InputValue(".");
                }
            }
            Calculate(comboBox1.Text, comboBox2.Text);
        }

        private void ComboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBox1 != null && comboBox2 != null)
            {
                Clear();
            }
        }

        private void ComboBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBox1 != null && comboBox2 != null)
            {
                var text = ((sender as ComboBox).SelectedItem as ComboBoxItem).Content as string;
                Calculate(comboBox1.Text, text);
            }
        }

        private void Clear()
        {
            TempCalc.EnteredValue = "";
            TempCalc.FahrenheitValue = 0;
            TempCalc.CelsiusValue = 0;
            lblEnteredValue.Content = "0";
            lblOutputValue.Content = "0";
        }

        private void InputValue(string val)
        {
            if (TempCalc.EnteredValue == "0" && val != ".")
            {
                TempCalc.EnteredValue = "";
            }

            if (TempCalc.EnteredValue.Length < 14)
            {
                TempCalc.EnteredValue += val;
                lblEnteredValue.Content = TempCalc.EnteredValue;
            }
        }

        private void Calculate(string option1, string option2)
        {
            if (TempCalc.EnteredValue == "" && lblOutputValue != null)
            {
                lblOutputValue.Content = "0";
            }

            if (option1 == "Celsius" && option2 == "Fahrenheit" && TempCalc.EnteredValue != "")
            {
                var cel = Convert.ToDouble(TempCalc.EnteredValue);
                TempCalc.CelsiusValue = Convert.ToDouble(TempCalc.EnteredValue);
                TempCalc.FahrenheitValue = TempCalc.CelsiusToFahrenheit(cel);
                lblOutputValue.Content = TempCalc.FahrenheitValue;
            }
            else if (option1 == "Fahrenheit" && option2 == "Celsius" && TempCalc.EnteredValue != "")
            {
                var fah = Convert.ToDouble(TempCalc.EnteredValue);
                TempCalc.FahrenheitValue = Convert.ToDouble(TempCalc.EnteredValue);
                TempCalc.CelsiusValue = TempCalc.FahrenheitToCelsius(fah);
                lblOutputValue.Content = TempCalc.CelsiusValue;
            }
            else if (option1 == "Fahrenheit" && option2 == "Fahrenheit" && TempCalc.EnteredValue != "")
            {
                TempCalc.FahrenheitValue = Convert.ToDouble(TempCalc.EnteredValue);
                lblOutputValue.Content = TempCalc.FahrenheitValue;
            }
            else if (option1 == "Celsius" && option2 == "Celsius" && TempCalc.EnteredValue != "")
            {
                TempCalc.CelsiusValue = Convert.ToDouble(TempCalc.EnteredValue);
                lblOutputValue.Content = TempCalc.CelsiusValue;
            }
        }
    }
}
