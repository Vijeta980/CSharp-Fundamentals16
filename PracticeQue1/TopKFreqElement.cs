using System;
using System.Collections.Generic;
using System.Linq;

public class TopKFreqElement
{
    public static void Run()
    {
        int[] nums = { 1, 1, 1, 2, 2, 3 };
        int k = 2;

        int[] result = TopKFrequentElements(nums, k);

        foreach (int num in result)
        {
            Console.WriteLine(num);
        }
    }

    public static int[] TopKFrequentElements(int[] nums, int k)
    {
        // Step 1: Count frequency
        Dictionary<int, int> freqMap = new Dictionary<int, int>();

        foreach (int num in nums)
        {
            if (freqMap.ContainsKey(num))
                freqMap[num]++;
            else
                freqMap[num] = 1;
        }

        // Step 2: Min Heap (SortedSet)
        SortedSet<(int freq, int num)> minHeap = new SortedSet<(int, int)>();

        foreach (var kvp in freqMap)
        {
            minHeap.Add((kvp.Value, kvp.Key));

            if (minHeap.Count > k)
                minHeap.Remove(minHeap.Min);
        }

        // Step 3: Extract result
        return minHeap.Select(x => x.num).ToArray();
    }
}
