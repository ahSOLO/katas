public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] preArr = new int[nums.Length];
        int[] postArr = new int[nums.Length];
        preArr[0] = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            preArr[i] = preArr[i - 1] * nums[i];
        }
        postArr[nums.Length - 1] = nums[nums.Length - 1];
        for (int i = nums.Length - 2; i >= 0; i--)
        {
            postArr[i] = postArr[i + 1] * nums[i];
        }

        int[] output = new int[nums.Length];
        output[0] = postArr[1];
        output[output.Length - 1] = preArr[output.Length - 2];
        for (int i = 1; i < output.Length - 1; i++)
        {
            output[i] = preArr[i - 1] * postArr[i + 1];
        }
        return output;
    }
}