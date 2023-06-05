public class Solution {
    public int MinEatingSpeed(int[] piles, int h) 
    {
        int min = 0;
        int max = 1;
        // Get largest pile
        foreach (int pile in piles)
        {
            if (pile > max)
            {
                max = pile;
            }
        }

        int bestGuess = max;
        while (min <= max)
        {
            int guess = (min + max) / 2;
            if (guess == 0)
            {
                break;
            }
            int hCpy = h;
            foreach (int pile in piles)
            {
                hCpy -= (pile + guess - 1) / guess;
                if (hCpy < 0)
                {
                    break;
                }
            }
            if (hCpy < 0)
            {
                // Ran out of time, guess was too low
                min = guess + 1;
            }
            else if (hCpy >= 0)
            {
                // Still time left, guess might be too high
                if (guess < bestGuess)
                {
                    // Store the guess
                    bestGuess = guess;
                }
                max = guess - 1;
            }
        }
        return bestGuess;
    }
}