using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WantedEvent
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            StringToTimeSpanConventer stringToTimeSpanConventer = new StringToTimeSpanConventer();
            var a = stringToTimeSpanConventer.StringToTimeSpan("18:00");
            var b = stringToTimeSpanConventer.StringToTimeSpan("20:00");

            TimeCalculate timeCalculate = new TimeCalculate();
            var c = timeCalculate.CalculateTime(a,b);

            time.Text = c.ToString();
        }
    }

    internal class StringToTimeSpanConventer
    {
        public TimeSpan StringToTimeSpan(string getTime)
        {
            TimeSpan resultTime;

            resultTime = TimeSpan.Parse(getTime);

            return resultTime;
        }
    }

    internal class TimeCalculate
    {
        public TimeSpan CalculateTime(TimeSpan startTime, TimeSpan endTime)
        {
            TimeSpan calculatedTime = endTime;

            return calculatedTime.Subtract(startTime);           
        }
    }
}
