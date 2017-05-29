using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WantedEvent.Conventers;
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

            time.Text = timeCalculate.CalculateTime(a, b).ToString();
        }
    }
}
