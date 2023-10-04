public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> numMap = new Dictionary<int, int>();
        foreach (int num in nums)
        {
            if (numMap.ContainsKey(num))
            {
                numMap[num]++;
            }
            else
            {
                numMap[num] = 1;
            }
        }

        PriorityQueue<int, int> numPQ = new PriorityQueue<int, int>();
        foreach (int num in numMap.Keys)
        {
            numPQ.Enqueue(num, numMap[num]);
            if (numPQ.Count > k)
            {
                numPQ.Dequeue();
            }
        }
        int[] output = new int[k];
        for (int i = k - 1; i >= 0; i--)
        {
            output[i] = numPQ.Dequeue();
        }
        return output;
    }
}