using System;

public class Program {
	public string RunLengthEncoding(string str) {
		string output = "";
		char lastChar = str[0];
		int counter = 0;
		foreach (char c in str)
		{
			if (c == lastChar)
			{
				if (counter == 9)
				{
					output += $"9{c}";
					counter = 1;
				}
				else 
					counter++;
			}
			else 
			{
				output += $"{counter}{lastChar}";
				counter = 1;
			}
			lastChar = c;
		}
		output += $"{counter}{lastChar}";
		return output;
	}
}
