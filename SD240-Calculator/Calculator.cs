using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD240_Calculator
{
    public class Calculator
    {
        public string StoredValue { get; set; }
        public string Operator { get; set; }
        public string EnteredValue { get; set; }

        public Calculator()
        {
            EnteredValue = "";
            StoredValue = "";
            Operator = "";
        }
    }
}
