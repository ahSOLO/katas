using System;
using System.Collections.Generic;
using System.Text;

public class Program {
  public string BestDigits(string number, int numDigits) {
    Stack<char> charStack = new Stack<char>();
    for (int i = 0; i < number.Length; i++)
    {
        while (numDigits > 0 && charStack.Count > 0 && number[i] > charStack.Peek())
        {
            charStack.Pop();
            numDigits--;
        }
        charStack.Push(number[i]);
    }

    while (numDigits > 0)
    {
        charStack.Pop();
        numDigits--;
    }

    StringBuilder outputString = new StringBuilder();
    while (charStack.Count > 0)
    {
        outputString.Append(charStack.Pop());
    }

    var charArray = outputString.ToString().ToCharArray();
    Array.Reverse(charArray);
      
    return new string(charArray);
  }
}

