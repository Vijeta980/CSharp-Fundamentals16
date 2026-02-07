using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.PracticeQue1
{
    public class TopKFrequentElements
    {
        public static void Run()
        {
            int[] nums = { 1, 1, 1, 2, 2, 3 };
            int k = 2;
            var result = TopKFrequent(nums, k);
            Console.WriteLine(string.Join(", ", result));
        }

        public static int[] TopKFrequent(int[] nums, int k)
        {
            var frequencyMap = new Dictionary<int, int>();
            // Count the frequency of each element
            foreach (var num in nums)
            {
                if (frequencyMap.ContainsKey(num))
                    frequencyMap[num]++;
                else
                    frequencyMap[num] = 1;
            }
            // Use a min-heap to keep track of the top k elements
            var minHeap = new SortedSet<(int Frequency, int Number)>();
            foreach (var kvp in frequencyMap)
            {
                minHeap.Add((kvp.Value, kvp.Key));
                if (minHeap.Count > k)
                    minHeap.Remove(minHeap.Min);
            }
            return minHeap.Select(x => x.Number).ToArray();
        }
    }
}
