using System;
using System.Collections.Generic;


public class Program {

	public bool GenerateDocument(string characters, string document) {
		Dictionary<char, int> charDict = new Dictionary<char, int>();
		
		foreach (char c in characters)
			charDict[c] = charDict.GetValueOrDefault(c, 0) + 1;
		
		foreach (char c in document)
		{
			if (charDict.ContainsKey(c) && charDict[c] > 0)
				charDict[c]--;
			else
				return false;
		}
		
		return true;
	}
}

