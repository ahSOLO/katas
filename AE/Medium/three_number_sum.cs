using System;
using System.Collections.Generic;

public class Program {
	public static List<int[]> ThreeNumberSum(int[] array, int targetSum) {
		List<int[]> sums = new List<int[]>();
		Array.Sort(array);
		for (int leftPtr = 0; leftPtr < array.Length - 2; leftPtr++)
		{
			int midPtr = leftPtr + 1;
			int rightPtr = array.Length - 1;
			while (midPtr < rightPtr)
			{
				int currentSum = array[leftPtr] + array[midPtr] + array[rightPtr];
				if (currentSum == targetSum)
				{
					sums.Add(new int[] {array[leftPtr], array[midPtr], array[rightPtr]});
          // This code is added to handle cases where there are repeating integers in the input array
					if (array[midPtr + 1] - array[midPtr] < array[rightPtr] - array[rightPtr - 1])
						midPtr++;
					else
						rightPtr--;
				}
				else if (currentSum < targetSum)
					midPtr++;
				else if (currentSum > targetSum)
					rightPtr--;
			}
		}
		return sums;
	}
}
