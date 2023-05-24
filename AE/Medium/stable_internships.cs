using System;
using System.Collections.Generic;


public class Program {
	public int[][] StableInternships(int[][] interns, int[][] teams) {
        Dictionary<int, int> chosenInterns = new Dictionary<int, int>();
        
        int[] internChoices = new int[interns.Length];
        Stack<int> availableInterns = new Stack<int>();
        for (int i = 0; i < interns.Length; i++)
        {
            availableInterns.Push(i);
        }

        while (availableInterns.Count > 0)
        {
            int internNum = availableInterns.Pop();
            int internTeamPref = interns[internNum][internChoices[internNum]];
            internChoices[internNum]++;

            if (!chosenInterns.ContainsKey(internTeamPref))
            {
                chosenInterns[internTeamPref] = internNum;
            }
            else
            {
                int previousInternNum = chosenInterns[internTeamPref];
                int previousInternRank = Array.IndexOf(teams[internTeamPref], previousInternNum);
                int currentInternRank = Array.IndexOf(teams[internTeamPref], internNum);

                if (currentInternRank < previousInternRank)
                {
                    chosenInterns[internTeamPref] = internNum;
                    availableInterns.Push(previousInternNum);
                }
                else
                {
                    availableInterns.Push(internNum);
                }
            }
        }

        int[][] output = new int[interns.Length][];
        int idx = 0;
        foreach (KeyValuePair<int, int> chosenIntern in chosenInterns)
        {
            output[idx] = new int[]{chosenIntern.Value, chosenIntern.Key};
            idx++;
        }
		return output;
	}
}

