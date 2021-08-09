using System;


public class Program {

	public int MinimumWaitingTime(int[] queries) {
		Array.Sort(queries);
		int accumulatedWaitTime = 0;
		int sum = 0;
		for (int i = 0; i < queries.Length - 1; i ++)
		{
				accumulatedWaitTime += queries[i];
				sum += accumulatedWaitTime;
		}
		
		return sum;		
	}
}

