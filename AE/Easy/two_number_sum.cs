using System;
using System.Collections.Generic;

public class Program {
	public static int[] TwoNumberSum(int[] array, int targetSum) {
		for (int i = 0; i < array.Length - 1; i++)
		{
			for (int j = i + 1; j < array.Length; j++) 
			{
				if (array[i] + array[j] == targetSum) 
				{
					return new int[] {array[i], array[j]};
				}
			}
		}
		return new int[0];
	}
}


public class Program {
	public static int[] TwoNumberSum(int[] array, int targetSum) {
		HashSet<int> nums = new HashSet<int>();
		foreach (int num in array)
		{
			int potentialMatch = targetSum - num;
			if (nums.Contains(potentialMatch))
				return new int[] {num, potentialMatch};
			else nums.Add(num);
		}
		return new int[0];
	}
}


public class Program {
	public static int[] TwoNumberSum(int[] array, int targetSum) {
		var sortedArr = new int[array.Length];
		Array.Copy(array, sortedArr, array.Length);
		Array.Sort(sortedArr);
		var leftIndex = 0;
		var rightIndex = array.Length - 1;
		while (leftIndex != rightIndex)
		{
			var sum = sortedArr[leftIndex] + sortedArr[rightIndex];
			if (sum == targetSum)
				return new int[] {sortedArr[leftIndex], sortedArr[rightIndex]};
			else if (sum < targetSum)
				leftIndex++;
			else if (sum > targetSum)
				rightIndex--;
		}
		return new int[0];
	}
}
