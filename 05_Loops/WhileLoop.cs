using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundamentals._05_Loops
{
    class WhileLoop
    {
        public static void loop3()
        {
            var i = 0;

            while (i <= 10)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                    i++;
                }
            }
        }
    }
}
