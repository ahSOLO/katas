using System;

public class Program {
	public static void RemoveKthNodeFromEnd(LinkedList head, int k) {
		LinkedList firstPassNode = head;
        LinkedList secondPassNode = head;
        int listLength = 1;

        // First Traversal
        while(firstPassNode.Next != null)
        {
            firstPassNode = firstPassNode.Next;
            listLength++;
        }

        int nodePosition = listLength - k;

        if (nodePosition <= 0)
        {
            head.Value = head.Next.Value;
            head.Next = head.Next.Next;
        }
        else
        {
            // Second Traversal - get node prior to node to remove
            for (int i = 0; i < nodePosition - 1; i++)
            {
                secondPassNode = secondPassNode.Next;
            }
            secondPassNode.Next = secondPassNode.Next.Next;
        }
	}

	public class LinkedList {
		public int Value;
		public LinkedList Next = null;

		public LinkedList(int value) {
			this.Value = value;
		}
	}
}