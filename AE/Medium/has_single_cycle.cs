using System;

public class Program {
	public static bool HasSingleCycle(int[] array) {
		int idx = 0;
		for (int i = 0; i < array.Length; i++)
		{
			if (i > 0 && idx == 0)
				return false;
			idx = (idx + array[idx]) % array.Length;
			if (idx < 0)
				idx += array.Length;
		}
		return idx == 0;
	}
}
