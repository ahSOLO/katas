public class MinStack {
    private int count;
    private List<int> stack;
    private List<int> minStack;

    public MinStack() {
        count = 0;
        stack = new List<int>();
        minStack = new List<int>();
    }
    
    public void Push(int val) {
        stack.Add(val);
        minStack.Add(minStack.Count > 0 ? Math.Min(minStack[count - 1], val) : val);
        count++;
    }
    
    public void Pop() {
        stack.RemoveAt(count - 1);
        minStack.RemoveAt(count - 1);
        count--;
    }
    
    public int Top() {
        return stack[count - 1];
    }
    
    public int GetMin() {
        return minStack[count - 1];
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */