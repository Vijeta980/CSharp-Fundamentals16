using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.PracticeQue1
{
    public class ContainsDuplicate
    {
        public static void Run()
        {
            int[] nums = { 1, 2, 3, 1 };
            bool result = ContainsDuplicateMethod(nums);
            Console.WriteLine(result);
        }

        public static bool ContainsDuplicateMethod(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();

            foreach (int num in nums)
            {
                if (set.Contains(num))
                {
                    return true; 
                }
                set.Add(num);
            }

            return false; 
        }
    }
}
