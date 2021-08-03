using System.Collections.Generic;
using System;


public class Program {

	public string TournamentWinner(List<List<string> > competitions, List<int> results) {
		
		// Create map of teams to points
		var teamStats = new Dictionary<string, int>();
		
		for (int i = 0; i < competitions.Count; i++)
		{
			var matchWinnerIdx = results[i] == 1 ? 0 : 1;
			teamStats[competitions[i][matchWinnerIdx]] = 
				teamStats.ContainsKey(competitions[i][matchWinnerIdx]) ?
				teamStats[competitions[i][matchWinnerIdx]] + 3 : 3 ;
		}
		
		var maxValue = 0;
		var winner = "";
		
		foreach (KeyValuePair<string, int> entry in teamStats)
		{
			if (entry.Value > maxValue)
			{
				maxValue = entry.Value;
				winner = entry.Key;
			}
		}
		return winner;
	}
}

