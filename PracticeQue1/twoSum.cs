using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.PracticeQue1
{
    public class twoSum
    {
        public static void Run()
        {
          int[] nums= { 2, 7, 11, 15 };
            int target = 9;

            int[] result = TwoSumMethod(nums, target);
            Console.WriteLine($"Indices: {result[0]}, {result[1]}");
        }

        //    for(int i=0;i<nums.Length;i++)
        //    {
        //        for(int j=i+1;j<nums.Length;j++)
        //        {
        //            if(nums[i]+nums[j]==target)
        //            {
        //                Console.WriteLine($"Indices: {i}, {j}");
        //                return;
        //            }
        //        }
        //    }
        //}


        //Another

        public static int[] TwoSumMethod(int[] nums, int target)
        {
            Dictionary<int, int> numDict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                if (numDict.ContainsKey(complement))
                {
                    return new int[] { numDict[complement], i };
                }

                numDict[nums[i]] = i;
            }

            return new int[] { };
        }
    }
}

