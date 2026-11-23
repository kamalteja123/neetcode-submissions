public class Solution {
   public int FindDuplicate(int[] nums)
{
    int slow = 0;
    int fast = 0;

    // Phase 1
    while (true)
    {
        slow = nums[slow];
        fast = nums[nums[fast]];
        if (slow == fast) break;
    }

    // Phase 2
    int slow2 = 0;
    while (slow != slow2)
    {
        slow2 = nums[slow2];
        slow  =nums[slow];
    }

    return slow;
}
}
