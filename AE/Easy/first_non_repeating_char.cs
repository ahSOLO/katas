using System;
using System.Collections.Generic;


public class Program {

	public int FirstNonRepeatingCharacter(string str) {
		Dictionary<char, int> dic = new Dictionary<char, int>();
		for (int i = 0; i < str.Length; i++)
		{
			if (dic.ContainsKey(str[i]))
				dic[str[i]] = int.MaxValue;
			else 
				dic[str[i]] = i;
		}
		foreach (KeyValuePair<char, int> entry in dic)
		{
			if (entry.Value != int.MaxValue)
				return entry.Value;
		}
		return -1;
	}
}
