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
    /// Interaction logic for LengthConverter.xaml
    /// </summary>
    public partial class LengthConverter : Page
    {
        private LengthCalculator LengthCalc { get; set; }

        public LengthConverter()
        {
            LengthCalc = new LengthCalculator();
            InitializeComponent();
        }

        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            if (LengthCalc.EnteredValue != "0")
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
            if (!LengthCalc.EnteredValue.Contains("."))
            {
                if (LengthCalc.EnteredValue == string.Empty || LengthCalc.EnteredValue == "0")
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

            LengthCalc.EnteredValue = "";
            LengthCalc.MmValue = 0;
            LengthCalc.CmValue = 0;
            LengthCalc.MValue = 0;
            LengthCalc.KmValue = 0;
            LengthCalc.InValue = 0;
            LengthCalc.FtValue = 0;
            txtDisplay.Text = "";
            lblCmValue.Content = "";
            lblFtValue.Content = "";
            lblInValue.Content = "";
            lblKmValue.Content = "";
            lblMmValue.Content = "";
            lblMValue.Content = "";
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
            if (LengthCalc.EnteredValue == "0")
            {
                LengthCalc.EnteredValue = "";
            }

            if (txtDisplay.Text.Length < 16)
            {
                LengthCalc.EnteredValue += value;
                txtDisplay.Text = LengthCalc.EnteredValue;
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
            if (LengthCalc.EnteredValue == "" || LengthCalc.EnteredValue == ".")
            {
                return;
            }

            if (text == "Mm")
            {
                LengthCalc.MmValue = Convert.ToDouble(LengthCalc.EnteredValue);
                LengthCalc.CmValue = LengthCalc.MmToCm(LengthCalc.MmValue);
                LengthCalc.MValue = LengthCalc.MmToM(LengthCalc.MmValue);
                LengthCalc.KmValue = LengthCalc.MmToKm(LengthCalc.MmValue);
                LengthCalc.InValue = LengthCalc.MmToIn(LengthCalc.MmValue);
                LengthCalc.FtValue = LengthCalc.MmToFt(LengthCalc.MmValue);

            }
            else if (text == "Cm")
            {
                LengthCalc.CmValue = Convert.ToDouble(LengthCalc.EnteredValue);
                LengthCalc.MmValue = LengthCalc.CmToMm(LengthCalc.CmValue);
                LengthCalc.MValue = LengthCalc.CmToM(LengthCalc.CmValue);
                LengthCalc.KmValue = LengthCalc.CmToKm(LengthCalc.CmValue);
                LengthCalc.InValue = LengthCalc.CmToIn(LengthCalc.CmValue);
                LengthCalc.FtValue = LengthCalc.CmToFt(LengthCalc.CmValue);

            }
            else if (text == "M")
            {
                LengthCalc.MValue = Convert.ToDouble(LengthCalc.EnteredValue);
                LengthCalc.MmValue = LengthCalc.MToMm(LengthCalc.MValue);
                LengthCalc.CmValue = LengthCalc.MToCm(LengthCalc.MValue);
                LengthCalc.KmValue = LengthCalc.MToKm(LengthCalc.MValue);
                LengthCalc.InValue = LengthCalc.MToIn(LengthCalc.MValue);
                LengthCalc.FtValue = LengthCalc.MToFt(LengthCalc.MValue);

            }
            else if (text == "Km")
            {
                LengthCalc.KmValue = Convert.ToDouble(LengthCalc.EnteredValue);
                LengthCalc.MmValue = LengthCalc.KmToMm(LengthCalc.KmValue);
                LengthCalc.CmValue = LengthCalc.KmToCm(LengthCalc.KmValue);
                LengthCalc.MValue = LengthCalc.KmToM(LengthCalc.KmValue);
                LengthCalc.InValue = LengthCalc.KmToIn(LengthCalc.KmValue);
                LengthCalc.FtValue = LengthCalc.KmToFt(LengthCalc.KmValue);

            }
            else if (text == "In")
            {
                LengthCalc.InValue = Convert.ToDouble(LengthCalc.EnteredValue);
                LengthCalc.MmValue = LengthCalc.InToMm(LengthCalc.InValue);
                LengthCalc.CmValue = LengthCalc.InToCm(LengthCalc.InValue);
                LengthCalc.MValue = LengthCalc.InToM(LengthCalc.InValue);
                LengthCalc.KmValue = LengthCalc.InToKm(LengthCalc.InValue);
                LengthCalc.FtValue = LengthCalc.InToFt(LengthCalc.InValue);

            }
            else if (text == "Ft")
            {
                LengthCalc.FtValue = Convert.ToDouble(LengthCalc.EnteredValue);
                LengthCalc.MmValue = LengthCalc.FtToMm(LengthCalc.FtValue);
                LengthCalc.CmValue = LengthCalc.FtToCm(LengthCalc.FtValue);
                LengthCalc.MValue = LengthCalc.FtToM(LengthCalc.FtValue);
                LengthCalc.KmValue = LengthCalc.FtToKm(LengthCalc.FtValue);
                LengthCalc.InValue = LengthCalc.FtToIn(LengthCalc.FtValue);
            }

            lblMmValue.Content = LengthCalc.MmValue.ToString();
            lblCmValue.Content = LengthCalc.CmValue.ToString();
            lblMValue.Content = LengthCalc.MValue.ToString();
            lblKmValue.Content = LengthCalc.KmValue.ToString();
            lblInValue.Content = LengthCalc.InValue.ToString();
            lblFtValue.Content = LengthCalc.FtValue.ToString();
        }
    }
}
