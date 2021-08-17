using System;
using System.Collections.Generic;


public class Program {
	public int[] ArrayOfProducts(int[] array) {
		Dictionary<int, int[]> productMap = new Dictionary<int, int[]>();
				
		int[] output = new int[array.Length];
		
		// Populate left
		productMap.Add(0, new int[] {array[0], 0});
		for (int i = 1; i < array.Length; i++)
		{
			productMap.Add(i, new int[2]);
			productMap[i][0] = array[i] * productMap[i - 1][0];
		}
		
		// Populate right
		productMap[array.Length - 1][1] = array[array.Length - 1];
		for (int i = array.Length - 2; i > 0; i--)
		{
			productMap[i][1] = array[i] * productMap[i + 1][1];
		}
		
		// Generate output
		output[0] = productMap[1][1];
		output[array.Length - 1] = productMap[array.Length - 2][0];
		for (int i = 1; i < array.Length - 1; i++)
		{
			output[i] = productMap[i - 1][0] * productMap[i + 1][1];
		}
		
		return output;
	}
}
