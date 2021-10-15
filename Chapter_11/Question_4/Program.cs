using System;

namespace Question_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int milliSeconds = Environment.TickCount;
            TimeSpan timeSpan = TimeSpan.FromMilliseconds(milliSeconds);
            string upTime = string.Format("Last boot was {0} days {1} hours and {2} minutes ago",
                                          timeSpan.Days,
                                          timeSpan.Hours,
                                          timeSpan.Minutes);
            Console.WriteLine(upTime);
        }
    }
}
