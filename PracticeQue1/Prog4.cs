using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*4- Your job is to write a program for a speed camera. For simplicity, ignore the details 
 * such as camera, sensors, etc and focus purely on the logic. Write a program that asks 
 * the user to enter the speed limit. Once set, the program asks for the speed of a car. 
 * If the user enters a value less than the speed limit, program should display Ok on the 
 * console. If the value is above the speed limit, the program should calculate the number 
 * of demerit points. For every 5km/hr above the speed limit, 1 demerit points should be 
 * incurred and displayed on the console. If the number of demerit points is above 12, the
 * program should display License Suspended.*/


namespace CSharp_Fundamentals.PracticeQue1
{
    class Prog4
    {
        public static void prac4()
        {
            int speedlimit = 60;
            var carspeed = 2000;

            if (carspeed < speedlimit)
            {
                Console.WriteLine("OK");
            }
            else if(carspeed>speedlimit)
            {
                int value = carspeed - speedlimit;
                int dem = value / 5;
                Console.WriteLine(dem);
                if (dem > 12)
                {
                    Console.WriteLine("License Suspended");
                }

            }
        }
    }
}
