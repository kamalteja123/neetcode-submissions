public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (nums.Length == 0) return 0;
        HashSet<int> numSet = new HashSet<int>(nums);
        int longest = 0;

        foreach (int num in numSet)
        {
            if (!numSet.Contains(num - 1))
            {
                int current = num;
                int len = 0;

                while (numSet.Contains(current))
                {
                    current += 1;
                    len++;
                }

                if (len > longest)
                {
                    longest = len;
                }
            }
        }
        return longest;
    }
}