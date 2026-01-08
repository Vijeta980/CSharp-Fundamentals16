using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.PracticeQue1
{
    public class MovesZeroes
    {
        public static void Run()
        {
            int[] nums = { 0, 1, 0, 3, 12  };

            int i = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] != 0)
                {
                    nums[i] = nums[j];
                    i++;

                }

            }

            //while (i < nums.Length)
            //{
            //    nums[i] = 0;
            //    i++;
            //}
            for (int k = i; k < nums.Length; k++)
            {
                nums[k] = 0;
            }
            foreach (var n in nums)
            {
                Console.Write(n + " ");
            }
        }
    }
}
