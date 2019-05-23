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
    /// Interaction logic for FileSizeConverter.xaml
    /// </summary>
    public partial class FileSizeConverter : Page
    {
        private FileSizeCalculator FileSizeCalc { get; set; }

        public FileSizeConverter()
        {
            FileSizeCalc = new FileSizeCalculator();
            InitializeComponent();
        }

        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            if (FileSizeCalc.EnteredValue != "0")
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
            if (!FileSizeCalc.EnteredValue.Contains("."))
            {
                if (FileSizeCalc.EnteredValue == string.Empty || FileSizeCalc.EnteredValue == "0")
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

            FileSizeCalc.EnteredValue = "";
            FileSizeCalc.BValue = 0;
            FileSizeCalc.KbValue = 0;
            FileSizeCalc.MbValue = 0;
            FileSizeCalc.GbValue = 0;
            FileSizeCalc.TbValue = 0;
            txtDisplay.Text = "";
            lblBValue.Content = "";
            lblKbValue.Content = "";
            lblMbValue.Content = "";
            lblGbValue.Content = "";
            lblTbValue.Content = "";
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
            if (FileSizeCalc.EnteredValue == "0")
            {
                FileSizeCalc.EnteredValue = "";
            }

            if (txtDisplay.Text.Length < 16)
            {
                FileSizeCalc.EnteredValue += value;
                txtDisplay.Text = FileSizeCalc.EnteredValue;
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
            if (FileSizeCalc.EnteredValue == "" || FileSizeCalc.EnteredValue == ".")
            {
                return;
            }

            if (text == "Byte")
            {
                FileSizeCalc.BValue = Convert.ToDouble(FileSizeCalc.EnteredValue);
                FileSizeCalc.KbValue = FileSizeCalc.BToKb(FileSizeCalc.BValue);
                FileSizeCalc.MbValue = FileSizeCalc.BToMb(FileSizeCalc.BValue);
                FileSizeCalc.GbValue = FileSizeCalc.BToGb(FileSizeCalc.BValue);
                FileSizeCalc.TbValue = FileSizeCalc.BToTb(FileSizeCalc.BValue);
            }
            else if (text == "Kb")
            {
                FileSizeCalc.KbValue = Convert.ToDouble(FileSizeCalc.EnteredValue);
                FileSizeCalc.BValue = FileSizeCalc.KbToB(FileSizeCalc.KbValue);
                FileSizeCalc.MbValue = FileSizeCalc.KbToMb(FileSizeCalc.KbValue);
                FileSizeCalc.GbValue = FileSizeCalc.KbToGb(FileSizeCalc.KbValue);
                FileSizeCalc.TbValue = FileSizeCalc.KbToTb(FileSizeCalc.KbValue);

            }
            else if (text == "Mb")
            {
                FileSizeCalc.MbValue = Convert.ToDouble(FileSizeCalc.EnteredValue);
                FileSizeCalc.BValue = FileSizeCalc.MbToB(FileSizeCalc.MbValue);
                FileSizeCalc.KbValue = FileSizeCalc.MbToKb(FileSizeCalc.MbValue);
                FileSizeCalc.GbValue = FileSizeCalc.MbToGb(FileSizeCalc.MbValue);
                FileSizeCalc.TbValue = FileSizeCalc.MbToTb(FileSizeCalc.MbValue);

            }
            else if (text == "Gb")
            {
                FileSizeCalc.GbValue = Convert.ToDouble(FileSizeCalc.EnteredValue);
                FileSizeCalc.BValue = FileSizeCalc.GbToB(FileSizeCalc.GbValue);
                FileSizeCalc.KbValue = FileSizeCalc.GbToKb(FileSizeCalc.GbValue);
                FileSizeCalc.MbValue = FileSizeCalc.GbToMb(FileSizeCalc.GbValue);
                FileSizeCalc.TbValue = FileSizeCalc.GbToTb(FileSizeCalc.GbValue);

            }
            else if (text == "Tb")
            {
                FileSizeCalc.TbValue = Convert.ToDouble(FileSizeCalc.EnteredValue);
                FileSizeCalc.BValue = FileSizeCalc.TbToB(FileSizeCalc.TbValue);
                FileSizeCalc.KbValue = FileSizeCalc.TbToKb(FileSizeCalc.TbValue);
                FileSizeCalc.MbValue = FileSizeCalc.TbToMb(FileSizeCalc.TbValue);
                FileSizeCalc.GbValue = FileSizeCalc.TbToGb(FileSizeCalc.TbValue);
            }

            lblBValue.Content = FileSizeCalc.BValue.ToString();
            lblKbValue.Content = FileSizeCalc.KbValue.ToString();
            lblMbValue.Content = FileSizeCalc.MbValue.ToString();
            lblGbValue.Content = FileSizeCalc.GbValue.ToString();
            lblTbValue.Content = FileSizeCalc.TbValue.ToString();
        }
    }
}
