using System;

public class Program {
	public static int LevenshteinDistance(string str1, string str2) {
		int[,] lArr = new int[str1.Length + 1,str2.Length + 1];
		// fill out first row;
		for (int i = 0; i < lArr.GetLength(0); i++)
			lArr[i, 0] = i;
		// fill out first column
		for (int i = 0; i < lArr.GetLength(1); i++)
			lArr[0, i] = i;
		// calculate levenshtein distance
		for (int i = 1; i < lArr.GetLength(0); i++)
			for (int j = 1; j < lArr.GetLength(1); j++)
			{
				if (str1[i - 1] == str2[j - 1])
				{
					lArr[i, j] = lArr[i - 1, j -1];
				}
				else 
				{
					lArr[i, j] = 1 + Min3(
						lArr[i - 1, j - 1],
						lArr[i, j - 1],
						lArr[i - 1, j]);
				}
			}
		int maxEdits = lArr[lArr.GetLength(0) - 1, lArr.GetLength(1) - 1];
		return maxEdits;
	}
	
	public static int Min3(int first, int second, int third)
	{
		return Math.Min(first, Math.Min(second, third));
	}
}
