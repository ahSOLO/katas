using System;


public class Program {
	public int[] ThreeNumberSort(int[] array, int[] order) {
		int firstIdx = 0;
        int secondIdx = 0;
        int thirdIdx = array.Length - 1;

        while (secondIdx <= thirdIdx )
        {
            if ((array[secondIdx] == order[0]) && (secondIdx > firstIdx))
            {
                int temp = array[firstIdx];
                array[firstIdx] = array[secondIdx];
                array[secondIdx] = temp;
                firstIdx++;
            }
            else if (array[secondIdx] == order[2] && (secondIdx < thirdIdx))
            {
                int temp = array[thirdIdx];
                array[thirdIdx] = array[secondIdx];
                array[secondIdx] = temp;
                thirdIdx--;
            }
            else
            {
                secondIdx++;
            }
        }
        
        // Write your code here.
		return array;
	}
}

