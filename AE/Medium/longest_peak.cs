using System;

public class Program {
	enum Phase {None, Increasing, Decreasing}
	
	public static int LongestPeak(int[] array) {
		Phase peakPhase = Phase.None;
		int count = 0;
		int maxCount = 0;
		bool isStrictlyIncreasing = false;
		bool isStrictlyDecreasing = false;
		for (int i = 0; i < array.Length - 1; i++)
		{
			var diff = array[i + 1] - array[i];
			isStrictlyIncreasing = diff > 0;
			isStrictlyDecreasing = diff < 0;
			
			if (isStrictlyIncreasing)
			{
				if (peakPhase == Phase.Decreasing || peakPhase == Phase.None)
					count = 1;
				peakPhase = Phase.Increasing;
				count++;
			}
			else if (isStrictlyDecreasing && 
							 (peakPhase == Phase.Increasing || peakPhase == Phase.Decreasing)
							)
			{
				peakPhase = Phase.Decreasing;
				count++;
				if (count > maxCount)
					maxCount = count;
			}
			else 
			{
				peakPhase = Phase.None;
				count = 0;
			}
		}
		return maxCount;
	}
}
