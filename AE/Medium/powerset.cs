using System;
using System.Collections.Generic;

public class Program
{
    public static List<List<int>> Powerset(List<int> array)
    {
        array.Sort();
        Console.WriteLine($"Sorted Array: {String.Join(", ", array)}");

        List<List<int>> output = new List<List<int>>();
        List<List<int>> recentlyListed = new List<List<int>>(array.Count);

        // Always include the empty set
        output.Add(new List<int>());

        // If len > 0, include the entire array
        if (array.Count > 0)
        {
            output.Add(new List<int>(array));
        }

        // If len > 1, get individual elements
        if (array.Count > 1)
        {
            foreach (int num in array)
            {
                var newList = new List<int>(){ num };
                recentlyListed.Add(newList); 
                output.Add(newList);
            }
        }

        Console.WriteLine($"Default Output Length: {output.Count}");
        Console.WriteLine($"Recently Listed Length: {recentlyListed.Count}");

        // If len > 2:
        if (array.Count > 2)
        {
            int setLength = 2;
            List<List<int>> newRecentlyListed = new List<List<int>>();
            
            Console.WriteLine($"Starting Loop");

            // Repeat until length of newly generated sets are 1 less than array length
            while (setLength < array.Count)
            {
                Console.WriteLine($"Loop with length {setLength}");
                int newSetsCount = recentlyListed.Count;
                newRecentlyListed.Clear();
                // Take individual elements and iterate through remaining elements and add them to the individual elements to generate new lists; do not iterate backwards
                for (int i = 0; i < newSetsCount; i++)
                {
                    int lastDigitOfList = recentlyListed[i][recentlyListed[i].Count - 1];
                    Console.WriteLine($"Last Digit {lastDigitOfList}");
                    if (lastDigitOfList < array[array.Count - 1])
                    {
                        for (int j = 1; j < array.Count; j++)
                        {
                            if (lastDigitOfList < array[j])
                            {
                                var newList = new List<int>(recentlyListed[i]);
                                newList.Add(array[j]);
                                output.Add(newList);
                                newRecentlyListed.Add(newList);
                                Console.WriteLine($"Adding newlist {String.Join(", ", newList)}");                           
                            }
                        }
                    }
                }
                Console.WriteLine($"New recently visited length {newRecentlyListed.Count}");
                setLength++;
                recentlyListed = new List<List<int>>(newRecentlyListed);
            }
        }

        return output;
    }
}
