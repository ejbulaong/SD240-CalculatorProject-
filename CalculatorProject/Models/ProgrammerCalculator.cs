using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject
{
    public class ProgrammerCalculator
    {
        public string EnteredValue { get; set; }
        public string HexValue { get; set; }
        public string OctValue { get; set; }
        public string BinValue { get; set; }


        public ProgrammerCalculator()
        {
            EnteredValue = "";
            HexValue = "";
            OctValue = "";
            BinValue = "";
        }

        public string ConvertToBin(long number)
        {
            return Convert.ToString(number, 2);
        }

        public string ConvertToOct(long number)
        {
            return Convert.ToString(number, 8);
        }

        public string ConvertToHex(long number)
        {
            return Convert.ToString(number, 16).ToUpper();
        }
    }
}
