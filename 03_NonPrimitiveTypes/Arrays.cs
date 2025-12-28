using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundamentals._03_NonPrimitiveTypes
{
    class Arrays
    {
        public static void ShowArrays()
        {
            int[] arr = { 10, 20, 30, 40, 50 };
            Console.WriteLine("Arrays elements:");
            
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
