using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_14_b
{
    public class Call
    {
        public DateTime DateTime { get; set; }
        public TimeSpan Duration { get; set; }

        public Call(DateTime dateTime, TimeSpan duration)
        {
            this.DateTime = dateTime;
            this.Duration = duration;
        }
    }
}
