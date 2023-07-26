public class Solution {
    public Dictionary<int, int> memo = new Dictionary<int, int>();

    public int Rob(int[] nums) 
    {
        if (nums.Length == 0)
        {
            return 0;
        }    

        if (nums.Length == 1)
        {
            return nums[0];
        }

        return Math.Max(Dp(0, nums), Dp(1, nums));
    }

    public int Dp(int idx, int[] nums)
    {
        if (memo.ContainsKey(idx))
        {
            return memo[idx];
        }

        if (nums.Length <= idx + 2)
        {
            memo[idx] = nums[idx];
            return nums[idx];
        }
        if (nums.Length == idx + 3)
        {
            memo[idx] = nums[idx] + Dp(idx + 2, nums);
            return memo[idx];
        }
        memo[idx] = Math.Max(nums[idx] + Dp(idx + 2, nums), nums[idx] + Dp(idx + 3, nums));
        return memo[idx];
    }
}