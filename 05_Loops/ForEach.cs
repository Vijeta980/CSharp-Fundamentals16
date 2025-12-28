using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundamentals._05_Loops
{
    class ForEach
    {
        public static void loop2()
        {
            var name = "John Smith"; //Like a list

            for(var i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            //forEach//////

            foreach(var character in name)
            {
                Console.WriteLine(character);
            }

            var nums = new int[] { 1, 2, 3,4};

            foreach(var number in nums)
            {
                Console.WriteLine(number);
            }

        }
    }
}
