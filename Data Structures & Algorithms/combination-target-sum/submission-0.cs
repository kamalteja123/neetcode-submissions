public class Solution {
     List<List<int>> result = new List<List<int>>();
    public List<List<int>> CombinationSum(int[] nums, int target) {
        Go(nums, 0, target, new List<int>());
        return result; 
    }
     void Go(int[] nums, int i, int remaining, List<int> path)
    {
        if (remaining == 0) { result.Add(new List<int>(path)); return; }
        if (remaining < 0) return;
        if (i == nums.Length) return;

        // TAKE: stay on the same box
        path.Add(nums[i]);
        Go(nums, i, remaining - nums[i], path);
        path.RemoveAt(path.Count - 1);

        // SKIP: next box, same need
        Go(nums, i + 1, remaining, path);
    }
}
