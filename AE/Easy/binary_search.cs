using System;

public class Program {
	public static int BinarySearch(int[] array, int target) {
		int leftPointer = 0;
		int rightPointer = array.Length - 1;
		while (leftPointer <= rightPointer)
		{
			int middle = (leftPointer + rightPointer) / 2;
			if (array[middle] == target)
			{
				return middle;
			}
			else if (array[middle] < target)
			{
				leftPointer = middle + 1;
			}
			else
			{
				rightPointer = middle - 1;
			}
		}
		return -1;
	}
}
