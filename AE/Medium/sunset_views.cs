using System.Collections.Generic;
using System;


public class Program {

	public List<int> SunsetViews(int[] buildings, string direction) {        
        List<int> canSeeSunset = new List<int>();

        switch (direction)
        {
            case "EAST":
                for (int i = 0; i < buildings.Length; i++)
                {
                    Calculate(i, buildings, output: canSeeSunset);
                }
                break;
            case "WEST":
                for (int i = buildings.Length - 1; i >= 0; i--)
                {
                    Calculate(i, buildings, output: canSeeSunset);
                }
                canSeeSunset.Reverse();
                break;
        }

		return canSeeSunset;
	}

    public List<int> Calculate(int i, int[] buildings, List<int> output)
    {
        if (output.Count == 0 ||
            buildings[output[output.Count - 1]] > buildings[i])
        {
            output.Add(i);
        }
        else
        {
            while (output.Count > 0 &&
                buildings[output[output.Count - 1]] <= buildings[i])
            {
                output.RemoveAt(output.Count - 1);
            }
            output.Add(i);
        }

        return output;
    }
}

