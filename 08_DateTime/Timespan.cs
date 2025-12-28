using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals._08_DateTime
{
    internal class Timespan
    {
        public static void Run()
        {
            //Creating
            TimeSpan timespan1 = new TimeSpan(1,2,30);
            Console.WriteLine(timespan1);

            //Using
            TimeSpan timespan2 = TimeSpan.FromHours(2);
            TimeSpan timespan3 = TimeSpan.FromMinutes(90);
            TimeSpan timespan4 = TimeSpan.FromDays(1);

            Console.WriteLine(timespan2);
            Console.WriteLine(timespan3);
            Console.WriteLine(timespan4);

            //Properties of TimeSpan
            TimeSpan ts = new TimeSpan(1, 30, 45);
            Console.WriteLine("Hours: "+ts.Hours);
            Console.WriteLine("Minutes: "+ts.Minutes);
            Console.WriteLine("Seconds: "+ts.Seconds);

            Console.WriteLine("Total hours: "+ts.TotalHours);
            Console.WriteLine("Total minutes: "+ts.TotalMinutes);
            Console.WriteLine("Total seconds: "+ts.TotalSeconds);
        }
    }
}
