using System.Collections.Generic;
using System;

public class Program {
	public static bool BalancedBrackets(string str) {
		string[] brackets = new string[] {"()", "[]", "{}"};
        Stack<int> currentlyOpen = new Stack<int>();
        
        for (int i = 0; i < str.Length; i++)
        {
            int openBracketIdx = -1;
            int closedBracketIdx = -1;

            for (int j = 0; j < brackets.Length; j++)
            {
                if (str[i] == brackets[j][0])
                {
                    openBracketIdx = j;
                    break;
                }
                else if (str[i] == brackets[j][1])
                {
                    closedBracketIdx = j;
                    break;
                }
            }
            
            if (openBracketIdx >= 0)
            {
                currentlyOpen.Push(openBracketIdx);
            }

            else if (closedBracketIdx >= 0)
            {
                if (currentlyOpen.Count > 0 && closedBracketIdx >= currentlyOpen.Peek())
                {
                    currentlyOpen.Pop();
                }
                else
                {
                    return false;
                }
            }
        }
        
        return (currentlyOpen.Count == 0);
	}
}
