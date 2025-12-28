using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals._07_StringsBasic
{
    internal class StringBasic
    {
        public static void Run()
        {
            string name = "     Vijeta Yadav      ";

            Console.WriteLine("Original:"+name);
            Console.WriteLine("Upper:" + name.ToUpper());
            Console.WriteLine("Lower:" + name.ToLower());
            Console.WriteLine("Trim:" + name.Trim());
            Console.WriteLine("Length:" + name.Length);
        }
    }
}
