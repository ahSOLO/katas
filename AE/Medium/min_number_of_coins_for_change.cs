using System;

public class Program {
	public static int MinNumberOfCoinsForChange(int n, int[] denoms) {
		int[] minChange = new int[n+1];
        Array.Fill(minChange, Int32.MaxValue);
        minChange[0] = 0;
        foreach (int denom in denoms)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i >= denom)
                {
                    if (minChange[i - denom] != Int32.MaxValue)
                    {
                        minChange[i] = Math.Min(minChange[i], 1 + minChange[i - denom]);
                    }
                }
            }
        }
        
		return minChange[n] != Int32.MaxValue ? minChange[n] : -1;
	}
}
