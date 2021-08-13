using System;

public class Program {
	public static int[] BubbleSort(int[] array) {
		bool sorted = false;
		int counter = 0;
		while (sorted == false)
		{
			sorted = true;
			for (int i = 0; i < array.Length - 1 - counter; i++)
			{
				if (array[i] > array[i + 1])
				{
					sorted = false;
					int temp = array[i];
					array[i] = array[i + 1];
					array[i + 1] = temp;
				}
			}
			counter++;
		}
		return array;
	}
}
