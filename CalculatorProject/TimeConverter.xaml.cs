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
    /// Interaction logic for TimeConverter.xaml
    /// </summary>
    public partial class TimeConverter : Page
    {
        private TimeCalculator TimeCon { get; set; }

        public TimeConverter()
        {
            TimeCon = new TimeCalculator();
            InitializeComponent();
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            Clear();
        }

        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {
            if (TimeCon.EnteredValue.Length > 0)
            {
                TimeCon.EnteredValue = TimeCon.EnteredValue.Substring(0, TimeCon.EnteredValue.Length - 1);
                lblEnteredValue.Content = TimeCon.EnteredValue;

                if (TimeCon.EnteredValue.Length == 0)
                {
                    lblEnteredValue.Content = "0";
                }
            }
            else
            {
                TimeCon.EnteredValue = "";
                lblEnteredValue.Content = "0";
            }
            Calculate(comboBox1.Text, comboBox2.Text);
        }

        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            if (TimeCon.EnteredValue != "0")
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

        private void BtnDecimal_Click(object sender, RoutedEventArgs e)
        {
            if (!TimeCon.EnteredValue.Contains("."))
            {
                if (TimeCon.EnteredValue == string.Empty)
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

        private void InputValue(string value)
        {
            if(TimeCon.EnteredValue == "0" && value != ".")
            {
                TimeCon.EnteredValue = "";
            }

            if (TimeCon.EnteredValue.Length < 14)
            {
                TimeCon.EnteredValue += value;
                lblEnteredValue.Content = TimeCon.EnteredValue;
            }
        }

        private void Calculate(string option1, string option2)
        {
            if(TimeCon.EnteredValue == "" && lblOutputValue != null)
            {
                lblOutputValue.Content = "0";
            }

            if (option1 == "Hours" && option2 == "Minutes" && TimeCon.EnteredValue != "")
            {
                var min = Convert.ToDouble(TimeCon.EnteredValue);
                TimeCon.HoursValue = Convert.ToDouble(TimeCon.EnteredValue);
                TimeCon.MinsValue = TimeCon.HourToMinute(min);
                lblOutputValue.Content = TimeCon.MinsValue;
            }
            else if (option1 == "Hours" && option2 == "Seconds" && TimeCon.EnteredValue != "")
            {
                var sec = Convert.ToDouble(TimeCon.EnteredValue);
                TimeCon.HoursValue = Convert.ToDouble(TimeCon.EnteredValue);
                TimeCon.SecsValue = TimeCon.HourToSecond(sec);
                lblOutputValue.Content = TimeCon.SecsValue;
            }
            else if (option1 == "Hours" && option2 == "Hours" && TimeCon.EnteredValue != "")
            {
                TimeCon.HoursValue = Convert.ToDouble(TimeCon.EnteredValue);
                lblOutputValue.Content = TimeCon.HoursValue;
            }
            else if (option1 == "Minutes" && option2 == "Hours" && TimeCon.EnteredValue != "")
            {
                var min = Convert.ToDouble(TimeCon.EnteredValue);
                TimeCon.MinsValue = Convert.ToDouble(TimeCon.EnteredValue);
                TimeCon.HoursValue = TimeCon.MinuteToHour(min);
                lblOutputValue.Content = TimeCon.HoursValue;
            }
            else if (option1 == "Minutes" && option2 == "Seconds" && TimeCon.EnteredValue != "")
            {
                var min = Convert.ToDouble(TimeCon.EnteredValue);
                TimeCon.MinsValue = Convert.ToDouble(TimeCon.EnteredValue);
                TimeCon.SecsValue = TimeCon.MinuteToSecond(min);
                lblOutputValue.Content = TimeCon.SecsValue;
            }
            else if (option1 == "Minutes" && option2 == "Minutes" && TimeCon.EnteredValue != "")
            {
                TimeCon.MinsValue = Convert.ToDouble(TimeCon.EnteredValue);
                lblOutputValue.Content = TimeCon.MinsValue;
            }
            else if (option1 == "Seconds" && option2 == "Hours" && TimeCon.EnteredValue != "")
            {
                var sec = Convert.ToDouble(TimeCon.EnteredValue);
                TimeCon.SecsValue = Convert.ToDouble(TimeCon.EnteredValue);
                TimeCon.HoursValue = TimeCon.SecondToHour(sec);
                lblOutputValue.Content = TimeCon.HoursValue;
            }
            else if (option1 == "Seconds" && option2 == "Minutes" && TimeCon.EnteredValue != "")
            {
                var sec = Convert.ToDouble(TimeCon.EnteredValue);
                TimeCon.SecsValue = Convert.ToDouble(TimeCon.EnteredValue);
                TimeCon.MinsValue = TimeCon.SecondToMinute(sec);
                lblOutputValue.Content = TimeCon.MinsValue;
            }
            else if (option1 == "Seconds" && option2 == "Seconds" && TimeCon.EnteredValue != "")
            {
                TimeCon.SecsValue = Convert.ToDouble(TimeCon.EnteredValue);
                lblOutputValue.Content = TimeCon.SecsValue;
            }
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
            TimeCon.EnteredValue = "";
            TimeCon.HoursValue = 0;
            TimeCon.MinsValue = 0;
            TimeCon.SecsValue = 0;
            lblOutputValue.Content = "0";
            lblEnteredValue.Content = "0";
        }
    }
}
