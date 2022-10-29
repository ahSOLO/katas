using System;

public class Program {
	public static string LongestPalindromicSubstring(string str) {

        string longestPal = str.Substring(0, 1);
        for (int i = 0; i < str.Length - 1; i++)
        {
            string currentPalEven = GetPalindrome(str, i, i + 1);
            string currentPalOdd = GetPalindrome(str, i, i + 2);
            if (currentPalEven.Length > longestPal.Length)
            {
                longestPal = currentPalEven;
            }
            if (currentPalOdd.Length > longestPal.Length)
            {
                longestPal = currentPalOdd;
            }
        }
        
		return longestPal;
	}

    public static string GetPalindrome(string str, int leftIdx, int rightIdx)
    {
        bool successful = false;
        while (leftIdx >= 0 &&
              rightIdx < str.Length &&
              str[leftIdx] == str[rightIdx])
        {
            leftIdx--;
            rightIdx++;
            successful = true;
        }
        return successful ? str.Substring(leftIdx + 1, rightIdx - (leftIdx + 1)) : "";
    }
}
