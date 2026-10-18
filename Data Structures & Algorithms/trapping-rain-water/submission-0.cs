public class Solution {
    public int Trap(int[] height)
{
    int left = 0;                       // finger at the first bar
    int right = height.Length - 1;      // finger at the last bar
    int leftMax = 0;                    // tallest bar seen from the left
    int rightMax = 0;                   // tallest bar seen from the right
    int total = 0;                      // water collected so far

    while (left < right)
    {
        if (height[left] < height[right])
        {
            // left side is lower, so leftMax is the water level
            leftMax = Math.Max(leftMax, height[left]);
            total += leftMax - height[left];
            left++;
        }
        else
        {
            // right side is lower or equal, so rightMax is the water level
            rightMax = Math.Max(rightMax, height[right]);
            total += rightMax - height[right];
            right--;
        }
    }
    return total;
}
}
