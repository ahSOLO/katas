using System.Collections.Generic;
using System;


// public class Program {
	
// 	public int FirstDuplicateValue(int[] array) {
// 		HashSet<int> hSet = new HashSet<int>();
// 		foreach (int num in array)
// 		{
// 			if (!hSet.Add(num))
// 				return num;
// 		}
// 		return -1;
// 	}
// }

public class Program {

	public int FirstDuplicateValue(int[] array) {
		foreach(var value in array)
		{
			Console.Write(value + ".");
			int absValue = Math.Abs(value);
			if (array[absValue - 1] < 0)
				return absValue;
			array[absValue - 1] *= -1;
		}
		return -1;
	}
}