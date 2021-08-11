using System;
using System.Collections.Generic;

public class Program {
	public static int ProductSum(List<object> array) {
		return ProductSum(array, 1);
	}

	public static int ProductSum(List<object> array, int depth) {
			int sum = 0;
			foreach (object ele in array)
			{
				if (ele.GetType() == typeof(List<object>))
				{
					sum += ProductSum((List<object>) ele, depth + 1);
				}
				else
				{
					sum += (int) ele;
				}
			}
			return sum * depth;
	}
}