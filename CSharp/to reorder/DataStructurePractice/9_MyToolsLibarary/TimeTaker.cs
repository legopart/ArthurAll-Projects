using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyToolsLibarary
{
    public class TimeTaker
    {
        private DateTime dt1 { get; set; }
        private DateTime dt2 { get; set; }
        private TimeSpan ts1 { get; set; }
        private TimeSpan ts2 { get; set; }

        public TimeTaker()
        {
            dt1 = DateTime.Now;
            dt2 = DateTime.Now;
        }

        public void Start()
        {
            dt1 = DateTime.Now;
        }
        public void Stop()
        {
            dt2 = DateTime.Now;
        }

        public double GetDiff()
        {
            ts1 = new TimeSpan(dt1.Ticks);
            ts2 = new TimeSpan(dt2.Ticks);
            return (ts2 - ts1).TotalMilliseconds;
        }
    }
}
