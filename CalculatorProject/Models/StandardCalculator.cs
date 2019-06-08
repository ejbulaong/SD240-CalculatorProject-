using System;
using System.Collections.Generic;
using System.Data;
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

        public void Evaluate(string op)
        {
            Operator = op;

            if (StoredValue == "")
            {
                StoredValue = EnteredValue;
            }
            else if (StoredValue != "" && EnteredValue != "")
            {
                if (Operator == "^")
                {
                    StoredValue = Math.Pow(Convert.ToDouble(StoredValue),
                        Convert.ToDouble(EnteredValue)).ToString();
                }
                else if ((Operator == "Mod"))
                {
                    StoredValue = (Convert.ToDouble(StoredValue) % Convert.ToDouble(EnteredValue)).ToString();
                }
                else
                {
                    var expression = StoredValue + Operator + EnteredValue;
                    double answer;
                    answer = Convert.ToDouble(new DataTable().Compute(expression, null));
                    StoredValue = answer.ToString();
                }
            }

            EnteredValue = "";
        }
    }
}
