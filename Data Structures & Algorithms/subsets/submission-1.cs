public class Solution {
    public List<List<int>> Subsets(int[] nums) {
       List<List<int>> result = new List<List<int>>();
    List<int> path = new List<int>();

    void Go(int i)
    {
        if (i == nums.Length)
        {
            result.Add(new List<int>(path));
            return;
        }
        path.Add(nums[i]);
        Go(i + 1);
        path.RemoveAt(path.Count - 1);
        Go(i + 1);
    }

    Go(0);
    return result; 
    }
}
