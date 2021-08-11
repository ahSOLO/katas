using System;

public class Program {
	public static int[] FindThreeLargestNumbers(int[] array) {
		int firstLargest = int.MinValue;
		int secondLargest = int.MinValue;
		int thirdLargest = int.MinValue;
		foreach (int num in array)
		{
			if (num > firstLargest)
			{
				thirdLargest = secondLargest;
				secondLargest = firstLargest;
				firstLargest = num;
			}
			else if (num > secondLargest)
			{
				thirdLargest = secondLargest;
				secondLargest = num;
			}
			else if (num > thirdLargest)
			{
				thirdLargest = num;
			}
		}
		return new int[] {thirdLargest, secondLargest, firstLargest};
	}
}
