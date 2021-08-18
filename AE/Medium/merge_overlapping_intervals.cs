using System;
using System.Collections.Generic;


public class Program {

	public int[][] MergeOverlappingIntervals(int[][] intervals) {
		Array.Sort(intervals, new Comparison<int[]>(
			(x, y) => {
				if (x[0] < y[0]) return -1;
				if (x[0] > y[0]) return 1;
				if (x[1] < y[1]) return -1;
				if (x[1] > y[1]) return 1;
				return 0;
			}
		));
		int outputIdx = 0;
		List<int[]> output = new List<int[]>();
		output.Add(intervals[0]);
		for (int i = 0; i < intervals.Length - 1; i++)
		{
			if (output[outputIdx][1] >= intervals[i + 1][0])
			{
				output[outputIdx][1] = Math.Max(output[outputIdx][1], intervals[i + 1][1]);
			}
			else
			{
				outputIdx++;
				output.Add(intervals[i + 1]);
			}
		}
		return output.ToArray();
	}
}

