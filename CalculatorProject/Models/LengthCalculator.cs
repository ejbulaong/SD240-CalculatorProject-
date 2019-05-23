using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.Models
{
    public class LengthCalculator
    {
        public string EnteredValue { get; set; }
        public double MmValue { get; set; }
        public double CmValue { get; set; }
        public double MValue { get; set; }
        public double KmValue { get; set; }
        public double InValue { get; set; }
        public double FtValue { get; set; }

        public LengthCalculator()
        {
            EnteredValue = "";
            MmValue = 0;
            CmValue = 0;
            MValue = 0;
            KmValue = 0;
            InValue = 0;
            FtValue = 0;
        }

        public double MmToCm(double length)
        {
            return length / 10;
        }

        public double MmToM(double length)
        {
            return length / 1000;
        }

        public double MmToKm(double length)
        {
            return length / 1000000;
        }

        public double MmToIn(double length)
        {
            return length / 25.4;
        }

        public double MmToFt(double length)
        {
            return length / 304.8;
        }

        public double CmToMm(double length)
        {
            return length * 10;
        }

        public double CmToM(double length)
        {
            return length / 100;
        }

        public double CmToKm(double length)
        {
            return length / 100000;
        }

        public double CmToIn(double length)
        {
            return length / 2.54;
        }

        public double CmToFt(double length)
        {
            return length / 30.48;
        }

        public double MToMm(double length)
        {
            return length * 1000;
        }

        public double MToCm(double length)
        {
            return length * 100;
        }

        public double MToKm(double length)
        {
            return length / 1000;
        }

        public double MToIn(double length)
        {
            return length * 39.37;
        }

        public double MToFt(double length)
        {
            return length * 3.281;
        }

        public double KmToMm(double length)
        {
            return length * 1000000;
        }

        public double KmToCm(double length)
        {
            return length * 100000;
        }

        public double KmToM(double length)
        {
            return length * 1000;
        }

        public double KmToIn(double length)
        {
            return length * 39370.079;
        }

        public double KmToFt(double length)
        {
            return length * 3280.84;
        }

        public double InToMm(double length)
        {
            return length * 25.4;
        }

        public double InToCm(double length)
        {
            return length * 2.54;
        }

        public double InToM(double length)
        {
            return length / 39.37;
        }

        public double InToKm(double length)
        {
            return length / 39370.079;
        }

        public double InToFt(double length)
        {
            return length / 12;
        }

        public double FtToMm(double length)
        {
            return length * 304.8;
        }

        public double FtToCm(double length)
        {
            return length * 30.48;
        }

        public double FtToM(double length)
        {
            return length / 3.281;
        }

        public double FtToKm(double length)
        {
            return length / 3280.84;
        }

        public double FtToIn(double length)
        {
            return length * 12;
        }
    }
}
