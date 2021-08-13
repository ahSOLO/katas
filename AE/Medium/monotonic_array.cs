using System;

public class Program {
	public static bool IsMonotonic(int[] array) {
		if (array.Length <= 1)
			return true;
		bool? isNonIncreasing = null;
		int prev = array[0];
		for (int i = 1; i < array.Length; i++)
		{
			if (array[i] > prev)
			{
				if (isNonIncreasing == null)
					isNonIncreasing = false;
				else if (isNonIncreasing == true)
					return false;
			}
			else if (array[i] < prev)
			{
				if (isNonIncreasing == null)
					isNonIncreasing = true;
				else if (isNonIncreasing == false)
					return false;
			}
			prev = array[i];
		}
		return true;
	}
}
