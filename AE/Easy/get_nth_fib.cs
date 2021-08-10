using System;

public class Program {
	public static int GetNthFib(int n) {
		if (n == 1)
			return 0;
		int currentSum = 1;
		int prevSum = 0;
		int idx = 2;
		while (idx < n)
		{
			var temp = currentSum;
			currentSum = currentSum + prevSum;
			prevSum = temp;
			idx++;
		}
		return currentSum;
	}
}
