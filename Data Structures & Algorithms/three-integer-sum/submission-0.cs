public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        List<List<int>> res = new List<List<int>>();
        int last = nums.Length - 1;

        for (int i = 0; i < last - 1; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
                continue;                                  // this value already had its round

            int left = i + 1, right = last;

            while (left < right)
            {
                int sum = nums[i] + nums[left] + nums[right];

                if (sum == 0)
                {
                    res.Add(new List<int> { nums[i], nums[left], nums[right] });
                    left++;
                    right--;
                    while (left < right && nums[left] == nums[left - 1])
                        left++;                            // skip the value we just recorded
                }
                else if (sum < 0)
                {
                    left++;                                // too small, need a bigger number
                }
                else
                {
                    right--;                               // too big, need a smaller number
                }
            }
        }
        return res;
    }
}