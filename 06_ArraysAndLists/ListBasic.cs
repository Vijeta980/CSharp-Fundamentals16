using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals._06_ArraysAndLists
{
    internal class ListBasic
    {
        public static void Run()
        {
            List<int> numbers = new List<int>();

            numbers.Add(0);
            numbers.Add(1);
            numbers.Add(2);
            numbers.Remove(2);


            Console.WriteLine("List elements:");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("Count: " + numbers.Count);

        }
    }
}
