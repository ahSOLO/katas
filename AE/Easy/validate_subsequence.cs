using System;
using System.Collections.Generic;

public class Program {
	public static bool IsValidSubsequence(List<int> array, List<int> sequence) {
		var sequenceIndex = 0;
		var arrayIndex = 0;
		while (arrayIndex < array.Count) 
		{
			if (sequence[sequenceIndex] == array[arrayIndex])
				sequenceIndex++;
			arrayIndex++;
			if (sequenceIndex == sequence.Count)
				return true;
		}
		return false;
	}
}