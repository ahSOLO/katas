using System;

public class Program {
	public int[] MissingNumbers(int[] nums) {
		int diff = 0;
        for (int i = 1; i <= nums.Length + 2; i++)
        {
            diff += i; 
        }

        foreach (int num in nums)
        {
            diff -= num;
        }
        
        int averageDiff = diff / 2;
        int foundFirstHalf = 0;
        int foundSecondHalf = 0;
        foreach (int num in nums)
        {
            if (num <= averageDiff)
            {
                foundFirstHalf += num;
            }
            else
            {
                foundSecondHalf += num;
            }
        }

        int expectedFirstHalf = 0;
        for (int i = 1; i <= averageDiff; i++)
        {
            expectedFirstHalf += i;
        }
        int expectedSecondHalf = 0;
        for (int i = averageDiff + 1; i <= nums.Length + 2; i++)
        {
            expectedSecondHalf += i;
        }

        return new int[] {expectedFirstHalf - foundFirstHalf, expectedSecondHalf - foundSecondHalf};
	}
}

