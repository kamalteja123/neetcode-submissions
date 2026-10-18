public class Solution {
    public int MaxArea(int[] heights) {
     int left=0;
     int right=heights.Length-1;
     int maxWater=0;
     while(left<right)
     {
        int water=Math.Min(heights[right],heights[left])*(right-left);
        maxWater=Math.Max(water,maxWater);
        if (heights[right] > heights[left])
        {
            left++;
        }
        else
        {
            right--;
        }
     }  
     return maxWater ;
    }
}
