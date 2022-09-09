using System.Collections.Generic;
using System;


public class Program {

	public List<string> PhoneNumberMnemonics(string phoneNumber) 
    {
		List<string> output = new List<string>();
        List<string> associations = new List<string>
        {
            "0","1","abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz"
        };
        
        foreach (char c in phoneNumber)
        {
            if (output.Count == 0)
            {
                foreach (char c_ in associations[(int)Char.GetNumericValue(c)])
                {
                    output.Add(c_.ToString());
                }
            }
            else
            {            
                List<string> newOutput = new List<string>();
                for (int i = 0; i < output.Count; i++)
                {
                    foreach (char c_ in associations[(int)Char.GetNumericValue(c)])
                    {
                        newOutput.Add(output[i] + c_.ToString());
                    }
                }
                output = newOutput;
            }
        }
        
		return output;
	}
}

