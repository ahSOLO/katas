public class Solution 
{
    public int[][] Insert(int[][] intervals, int[] newInterval) 
    {
        var outputList = new List<int[]>();
        if (intervals.Length == 0)
        {
            outputList.Add(newInterval);
        }
        else if (intervals[0][0] > newInterval[1])
        {
            outputList.Add(newInterval);
            outputList.AddRange(intervals);
        }
        else if (intervals[intervals.Length - 1][1] < newInterval[0])
        {
            outputList.AddRange(intervals);
            outputList.Add(newInterval);
        }
        else
        {
            for (int i = 0; i < intervals.Length; i++)
            {
                if (newInterval[0] > intervals[i][1])
                {
                    outputList.Add(intervals[i]);
                }
                else if (newInterval[1] < intervals[i][0])
                {
                    outputList.Add(newInterval);
                    outputList.AddRange(intervals[i..]);
                    return outputList.ToArray();
                }
                else
                {
                    newInterval = Merge(newInterval, intervals[i]);
                }
            }
            outputList.Add(newInterval);
        }

        return outputList.ToArray();

        int[] Merge(int[] interval1, int[] interval2)
        {
            return new int[2] {Math.Min(interval1[0], interval2[0]), Math.Max(interval1[1], interval2[1])};
        }
    }
}