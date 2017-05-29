using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WantedEvent.Conventers
{
    class StringToTimeSpanConventer
    {
        public TimeSpan StringToTimeSpan(string getTime)
        {
            TimeSpan resultTime;

            resultTime = TimeSpan.Parse(getTime);

            return resultTime;
        }
    }

    class TimeCalculate
    {
        public TimeSpan CalculateTime(TimeSpan startTime, TimeSpan endTime)
        {
            TimeSpan calculatedTime;

            calculatedTime.Add(endTime);
            calculatedTime.Subtract(startTime);

            return calculatedTime;
        }
    }
}
