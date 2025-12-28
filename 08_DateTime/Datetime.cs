using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals._08_DateTime
{
    internal class Datetime
    {
        public static void Run()
        {
            //Current date and time
            DateTime now = DateTime.Now;
            Console.WriteLine("Now: "+now);

            //Current date only
            DateTime today = DateTime.Today;
            Console.WriteLine("Today: "+today);

            //Specific date
            DateTime myAdmissiondate = new DateTime(2024, 09, 15);
            Console.WriteLine("Admission date: "+myAdmissiondate);

            //Others
            Console.WriteLine("Year:"+now.Year);
            Console.WriteLine("Month:" + now.Month);
            Console.WriteLine("Day:" + now.Day);
            Console.WriteLine("Hour:" + now.Hour);
            Console.WriteLine("Minute:" + now.Minute);
            Console.WriteLine("Second:" + now.Second);

            //Formatting date and time
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToLongTimeString());

            //Custom Format
            Console.WriteLine(now.ToString("dd/MM/yyyy HH:mm:ss"));

            //DateTime Calculations

            DateTime todayy=DateTime.Today;
            DateTime tom = todayy.AddDays(1);
            DateTime nextweek = todayy.AddDays(7);
            DateTime lastMonth = todayy.AddMonths(-1);

            Console.WriteLine("Tomorrow: "+tom);
            Console.WriteLine("Next week: "+nextweek);
            Console.WriteLine("Last Month: "+lastMonth);



        }
    }
}
