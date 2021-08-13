using System;

public class Program {
	public static bool IsPalindrome(string str) {
		int leftPointer = 0;
		int rightPointer = str.Length - 1;
		while (leftPointer < rightPointer)
		{
			if (str[leftPointer] != str[rightPointer])
				return false;
			leftPointer++;
			rightPointer--;
		}
		return true;
	}
}
