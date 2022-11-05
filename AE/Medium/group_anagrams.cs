using System;
using System.Linq;
using System.Collections.Generic;

class Program {
	public static List<List<string> > groupAnagrams(List<string> words) {
        Dictionary<string, List<string>> anagramDict = new Dictionary<string, List<string>>();
        // populate dict - key: word sorted, value: words that are anagrams

        foreach (string word in words)
        {
            string sortedWord = new string(word.OrderBy(c => c).ToArray());
            
            if (!anagramDict.ContainsKey(sortedWord))
            {
                anagramDict.Add(sortedWord, new List<string>(){word});
            }
            else
            {
                anagramDict[sortedWord].Add(word);
            }
        }
		return anagramDict.Values.ToList();
	}
}
