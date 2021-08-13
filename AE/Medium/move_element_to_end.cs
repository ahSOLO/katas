using System;
using System.Collections.Generic;

public class Program {
	public static List<int> MoveElementToEnd(List<int> array, int toMove) {
		int endIdx = array.Count - 1;
		for (int i = 0; i < endIdx; i++)
		{
			if (array[i] == toMove)
			{
				for (int j = endIdx; j > i; j--)
				{
					if (array[j] != toMove)
					{
						array[i] = array[j];
						array[j] = toMove;
						endIdx--;
						break;
					}
					endIdx--;
				}
			}
		}
		return array;
	}
}
