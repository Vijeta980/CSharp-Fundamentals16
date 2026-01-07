using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.PracticeQue1
{
    public class RemoveDuplicates
    {
        public static void Run()
        {
            int[] input = { 1, 2, 2, 3, 4, 4, 5 }; 

            HashSet<int> uniqueSet = new HashSet<int>();

            for (int i = 0; i < input.Length; i++)
            {
                uniqueSet.Add(input[i]);
            }
            foreach(var n in uniqueSet)
            {
                Console.Write(n + " ");
            }


        }
    }
}
