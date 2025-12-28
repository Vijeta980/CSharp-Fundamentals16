using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundamentals._04_ConditionalStatements
{
    class booleanWays
    {
        public static void ShowBool()
        {
            bool isGoldCustomer = true;

           /* float price;
            if (isGoldCustomer)

                price = 95.5f;

            else

                price = 25.5f;*/


            float price = (isGoldCustomer) ? 95 : 25;

            Console.WriteLine(price);
        }

    }
}
