public class Solution {
    public int[] SortArray(int[] nums) 
    {
        return MergeSort(nums, 0, nums.Length - 1);
    }

    public int[] MergeSort(int[] nums, int start, int end)
    {
        // Base case
        if (end - start + 1 <= 1)
        {
            return nums;
        }
        
        // Divide array in half
        int middle = (start + end) / 2;

        // Sort left side
        MergeSort(nums, start, middle);

        // Sort right side
        MergeSort(nums, middle + 1, end);

        // Merge left and right
        Merge(nums, start, middle, end);

        return nums;
    }

    public void Merge(int[] nums, int start, int middle, int end)
    {
        int[] leftArr = nums[start..(middle+1)];
        int[] rightArr = nums[(middle+1)..(end+1)];
        int leftPtr = 0;
        int rightPtr = 0;

        for (int i = start; i <= end; i++)
        {
            if (rightPtr >= rightArr.Length || 
                (leftPtr < leftArr.Length && leftArr[leftPtr] <= rightArr[rightPtr]))
            {
                nums[i] = leftArr[leftPtr];
                leftPtr++;
                continue;
            }
            else
            {
                nums[i] = rightArr[rightPtr];
                rightPtr++;
                continue;
            }
        }
    }
}