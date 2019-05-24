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
    /// Interaction logic for PercentageConverter.xaml
    /// </summary>
    public partial class PercentageConverter : Page
    {
        private PercentageCalculator PercentageCalc { get; set; }

        public PercentageConverter()
        {
            PercentageCalc = new PercentageCalculator();
            InitializeComponent();
        }

        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            if (PercentageCalc.EnteredValue != "0")
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
            if (PercentageCalc.EnteredValue.Length > 0)
            {
                PercentageCalc.EnteredValue = PercentageCalc.EnteredValue.Substring(0, PercentageCalc.EnteredValue.Length - 1);
                lblEnteredValue.Content = PercentageCalc.EnteredValue;

                if (PercentageCalc.EnteredValue.Length == 0)
                {
                    lblEnteredValue.Content = "0";
                }
            }
            else
            {
                PercentageCalc.EnteredValue = "";
                lblEnteredValue.Content = "0";
            }
            Calculate(comboBox1.Text, comboBox2.Text);
        }

        private void BtnDecimal_Click(object sender, RoutedEventArgs e)
        {
            if (!PercentageCalc.EnteredValue.Contains("."))
            {
                if (PercentageCalc.EnteredValue == string.Empty || PercentageCalc.EnteredValue == "0")
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
            PercentageCalc.EnteredValue = "";
            PercentageCalc.DecimalValue = 0;
            PercentageCalc.PercentageValue = 0;
            lblEnteredValue.Content = "0";
            lblOutputValue.Content = "0";
        }

        private void InputValue(string val)
        {
            if (PercentageCalc.EnteredValue == "0" && val != ".")
            {
                PercentageCalc.EnteredValue = "";
            }

            if (PercentageCalc.EnteredValue.Length < 14)
            {
                PercentageCalc.EnteredValue += val;
                lblEnteredValue.Content = PercentageCalc.EnteredValue;
            }
        }

        private void Calculate(string option1, string option2)
        {
            if (PercentageCalc.EnteredValue == "" && lblOutputValue != null)
            {
                lblOutputValue.Content = "0";
            }

            if (option1 == "Decimal" && option2 == "Percentage" && PercentageCalc.EnteredValue != "")
            {
                var dec = Convert.ToDouble(PercentageCalc.EnteredValue);
                PercentageCalc.DecimalValue = dec;
                PercentageCalc.PercentageValue = PercentageCalc.DecToPercent(dec);
                lblOutputValue.Content = PercentageCalc.PercentageValue;
            }
            else if (option1 == "Percentage" && option2 == "Decimal" && PercentageCalc.EnteredValue != "")
            {
                var perc = Convert.ToDouble(PercentageCalc.EnteredValue);
                PercentageCalc.PercentageValue = perc;
                PercentageCalc.DecimalValue = PercentageCalc.PercentToDec(perc);
                lblOutputValue.Content = PercentageCalc.DecimalValue;
            }
            else if (option1 == "Decimal" && option2 == "Decimal" && PercentageCalc.EnteredValue != "")
            {
                PercentageCalc.DecimalValue = Convert.ToDouble(PercentageCalc.EnteredValue);
                lblOutputValue.Content = PercentageCalc.DecimalValue;
            }
            else if (option1 == "Percentage" && option2 == "Percentage" && PercentageCalc.EnteredValue != "")
            {
                PercentageCalc.PercentageValue = Convert.ToDouble(PercentageCalc.EnteredValue);
                lblOutputValue.Content = PercentageCalc.PercentageValue;
            }
        }
    }
}
