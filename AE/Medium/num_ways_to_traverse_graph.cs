using System;


public class Program {

	public int NumberOfWaysToTraverseGraph(int width, int height) {

        int[,] memoedWays = new int[width + 1, height + 1];

        for (int w = 1; w < width + 1; w++)
        {
            for (int h = 1; h < height + 1; h++)
            {
                if (w == 1 || h == 1)
                {
                    memoedWays[w, h] = 1;
                }
                else
                {
                    memoedWays[w, h] = memoedWays[w - 1, h] + memoedWays[w, h - 1];
                }
            }
        }
        
		return memoedWays[width, height];
	}
}
