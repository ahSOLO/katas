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

	public LinkedList SumOfLinkedLists(LinkedList linkedListOne, LinkedList linkedListTwo)
	{
		LinkedList output = null;
		LinkedList head = null;
		int higherDigits = 0;
		while (linkedListOne != null && linkedListTwo != null)
        {
			var newNode = new LinkedList(linkedListOne.value + linkedListTwo.value + higherDigits);
			if (output == null)
            {
				output = newNode;
				head = output;
			}
			else
            {
				output.next = newNode;
				output = output.next;
            }

			string strNum = output.value.ToString();
			output.value = int.Parse(strNum.Substring(strNum.Length - 1));

			string higherDigitsStr = strNum.Substring(0, strNum.Length - 1);
			if (higherDigitsStr.Length > 0)
            {
				higherDigits = int.Parse(higherDigitsStr);
            }
			else
            {
				higherDigits = 0;
            }
			
			linkedListOne = linkedListOne.next;
			linkedListTwo = linkedListTwo.next;
        }

		while (linkedListOne != null || linkedListTwo != null)
        {			
			output.next = new LinkedList(higherDigits + (linkedListOne != null ? linkedListOne.value : linkedListTwo.value));

			string strNum = output.value.ToString();
			output.value = int.Parse(strNum.Substring(strNum.Length - 1));

			string higherDigitsStr = strNum.Substring(0, strNum.Length - 1);
			if (higherDigitsStr.Length > 0)
			{
				higherDigits = int.Parse(higherDigitsStr);
			}
			else
			{
				higherDigits = 0;
			}

			output = output.next;

			linkedListOne = linkedListOne?.next;
			linkedListTwo = linkedListTwo?.next;
        }

		if (higherDigits != 0)
        {
			output.next = new LinkedList(higherDigits);
        }

		return head;
	}
}

