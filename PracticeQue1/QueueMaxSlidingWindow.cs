using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.PracticeQue1
{
    public class QueueMaxSlidingWindow
    {
        public static void Run()
        {
                int[] nums = { 1, 3, -1, -3, 5, 3, 6, 7 };
            int k = 3;
            List<int> result = new List<int>();
            LinkedList<int> deque = new LinkedList<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (deque.Count > 0 && deque.First.Value <= i - k)
                {
                    deque.RemoveFirst();
                }
                while (deque.Count > 0 && nums[deque.Last.Value] < nums[i])
                {
                    deque.RemoveLast();
                }
                deque.AddLast(i);
                if (i >= k - 1)
                {
                    result.Add(nums[deque.First.Value]);
                }
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
