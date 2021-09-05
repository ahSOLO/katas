using System;
using System.Collections.Generic;

public class Program {
	public static List<int> RiverSizes(int[,] matrix) {
		int[,] matrixCopy = (int[,]) matrix.Clone();
		List<int> output = new List<int>();
		for (int i = 0; i < matrix.GetLength(0); i++)
			for (int j = 0; j < matrix.GetLength(1); j++)
			{
				if (matrixCopy[i, j] == 1)
				{
					int sum = 1;
					output.Add(DetectRivers(matrixCopy, i, j, ref sum));
				}
			}
		return output;
	}
	
	public static int DetectRivers(int[,] matrixCopy, int i, int j, ref int sum){
		matrixCopy[i, j] = -1;
		if (i >= 1 && matrixCopy[i - 1, j] == 1)
		{
			sum++;
			DetectRivers(matrixCopy, i - 1, j, ref sum);
		}
		if (i < matrixCopy.GetLength(0) - 1 && matrixCopy[i + 1, j] == 1)
		{
			sum++;
			DetectRivers(matrixCopy, i + 1, j, ref sum);
		}
		if (j >= 1 && matrixCopy[i, j - 1] == 1)
		{
			sum++;
			DetectRivers(matrixCopy, i, j - 1, ref sum);
		}
		if (j < matrixCopy.GetLength(1) - 1 && matrixCopy[i, j + 1] == 1)
		{
			sum++;
			DetectRivers(matrixCopy, i, j + 1, ref sum);
		}
		return sum;
	}
}
