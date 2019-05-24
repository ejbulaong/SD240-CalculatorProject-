using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.Models
{
    public class PercentageCalculator
    {
        public string EnteredValue { get; set; }
        public double DecimalValue { get; set; }
        public double PercentageValue { get; set; }

        public PercentageCalculator()
        {
            EnteredValue = "";
            DecimalValue = 0;
            PercentageValue = 0;
        }

        public double DecToPercent(double dec)
        {
            return dec * 100;
        }

        public double PercentToDec(double perc)
        {
            return perc / 100;
        }
    }
}
