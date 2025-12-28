using System;
using System.Collections.Generic;
using System.Text;


//Syntax
namespace CSharpFundamentals._06_ArraysAndLists
{
    internal class ArraysBasic
    {
        public static void Run()
        {
            int[] num = { 1, 2, 3, 4, 5 };

            Console.WriteLine( "Array elements are:");
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }
            }
    }
}
