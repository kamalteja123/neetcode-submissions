public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int len=nums.Length;
         var dict = new Dictionary<int, int>();
      for(int i=0;i<len;i++)
      {
        int need=target-nums[i];
        if(dict.TryGetValue(need,out int j))
        return new int[] {j,i};
      dict[nums[i]]=i;
      }
      return new int[]{0,0};
    }
}