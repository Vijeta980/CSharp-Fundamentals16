using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*1 - Write a program and ask the user to enter a number. 
 * The number should be between 1 to 10. If the user enters a valid number, display "Valid" 
 * on the console. Otherwise, display "Invalid". 
 * (This logic is used a lot in applications where values 
 * entered into input boxes need to be validated.)
 */

namespace CSharp_Fundamentals.PracticeQue1
{
    class Prog1
    {
        public static void prac()
        {
            int num = 5;

            if (num > 1 && num < 10)
            {
                Console.WriteLine("Valid");

            }
            else
            {
                Console.WriteLine("Invalid");
            }

        }
    }
}
