// For each word...
//   Sort the letters of the word
//   Append a dictionary entry with the sorted letters as the key and the word as the value (appended to a list)
// For each value in the dictionary, Add the full list to an array.

// Time - O(nlogn)
// Space - O(n)

public class Solution {
    Dictionary<string, IList<string>> anagramDict = new Dictionary<string, IList<string>>(); 

    public IList<IList<string>> GroupAnagrams(string[] strs) {
        foreach (string str in strs)
        {
            var sortedStr = String.Concat(str.OrderBy(c => c));
            if (!anagramDict.ContainsKey(sortedStr))
            {
                anagramDict[sortedStr] = new List<string>(){str};
            }
            else
            {
                anagramDict[sortedStr].Add(str);
            }
        }
        return anagramDict.Values.ToList();
    }
}