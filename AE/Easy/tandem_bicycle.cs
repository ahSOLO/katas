using System;


public class Program {

	public int TandemBicycle(int[] redShirtSpeeds, int[] blueShirtSpeeds, bool fastest) {
		Array.Sort(redShirtSpeeds);
		Array.Sort(blueShirtSpeeds);
		if (fastest)
			// Using Reverse is faster than a comparator when dealing with arrays of primitives
			Array.Reverse(redShirtSpeeds);
		
		int output = 0;
		for (int i = 0; i < redShirtSpeeds.Length; i++)
		{
			output += Math.Max(redShirtSpeeds[i], blueShirtSpeeds[i]);
		}
		
		return output;
	}
}
