public class Solution {
    public int MaxSubArray(int[] nums) {
        int maxSum = nums[0];
        int curSum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            curSum += nums[i];
            maxSum = Math.Max(maxSum, curSum);
            if (curSum < 0)
            {
                curSum = 0;
            }
        }
        return maxSum;
    }
}