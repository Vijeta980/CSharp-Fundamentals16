using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*2- Write a program which takes two numbers from the console and displays the maximum 
 * of the two.
 * */

namespace CSharp_Fundamentals.PracticeQue1
{
    class Prog2
    {
        public static void prac2()
        {
            int num1 = 10;
            int num2 = 50;

            if (num1 > num2)
            {
                Console.WriteLine(num1);
            }
            else
            {
                Console.WriteLine(num2);
            }
        }
    }
}
