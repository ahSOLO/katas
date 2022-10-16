using System;
using System.Collections.Generic;

public class Program {

	public int[] NextGreaterElement(int[] array) {
    	int[] output = new int[array.Length];
        Array.Fill(output, -1);

        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < 2 * array.Length; i++)
        {
            int idx = i % array.Length;

            while (stack.Count > 0 && array[stack.Peek()] < array[idx])
            {
                int top = stack.Pop();
                output[top] = array[idx];
            }

            stack.Push(idx);
        }
        
		return output;
	}
}
