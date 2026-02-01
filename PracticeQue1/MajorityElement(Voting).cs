using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.PracticeQue1
{
    public class MajorityElement_Voting_
    {
        public static void Run()
        {
            int[] nums = {2,2,1,1,1,2,2 };
            int count = 0;
            int candidate = nums[0];

            for(int i = 0; i < nums.Length; i++)
            {
                if (count == 0)
                {
                    candidate = nums[i];
                }
                if (nums[i] == candidate)
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
