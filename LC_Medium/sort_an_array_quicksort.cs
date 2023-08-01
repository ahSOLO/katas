public class Solution {
    public int[] SortArray(int[] nums) {
        QuickSort(0, nums.Length - 1);
        return nums;

        void QuickSort(int start, int end) {
            if (start >= end) 
            {
                return;
            }

            int swapPtr = start;
            int pivot = nums[end];

            for (int i = start; i < end; i++)
            {
                if (nums[i] < pivot)
                {
                    var temp = nums[swapPtr];
                    nums[swapPtr] = nums[i];
                    nums[i] = temp;
                    swapPtr++;
                }
            }

            nums[end] = nums[swapPtr];
            nums[swapPtr] = pivot;

            QuickSort(start, swapPtr - 1);
            QuickSort(swapPtr + 1, end);
        }
    }
}