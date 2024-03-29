using System;
using System.Collections.Generic;

public class Program {

	public int StaircaseTraversal(int height, int maxSteps) {
		
        List<int> stepMap = new List<int>() {1, 1}; // only 1 way to get to staircase of 0 or 1 height.
        int currentSteps = 1;

        for (int i = 1; i < height; i++)
        {
            if (i - maxSteps >= 0)
            {
                currentSteps -= stepMap[i - maxSteps];
            }
            currentSteps += stepMap[i];
            stepMap.Add(currentSteps);
        }

		return currentSteps;
	}
}

