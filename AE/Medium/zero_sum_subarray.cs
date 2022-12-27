using System;
using System.Collections.Generic;

public class Program {
	public bool ZeroSumSubarray(int[] nums) {
        if (nums.Length == 0)
            return false;

        if (nums[0] == 0)
            return true;
        
		HashSet<int> sums = new HashSet<int>();
        int currentSum = nums[0];
        sums.Add(nums[0]);
        for (int i = 1; i < nums.Length; i++)
        {
            currentSum = currentSum + nums[i];
            
            if (sums.Add(currentSum) == false || currentSum == 0)
                return true;
        }
		return false;
	}
}