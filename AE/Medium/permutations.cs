using System;
using System.Linq;
using System.Collections.Generic;

public class Program {
	public static List<List<int> > GetPermutations(List<int> array) {
		
		List<List<int>> output = new List<List<int>>();
		
		if (array.Count == 0)
		{
			return output;
		}
		else if (array.Count == 1)
		{
			output.Add(array);
			return output;
		}

		output.Add(new List<int>() {array[0], array[1]});
		output.Add(new List<int>() {array[1], array[0]});

		while (output[0].Count < array.Count)
		{
			var newOutput = new List<List<int>>();
			int newNum = array[output[0].Count];
			
			for (int i = 0; i < output[0].Count + 1; i++)
			{
				foreach (var permutation in output)
				{
					var newLine = new List<int>(permutation);
					newLine.Insert(i, newNum);
					newOutput.Add(newLine);
				}
			}

			output = newOutput;
		}

		return output;
	}
}
