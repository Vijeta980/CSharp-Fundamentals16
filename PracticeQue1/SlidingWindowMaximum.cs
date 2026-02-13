using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.PracticeQue1
{
   
        public class SlidingWindowMaximum
        {
            public static void Run()
            {
                int[] nums = { 1, 3, -1, -3, 5, 3, 6, 7 };
                int k = 3;

                int[] result = MaxSlidingWindow(nums, k);

                Console.WriteLine(string.Join(", ", result));
            }

            public static int[] MaxSlidingWindow(int[] nums, int k)
            {
                if (nums.Length == 0) return new int[0];

                int n = nums.Length;
                int[] result = new int[n - k + 1];

                LinkedList<int> deque = new LinkedList<int>(); 
                for (int i = 0; i < n; i++)
                {
                    // 1️⃣ Remove elements outside window
                    if (deque.Count > 0 && deque.First.Value <= i - k)
                        deque.RemoveFirst();

                    // 2️⃣ Remove smaller elements from back
                    while (deque.Count > 0 && nums[deque.Last.Value] < nums[i])
                        deque.RemoveLast();

                    // 3️⃣ Add current index
                    deque.AddLast(i);

                    // 4️⃣ Add max to result (when window is valid)
                    if (i >= k - 1)
                        result[i - k + 1] = nums[deque.First.Value];
                }

                return result;
            }
        }
    }
