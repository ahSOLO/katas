using System;
using System.Collections.Generic;

public class Program {

	public int BestSeat(int[] seats) {
        int longestChainStart = 0;
        int longestChainLength = 0;

        int currentChainStart = 0;
        int currentChainLength = 0;

        for (int i = 0 ; i < seats.Length; i++)
        {
            if (seats[i] == 0)
            {
                if (i == 0 || seats[i-1] == 1)
                {
                    currentChainStart = i;
                    currentChainLength = 1;                    
                }
                else
                {
                    currentChainLength++;
                }
            }
            else
            {
                if (longestChainLength < currentChainLength)
                {
                    longestChainStart = currentChainStart;
                    longestChainLength = currentChainLength;
                }
            }
        }

        if (longestChainLength < currentChainLength)
        {
            longestChainStart = currentChainStart;
            longestChainLength = currentChainLength;
        }
        
		return longestChainLength != 0 ? longestChainStart + ((longestChainLength - 1)/ 2) : -1;
	}
}
