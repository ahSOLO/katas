using System;
using System.Collections.Generic;

public class Program {
	public static List<int> SpiralTraverse(int[,] array) {
		
		int rotations = 0;
		int n = array.GetLength(0);
		int m = array.GetLength(1);
		int remainder = n * m;
		
		List<int> output = new List<int>();
		
		// Edge case - single row or column
		if (n <= 1 || m <= 1)
		{
			foreach (int i in array)
			{
				output.Add(i);
			}
			return output;
		}
		
		while(remainder > 0)
		{
			// Right
			for (int i = rotations; i < m - 1 - rotations; i++)
			{
				output.Add(array[rotations, i]);
				remainder--;
				if (remainder == 0) break;
			}
			// Down
			for (int i = rotations; i < n - 1 - rotations; i++)
			{
				output.Add(array[i, m - 1 - rotations]);
				remainder--;
				if (remainder == 0) break;
			}
			// Left
			for (int i = m - 1 - rotations; i > rotations; i--)
			{
				output.Add(array[n - 1 - rotations, i]);
				remainder--;
				if (remainder == 0) break;
			}
			// Up
			for (int i = n - 1 - rotations; i > rotations; i--)
			{
				output.Add(array[i, rotations]);
				remainder--;
				if (remainder == 0) break;
			}

			rotations++;

			if (remainder == 1)
			{
				// Vertical
				if (n > m)
					output.Add(array[n - 1 - rotations, rotations]);
				// Horizontal
				else if (m > n)
					output.Add(array[rotations, m - 1 - rotations]);
				// Same
				else
					output.Add(array[rotations, rotations]);
				return output;
			}
		}
		return output;
	}
}
