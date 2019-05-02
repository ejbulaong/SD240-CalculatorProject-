using System;
using System.Collections.Generic;
using System.Data;
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

namespace SD240_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Calculator Calculator { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Calculator = new Calculator();
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            Calculator.EnteredValue += "1";
            txtDisplay.Text = Calculator.EnteredValue;
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            Calculator.EnteredValue += "2";
            txtDisplay.Text = Calculator.EnteredValue;
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            Calculator.EnteredValue += "3";
            txtDisplay.Text = Calculator.EnteredValue;
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            Calculator.EnteredValue += "4";
            txtDisplay.Text = Calculator.EnteredValue;
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            Calculator.EnteredValue += "5";
            txtDisplay.Text = Calculator.EnteredValue;
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            Calculator.EnteredValue += "6";
            txtDisplay.Text = Calculator.EnteredValue;
        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            Calculator.EnteredValue += "7";
            txtDisplay.Text = Calculator.EnteredValue;
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            Calculator.EnteredValue += "8";
            txtDisplay.Text = Calculator.EnteredValue;
        }

        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            Calculator.EnteredValue += "9";
            txtDisplay.Text = Calculator.EnteredValue;
        }

        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            Calculator.EnteredValue += "0";
            txtDisplay.Text = Calculator.EnteredValue;
        }

        private void BtnDecimal_Click(object sender, RoutedEventArgs e)
        {
            if (!Calculator.EnteredValue.Contains("."))
                if (Calculator.EnteredValue == string.Empty)
                {
                    Calculator.EnteredValue += "0.";
                    txtDisplay.Text = Calculator.EnteredValue;
                }
                else
                {
                    Calculator.EnteredValue += ".";
                    txtDisplay.Text = Calculator.EnteredValue;
                }
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            CallBasicCalculation("+");
        }

        private void BtnSubtract_Click(object sender, RoutedEventArgs e)
        {
            CallBasicCalculation("-");
        }

        private void BtnMultiply_Click(object sender, RoutedEventArgs e)
        {
            CallBasicCalculation("*");
        }

        private void BtnDivide_Click(object sender, RoutedEventArgs e)
        {
            CallBasicCalculation("/");
        }

        private void BtnEquals_Click(object sender, RoutedEventArgs e)
        {
            if (Calculator.StoredValue != "" &&
                Calculator.Operator != "" &&
                Calculator.EnteredValue != "")
            {
                Evaluate(Calculator.Operator);
            }
            Calculator.Operator = "";
            Calculator.EnteredValue = "";

            txtDisplay.Text = Calculator.EnteredValue;
            lblDisplay.Content = Calculator.StoredValue;
            lblOperator.Content = Calculator.Operator;
        }

        private void CallBasicCalculation(string mathOperator)
        {
            if (Calculator.Operator != mathOperator && Calculator.Operator != "")
            {
                Evaluate(Calculator.Operator);
                Calculator.Operator = mathOperator;
                lblOperator.Content = Calculator.Operator;
            }
            else
            {
                Calculator.Operator = mathOperator;
                Evaluate(Calculator.Operator);
            }
        }

        private void Evaluate(string mathOperator)
        {
            try
            {
                if (Calculator.StoredValue == "")
                {
                    Calculator.StoredValue = Calculator.EnteredValue;
                }
                else if (Calculator.StoredValue != "" && Calculator.EnteredValue != "")
                {
                    var expression = Calculator.StoredValue + Calculator.Operator + Calculator.EnteredValue;
                    double answer;
                    answer = Convert.ToDouble(new DataTable().Compute(expression, null));
                    Calculator.StoredValue = answer.ToString();
                }

                Calculator.EnteredValue = "";

                txtDisplay.Text = Calculator.EnteredValue;
                lblDisplay.Content = Calculator.StoredValue;
                lblOperator.Content = Calculator.Operator;
            }
            catch
            {
                lblDisplay.Content = "Invalid Expression";
            }
        }

        private void BtnPositiveNegative_Click(object sender, RoutedEventArgs e)
        {
            if (Calculator.EnteredValue == "")
            {
                Calculator.EnteredValue = "-";
            }
            else if (Calculator.EnteredValue == "-")
            {
                Calculator.EnteredValue = "";
            }
            else
            {
                var val = Convert.ToDouble(Calculator.EnteredValue);
                if (val > 0)
                {
                    Calculator.EnteredValue = Calculator.EnteredValue.Insert(0, "-");
                }
                else
                {
                    Calculator.EnteredValue = Calculator.EnteredValue.Remove(0, 1);
                }
            }
            txtDisplay.Text = Calculator.EnteredValue;
        }
    }
}
