public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] res = new int[nums.Length];

        // pass 1: left to right
        int left = 1;                       // starting value
        for (int i = 0; i < nums.Length; i++)
        {
            res[i] = left;                     // store the left product first
            left = left* nums[i];                       // then multiply in nums[i]
        }

        // pass 2: right to left
        int right = 1;                      // starting value
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            res[i] = right* res[i];                     // multiply res[i] by right
            right = right* nums[i];                      // then multiply in nums[i]
        }
        return res;
    }
}