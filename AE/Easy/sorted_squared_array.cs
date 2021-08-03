using System;
using System.Collections.Generic;

public class Program {

	public int[] SortedSquaredArray(int[] array) {
		int[] output = new int[array.Length];
		var negative = false;
		for (int i = 0; i < array.Length; i++)
		{
			output[i] = array[i] * array[i];
			if (array[i] < 0) {
				negative = true;
			}
		}
		if (negative) {
			Array.Sort(output);
		}
		return output;
	}
}


public class Program {
	public int[] SortedSquaredArray(int[] array) {
		int[] output = new int[array.Length];
		var leftIndex = 0;
		var rightIndex = array.Length - 1;
		var insertIndex = output.Length - 1;
		while (leftIndex <= rightIndex)
		{
			if (Math.Abs(array[leftIndex]) > Math.Abs(array[rightIndex]))
			{
				output[insertIndex] = array[leftIndex] * array[leftIndex];
				leftIndex++;
			}
			else if (Math.Abs(array[leftIndex]) < Math.Abs(array[rightIndex]))
			{
				output[insertIndex] = array[rightIndex] * array[rightIndex];
				rightIndex--;
			}
			else
			{
				output[insertIndex] = array[leftIndex] * array[leftIndex];
				leftIndex++;
			}
			insertIndex--;
		}
		return output;
	}
}
