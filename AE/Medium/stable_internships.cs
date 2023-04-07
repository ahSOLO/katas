using System;
using System.Collections.Generic;

public class Program {
	public int[][] StableInternships(int[][] interns, int[][] teams) {
		// Output = [[internIndex, teamIndex],...]
        Dictionary<int, int> chosenInterns = new Dictionary<int, int>();

        Stack<int> availableInterns = new Stack<int>();
        for (int i = 0; i < interns.Length; i++)
        {
            availableInterns.Push(i);
        }

        int[] currentInternChoices = new int[interns.Length];

        List<Dictionary<int, int>> teamDictionaries = new List<Dictionary<int, int>>();
        foreach (var team in teams)
        {
            Dictionary<int, int> teamDictionary = new Dictionary<int, int>();
            for (int i = 0; i < team.Length; i++)
            {
                teamDictionary[team[i]] = i;
            }
            teamDictionaries.Add(teamDictionary);
        }

        while(availableInterns.Count > 0)
        {
            int internNum = availableInterns.Pop();
            int[] internPrefs = interns[internNum];
            int teamPref = internPrefs[currentInternChoices[internNum]];
            currentInternChoices[internNum]++;

            if (!chosenInterns.ContainsKey(teamPref)) 
            {
                chosenInterns[teamPref] = internNum;
            }
            // Spot on team has already been taken
            else
            {
                int previousIntern = chosenInterns[teamPref];
                int previousInternRank = teamDictionaries[teamPref][previousIntern];
                int currentInternRank = teamDictionaries[teamPref][internNum];

                // Out of the two competing interns, see which one team prefers
                if (currentInternRank < previousInternRank)
                {
                    availableInterns.Push(previousIntern);
                    chosenInterns[teamPref] = internNum;
                } 
                else
                {
                    availableInterns.Push(internNum);
                }
            }
        }

        int[][] matches = new int[interns.Length][];
        int index = 0;
        foreach (var chosenIntern in chosenInterns) 
        {
            matches[index] = new int[] {chosenIntern.Value, chosenIntern.Key};
            index++;
        }

        return matches;
	}
}

