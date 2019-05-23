using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.Models
{
    public class FileSizeCalculator
    {
        public string EnteredValue { get; set; }
        public double BValue { get; set; }
        public double KbValue { get; set; }
        public double MbValue { get; set; }
        public double GbValue { get; set; }
        public double TbValue { get; set; }

        public FileSizeCalculator()
        {
            EnteredValue = "";
            BValue = 0;
            KbValue = 0;
            MbValue = 0;
            GbValue = 0;
            TbValue = 0;
        }

        public double BToKb(double ds)
        {
            return ds / 1000;
        }

        public double BToMb(double ds)
        {
            return ds / 1000000;
        }

        public double BToGb(double ds)
        {
            return ds / 1000000000 ;
        }

        public double BToTb(double ds)
        {
            return ds / 1000000000000;
        }

        public double KbToB(double ds)
        {
            return ds * 1000;
        }

        public double KbToMb(double ds)
        {
            return ds / 1000;
        }

        public double KbToGb(double ds)
        {
            return ds / 1000000;
        }

        public double KbToTb(double ds)
        {
            return ds / 1000000000;
        }

        public double MbToB(double ds)
        {
            return ds * 1000000;
        }

        public double MbToKb(double ds)
        {
            return ds * 1000;
        }

        public double MbToGb(double ds)
        {
            return ds / 1000;
        }

        public double MbToTb(double ds)
        {
            return ds / 1000000;
        }

        public double GbToB(double ds)
        {
            return ds * 1000000000;
        }

        public double GbToKb(double ds)
        {
            return ds * 1000000;
        }

        public double GbToMb(double ds)
        {
            return ds * 1000;
        }

        public double GbToTb(double ds)
        {
            return ds / 1000;
        }

        public double TbToB(double ds)
        {
            return ds * 1000000000000;
        }

        public double TbToKb(double ds)
        {
            return ds * 1000000000;
        }

        public double TbToMb(double ds)
        {
            return ds * 1000000;
        }

        public double TbToGb(double ds)
        {
            return ds * 1000;
        }
    }
}
