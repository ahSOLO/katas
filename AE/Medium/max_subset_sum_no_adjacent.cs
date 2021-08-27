using System;

public class Program {
	public static int MaxSubsetSumNoAdjacent(int[] array) {
		// Deal with edge cases where array length is 1 or less
		int len = array.Length;
		if (array.Length == 0)
			return 0;
		else if (array.Length ==1)
			return array[0];		
		// Determine the max sum
		int[] maxSumArr = new int[array.Length];
		maxSumArr[0] = array[0];
		maxSumArr[1] = Math.Max(array[0], array[1]);
		for	(int i = 2; i < array.Length; i++)
		{
			int maxSum = Math.Max(maxSumArr[i - 2] + array[i], maxSumArr[i - 1]);
			maxSumArr[i] = maxSum;
		}
		return maxSumArr[array.Length - 1];
	}
}
