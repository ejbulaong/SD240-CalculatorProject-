using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.Models
{
    public class TimeCalculator
    {
        public string EnteredValue { get; set; }
        public string HoursValue { get; set; }
        public string MinsValue { get; set; }
        public string SecsValue { get; set; }

        public TimeCalculator()
        {
            EnteredValue = "";
            HoursValue = "";
            MinsValue = "";
            SecsValue = "";
        }

        public double HourToSecond(double hour)
        {
            return hour * 3600;
        }

        public double HourToMinute(double hour)
        {
            return hour * 60;
        }

        public double MinuteToSecond(double min)
        {
            return min * 60;
        }

        public double MinuteToHour(double min)
        {
            return min / 60;
        }

        public double SecondToHour(double sec)
        {
            return sec / 3600;
        }

        public double SecondToMinute(double sec)
        {
            return sec / 60;
        }
    }
}
