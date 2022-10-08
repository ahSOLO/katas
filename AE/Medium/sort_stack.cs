using System.Collections.Generic;
using System;


public class Program {

	public List<int> SortStack(List<int> stack) {
        if (stack.Count > 0)
        {
    		Sort(stack);        
        }
		return stack;
	}

    public void Sort(List<int> stack)
    {
        int top = stack[stack.Count - 1];
        stack.RemoveAt(stack.Count - 1);
        if (stack.Count > 0)
        {        
            Sort(stack);
            Insert(stack, top);
        }
        else
        {
            Insert(stack, top);
        }
    }

    public void Insert(List<int> stack, int num)
    {
        if (stack.Count == 0 || 
            stack[stack.Count - 1] <= num)
        {
            stack.Add(num);
        }
        else
        {
            int top = stack[stack.Count - 1];
            stack.RemoveAt(stack.Count - 1);
            Insert(stack, num);
            stack.Add(top);
        }
    }
}

