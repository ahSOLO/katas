using System;


public class Program {

	public int NonConstructibleChange(int[] coins) {
		Array.Sort(coins);
		var change = 1;
		for (int i = 0; i < coins.Length; i++) 
		{
			if (coins[i] <= change)
			{
				change += coins[i];
			}
			else 
			{
				return change;
			}
		}
		return change;
	}
}

