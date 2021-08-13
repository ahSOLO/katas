using System;

public class Program {
	public static int[] InsertionSort(int[] array) {
		if (array.Length == 0)
			return array;
		for (int i = 1; i < array.Length; i++)
		{
			for (int j = i; j > 0; j--)
			{
				if (array[j] >= array[j - 1])
					break;
				int temp = array[j];
				array[j] = array[j - 1];
				array[j - 1] = temp;
			}
		}
		return array;
	}
}
