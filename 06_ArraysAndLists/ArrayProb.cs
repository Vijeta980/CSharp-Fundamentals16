using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals._06_ArraysAndLists
{
    internal class ArrayProb
    {
        public static void Run()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 0};

            int max = arr[0];
            int min = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                else
                {
                    min = arr[i];
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(min);
        }
    }
}
