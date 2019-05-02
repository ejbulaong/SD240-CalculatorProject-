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
            Clear();
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
            InputValue("0");
        }

        private void BtnDecimal_Click(object sender, RoutedEventArgs e)
        {
            if (!Calculator.EnteredValue.Contains("."))
                if (Calculator.EnteredValue == string.Empty)
                {
                    InputValue("0.");
                }
                else
                {
                    InputValue(".");
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

        private void BtnPower_Click(object sender, RoutedEventArgs e)
        {
            CallBasicCalculation("^");
        }

        private void BtnFactorial_Click(object sender, RoutedEventArgs e)
        {
            if(Calculator.StoredValue == "" && Calculator.Operator == "")
            {
                Calculator.Operator = "!";
                try
                {
                    if (Calculator.EnteredValue == "")
                    {
                        Calculator.EnteredValue = "0";
                    }

                    Calculator.StoredValue = Calculator.EnteredValue;
                    lblDisplay.Content = Calculator.StoredValue + "!";

                    double result = 1;
                    var number = Convert.ToDouble(Calculator.EnteredValue);
                    if (number == 0)
                    {
                        result = 1;
                    }
                    else
                    {
                        while (number != 1)
                        {
                            result = result * number;
                            number = number - 1;
                        }
                    }

                    Calculator.EnteredValue = result.ToString();
                    Calculator.StoredValue = "";
                    txtDisplay.Text = Calculator.EnteredValue;

                }
                catch
                {
                    Clear();
                    lblDisplay.Content = "Invalid Expression";
                }
            }           
        }

        private void Clear()
        {
            Calculator.Operator = "";
            Calculator.StoredValue = "";
            Calculator.EnteredValue = "";
            lblDisplay.Content = "";
            lblOperator.Content = "";
            txtDisplay.Text = "0";
        }

        private void InputValue(string val)
        {
            if (Calculator.Operator == "√" || Calculator.Operator == "!")
            {
                Clear();
            }

            if (Calculator.EnteredValue.Length < 16)
            {
                Calculator.EnteredValue += val;
                txtDisplay.Text = Calculator.EnteredValue;
            }
        }

        private void BtnSquareRoot_Click(object sender, RoutedEventArgs e)
        {
            Calculator.Operator = "√";
            try
            {
                if (Calculator.EnteredValue == "")
                {
                    Calculator.EnteredValue = "0";
                }
                Calculator.StoredValue = Calculator.EnteredValue;
                lblDisplay.Content = "√" + Calculator.StoredValue;

                Calculator.EnteredValue = Math.Sqrt(Convert.ToDouble(Calculator.EnteredValue)).ToString();
                Calculator.StoredValue = "";
                txtDisplay.Text = Calculator.EnteredValue;
            }
            catch
            {
                Clear();
                lblDisplay.Content = "Invalid Expression";
            }
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
            if (Calculator.EnteredValue == "" && Calculator.StoredValue == "")
            {
                Calculator.EnteredValue = "0";
            }

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
                    if (Calculator.Operator == "^")
                    {
                        Calculator.StoredValue = Math.Pow(Convert.ToDouble(Calculator.StoredValue),
                            Convert.ToDouble(Calculator.EnteredValue)).ToString();
                    }
                    else
                    {
                        var expression = Calculator.StoredValue + Calculator.Operator + Calculator.EnteredValue;
                        double answer;
                        answer = Convert.ToDouble(new DataTable().Compute(expression, null));
                        Calculator.StoredValue = answer.ToString();
                    }
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
