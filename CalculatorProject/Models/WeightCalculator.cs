using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.Models
{
    class WeightCalculator
    {
        public string EnteredValue { get; set; }
        public double MgValue { get; set; }
        public double GValue { get; set; }
        public double KgValue { get; set; }
        public double OzValue { get; set; }
        public double LbValue { get; set; }

        public WeightCalculator()
        {
            EnteredValue = "";
            MgValue = 0;
            GValue = 0;
            KgValue = 0;
            OzValue = 0;
            LbValue = 0;
        }

        public double MgToG(double weigth)
        {
            return weigth / 1000;
        }

        public double MgToKg(double weigth)
        {
            return weigth / 1000000;
        }

        public double MgToOz(double weigth)
        {
            return weigth / 28349.523125;
        }

        public double MgToLb(double weigth)
        {
            return weigth / 453592.37;
        }

        public double GToMg(double weigth)
        {
            return weigth * 1000;
        }

        public double GToKg(double weigth)
        {
            return weigth / 1000;
        }

        public double GToOz(double weigth)
        {
            return weigth / 28.349523125;
        }

        public double GToLb(double weigth)
        {
            return weigth / 453.59237;
        }

        public double KgToMg(double weigth)
        {
            return weigth * 1000000;
        }

        public double KgToG(double weigth)
        {
            return weigth * 1000;
        }

        public double KgToOz(double weigth)
        {
            return weigth * 35.274;
        }

        public double KgToLb(double weigth)
        {
            return weigth * 2.205;
        }

        public double OzToMg(double weigth)
        {
            return weigth * 28349.523125;
        }

        public double OzToG(double weigth)
        {
            return weigth * 28.349523125;
        }

        public double OzToKg(double weigth)
        {
            return weigth / 35.274;
        }

        public double OzToLb(double weigth)
        {
            return weigth / 16;
        }

        public double LbToMg(double weigth)
        {
            return weigth * 453592.37;
        }

        public double LbToG(double weigth)
        {
            return weigth * 453.59237;
        }

        public double LbToKg(double weigth)
        {
            return weigth / 2.205;
        }

        public double LbToOz(double weigth)
        {
            return weigth * 16;
        }
    }
}
