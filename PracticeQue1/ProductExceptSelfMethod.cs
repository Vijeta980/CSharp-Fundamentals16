using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.PracticeQue1
{
    public class ProductExceptSelfMethod
    {
        public static void Run()
        {
            int[] nums = { 1, 2, 3, 4 };
            int[] result = ProductExceptSelf(nums);

            foreach (int num in result)
            {
                Console.Write(num + " ");
            }
        }
            public static int[] ProductExceptSelf(int[] nums)
        {
            int n = nums.Length;
            int[] result = new int[n];

            result[0] = 1;
            for(int i=1;i<n; i++)
            {
                result[i] = result[i - 1] * nums[i - 1];
            }

            int rightProduct = 1;
            for(int i=n-1; i>=0; i--)
            {
                result[i] *= rightProduct;
                rightProduct *= nums[i];
            }
            return result;
        }
    }
}
