using System;
using System.Text;


public class Program {

	public string ReverseWordsInString(string str) {
		StringBuilder sb = new StringBuilder("", str.Length);
        int endTracker = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (i == str.Length - 1)
            {
                sb.Insert(0, str.Substring(endTracker, i + 1 - endTracker));
            }
            else if (str[i] == ' ')
            {
                sb.Insert(0, " " + str.Substring(endTracker, i - endTracker));
                endTracker = i + 1;
            }
        }

        Console.WriteLine(sb.ToString());
		return sb.ToString();
	}
}

