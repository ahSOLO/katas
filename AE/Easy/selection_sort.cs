using System;

public class Program {
	public static int[] SelectionSort(int[] array) {
		if (array.Length == 0)
			return array;
		for (int i = 0; i < array.Length; i++)
		{
			int smallestIdx = i;
			for (int j = i + 1; j < array.Length; j++)
			{
				if (array[j] < array[smallestIdx])
				{
					smallestIdx = j;
				}
			}
			if (smallestIdx != i)
			{
				int temp = array[i];
				array[i] = array[smallestIdx];
				array[smallestIdx] = temp;
			}
		}
		return array;
	}
}
