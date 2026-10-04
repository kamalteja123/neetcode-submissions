public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
      
        int n = nums.Length;
        int[] left = new int[n];
        int[] right = new int[n];
        int[] res = new int[n];
        left[0]=1;
        for (int i = 1; i < nums.Length; i++)
        {
            left[i]=left[i-1]* nums[i-1];                   // then multiply in nums[i]
        }

        // pass 2: right to left
        right[n-1] = 1;                      // starting value
        for (int i = nums.Length - 2; i >= 0; i--)
        {
        right[i]   = right[i+1]* nums[i+1];                     // multiply res[i] by right
                                 // then multiply in nums[i]
        }
         for (int i = 0; i < n; i++)
            res[i] = left[i] * right[i];  
        return res;
    }
}