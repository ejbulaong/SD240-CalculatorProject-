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

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Calculator.Operator = "+";
            Evaluate(Calculator.Operator);
        }

        private void BtnSubtract_Click(object sender, RoutedEventArgs e)
        {
            Calculator.Operator = "-";
            Evaluate(Calculator.Operator);
        }

        private void BtnMultiply_Click(object sender, RoutedEventArgs e)
        {
            Calculator.Operator = "*";
            Evaluate(Calculator.Operator);
        }

        private void BtnDivide_Click(object sender, RoutedEventArgs e)
        {
            Calculator.Operator = "/";
            Evaluate(Calculator.Operator);
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

        private void Evaluate(string mathOperator)
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


    }
}
