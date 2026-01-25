using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.PracticeQue1
{
    public class MajorityElement
    {
        public static void Run()
        {
            int count = 0;
            int candidate = -1;
            int[] arr = { 2, 2, 1, 1, 1, 2, 2 ,1,1};

            for (int i = 0; i < arr.Length; i++)
            {
                if (count == 0)
                {
                    candidate = arr[i];
                }
                if (arr[i] == candidate)
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }
            Console.WriteLine(candidate);
        }
    }
}
