using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.PracticeQue1
{
    public class RemoveDuplicates
    {
        public static int Run()
        {
            int[] input = { 1, 2, 2, 3, 4, 4, 5 };

            //Extra space approach

            //HashSet<int> uniqueSet = new HashSet<int>();

            //for (int i = 0; i < input.Length; i++)
            //{
            //    uniqueSet.Add(input[i]);
            //}
            //foreach(var n in uniqueSet)
            //{
            //    Console.Write(n + " ");
            //}

            //In-place approach

            if(input.Length == 0)
            {
                return 0;
            }
            int i = 0;
            for(int j=1;j<input.Length;j++)
            {
                if (input[j] != input[i])
                {
                    i++;
                    input[i] = input[j];
                }
            }
            int k = i + 1;

            for (int x = 0; x < k; x++)
            {
                Console.Write(input[x] + " ");
            }

            return k;
        }
        
    }
}
