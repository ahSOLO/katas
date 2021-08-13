using System;

public class Program {
	public static int[] SmallestDifference(int[] arrayOne, int[] arrayTwo) {
		Array.Sort(arrayOne);
		Array.Sort(arrayTwo);
		int firstPtr = 0;
		int secondPtr = 0;
		int[] output = new int[] {arrayOne[0], arrayTwo[0]};
		int smallestDiff = int.MaxValue;
		while (firstPtr < arrayOne.Length && secondPtr < arrayTwo.Length)
		{
			int currentDiff = Math.Abs(arrayOne[firstPtr] - arrayTwo[secondPtr]);
			if (currentDiff < smallestDiff)
			{
				smallestDiff = currentDiff;
				output[0] = arrayOne[firstPtr];
				output[1] = arrayTwo[secondPtr];
			}
			if (arrayOne[firstPtr] < arrayTwo[secondPtr])
				firstPtr++;
			else
				secondPtr++;
		}
		return output;
	}
}
