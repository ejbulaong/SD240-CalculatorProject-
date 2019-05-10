using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.Models
{
    public class TemperatureCalculator
    {
        public string EnteredValue { get; set; }
        public double CelsiusValue { get; set; }
        public double FahrenheitValue { get; set; }

        public TemperatureCalculator()
        {
            EnteredValue = "";
            CelsiusValue = 0;
            FahrenheitValue = 0;
        }

        public double CelsiusToFahrenheit(double temp)
        {
            return (temp * 9 / 5) + 32;
        }

        public double FahrenheitToCelsius(double temp)
        {
            return (temp - 32) * 5 / 9;
        }
    }
}
