using System.Collections.Generic;
using System;


public class Program {
	// This is an input class. Do not edit.
	public class LinkedList {
		public int value;
		public LinkedList next;

		public LinkedList(int value) {
			this.value = value;
			this.next = null;
		}
	}

	public LinkedList RemoveDuplicatesFromLinkedList(LinkedList linkedList) {
		var node = linkedList;
		while (node != null && node.next != null)
		{
			while (node.next != null && node.next.value == node.value)
			{
					node.next = node.next.next;
			}
			node = node.next;
		}
		return linkedList;
	}
}

