using System;

public class Program {
	public static int[] SearchInSortedMatrix(int[,] matrix, int target) {
		// Start at top right corner
        int startRow = 0;
        int startCol = matrix.GetLength(1) - 1;
        int[] output = new int[] {-1, -1};

        while (startRow < matrix.GetLength(0) && startCol >= 0)
        {
            int currentVal = matrix[startRow, startCol];
            if (currentVal == target)
            {
                output[0] = startRow;
                output[1] = startCol;
                return output;
            }
            else if (currentVal < target)
            {
                startRow++;
            }
            else if (currentVal > target)
            {
                startCol--;
            }
        }
        
		return output;
	}
}
