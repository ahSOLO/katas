// Brute force -- recursively calculate every final destination and see if we can reach the last index
// optimization -- store whether each index can reach the final destination
// optimization -- start from the final destination and work backwards
// optimization -- don't need to store array of jumpable-to-end indexes, just need to track the nearest goal

// O(1) space
// O(n) time

public class Solution {
    public bool CanJump(int[] nums) {
        int nearestGoal = nums.Length - 1;
        for (int i = nums.Length - 2; i >= 0; i--)
        {
            if (i + nums[i] >= nearestGoal)
            {
                nearestGoal = i;
            }
        }
        return nearestGoal == 0;
    }
}