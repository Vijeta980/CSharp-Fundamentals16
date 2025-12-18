using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundamentals._04_ConditionalStatements
{
    class Conditions
    {
        public static void ShowCondition() {
            int num = 95;

            if (num >= 90 && num < 100) {
                Console.WriteLine("Grade A");
            }
            else if(num>=80 && num < 90)
            {
                Console.WriteLine("Grade B");
            }
            else
            {
                Console.WriteLine("Grade C");
            }
        }
    }
}
