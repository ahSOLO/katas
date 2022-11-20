using System.Collections.Generic;
using System;


public class Program {

	public List<string> ValidIPAddresses(string str) {
		var output = new List<string>();

        if (str.Length < 4)
        {
            return output;
        }

        for (int first = 1; first < 4 && first < str.Length - 2; first++)
        {
            if (!isValidPart(str.Substring(0, first)))
                continue;
            
            for (int sec = first + 1; sec < first + 4 && sec < str.Length - 1; sec++)
            {
                if (!isValidPart(str.Substring(first, sec - first)))
                    continue;
                
                for (int third = sec + 1; third < sec + 4 && third < str.Length; third++)
                {
                    if (!isValidPart(str.Substring(sec, third - sec)))
                        continue;

                    if (str.Length - 1 > third && !isValidPart(str.Substring(third)))
                        continue;
                    
                    var newStr = str.Insert(first, ".").Insert(sec + 1, ".").Insert(third + 2, ".");
                    Console.WriteLine(newStr);
                    output.Add(newStr);
                }
            }
        }
        
		return output;
	}

    public bool isValidPart(string str)
    {
        bool result = !(str.Length > 1 && str[0] == '0' || Int32.Parse(str) > 255);
        return result;
    }
}

