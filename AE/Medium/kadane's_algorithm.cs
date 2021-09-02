using System;

public class Program {
	public static int KadanesAlgorithm(int[] array) {
		int potentialMax = array[0];
		int max = array[0];
		for (int i = 1; i < array.Length; i++) {
			var num = array[i];
			potentialMax = Math.Max(num, potentialMax + num);
			max = Math.Max(max, potentialMax);
		}
		return max;
	}
}
