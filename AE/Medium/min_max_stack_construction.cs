using System;
using System.Collections.Generic;

public class Program {
	public class MinMaxStack {
        private Stack<MinMaxEntry> stack = new Stack<MinMaxEntry>();

		public int Peek() 
        {
			return stack.Peek().value; 
		}

		public int Pop() 
        {
			
			return stack.Pop().value;
		}


		public void Push(int number) 
        {
            if (stack.Count > 0)
            {
                MinMaxEntry topOfStack = stack.Peek();
                int min = topOfStack.min;
                int max = topOfStack.max;

                if (number < min) min = number;
                if (number > max) max = number;

                stack.Push(new MinMaxEntry(number, min, max));
            }
            else
            {
                stack.Push(new MinMaxEntry(number, number, number));
            }
		}


		public int GetMin() 
        {
			return stack.Peek().min;
		}


		public int GetMax() 
        {
			return stack.Peek().max;
		}

        public class MinMaxEntry
        {
            public int value;
            public int min;
            public int max;

            public MinMaxEntry(int value, int min, int max)
            {
                this.value = value;
                this.min = min;
                this.max = max;
            }
        }
	}
}
