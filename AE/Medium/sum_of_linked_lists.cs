using System.Collections.Generic;
using System;


public class Program
{
	// This is an input class. Do not edit.
	public class LinkedList
	{
		public int value;
		public LinkedList next;

		public LinkedList(int value)
		{
			this.value = value;
			this.next = null;
		}
	}

	public int SumLinkedListNodes(LinkedList nodeOne, LinkedList nodeTwo, int c)
	{
		return ((nodeOne != null ? nodeOne.value : 0) + (nodeTwo != null ? nodeTwo.value : 0) + c);
	}

	public LinkedList SumOfLinkedLists(LinkedList linkedListOne, LinkedList linkedListTwo)
	{
		LinkedList output = null;
		LinkedList head = null;
		int carry = 0;

		head = new LinkedList(0);

		while (linkedListOne != null || linkedListTwo != null || carry != 0)
        {
			var strNum = SumLinkedListNodes(linkedListOne, linkedListTwo, carry).ToString();

			string higherDigitsStr = strNum.Substring(0, strNum.Length - 1);
			if (higherDigitsStr.Length > 0)
			{
				carry = int.Parse(higherDigitsStr);
			}
			else
			{
				carry = 0;
			}

			if (output == null)
            {
				output = head;
				output.value = int.Parse(strNum.Substring(strNum.Length - 1));
            } 
			else
            {
				output.next = new LinkedList(int.Parse(strNum.Substring(strNum.Length - 1)));
				output = output.next;
            }

			linkedListOne = linkedListOne?.next;
			linkedListTwo = linkedListTwo?.next;
        }

		return head;
	}
}

