using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject
{
    public class StandardCalculator
    {
        public string StoredValue { get; set; }
        public string Operator { get; set; }
        public string EnteredValue { get; set; }

        public StandardCalculator()
        {
            EnteredValue = "";
            StoredValue = "";
            Operator = "";
        }
    }
}
