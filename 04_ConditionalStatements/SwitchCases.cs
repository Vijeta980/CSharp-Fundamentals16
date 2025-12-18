using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundamentals._04_ConditionalStatements
{
    class SwitchCases
    {
        public static void ShowCases()
        {
            var season = Sw2.Autumn;

           /* switch (season)
            {
                case Sw2.Autumn:    
                    Console.WriteLine("Hi!Winter");
                    break;

                case Sw2.Summer:
                    Console.WriteLine("It's summer season");
                    break;

                default:
                    Console.WriteLine("I don't understand season");
                    break;

            }*/

            switch(season)
            {
                case Sw2.Autumn:
                case Sw2.Summer:
                    Console.WriteLine("got the season");
                    break;
                
                    default:
                    Console.WriteLine("Didn't got");
                    break;
            }

        }
    }
}
