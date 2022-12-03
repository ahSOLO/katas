using System;
using System.Collections.Generic;

public class Program {

	public string[] MinimumCharactersForWords(string[] words) {
		Dictionary<char, int> charDict = new Dictionary<char, int>();
        Dictionary<char, int> charMaxDict = new Dictionary<char, int>();
        foreach (var word in words)
        {
            for(int i = 0; i < word.Length; i++)
            {
                if (charDict.ContainsKey(word[i]))
                {
                    charDict[word[i]]++;
                }
                else
                {
                    charDict.Add(word[i], 1);
                }
            }
            foreach (var kvp in charDict)
            {
                // Override with new value if it is higher than recorded max
                if (charMaxDict.ContainsKey(kvp.Key))
                {
                    if (charMaxDict[kvp.Key] < kvp.Value)
                        charMaxDict[kvp.Key] = kvp.Value;                
                }
                else
                {
                    charMaxDict.Add(kvp.Key, kvp.Value);
                }
            }
            charDict.Clear();
        }

        var outputList = new List<string>();
        foreach (var kvp in charMaxDict)
        {
            for (int i = 0; i < kvp.Value; i++)
            {
                outputList.Add(kvp.Key.ToString());
            }
        }
		return outputList.ToArray();
	}
}
