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
        public double HoursValue { get; set; }
        public double MinsValue { get; set; }
        public double SecsValue { get; set; }

        public TimeCalculator()
        {
            EnteredValue = "";
            HoursValue = 0;
            MinsValue = 0;
            SecsValue = 0;
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
