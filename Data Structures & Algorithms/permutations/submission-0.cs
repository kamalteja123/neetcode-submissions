public class Solution {
    public List<List<int>> Permute(int[] nums)
{
    List<List<int>> result = new List<List<int>>();
    List<int> path = new List<int>();
    bool[] used = new bool[nums.Length];

    void Go()
    {
        if (path.Count == nums.Length)
        {
            result.Add(new List<int>(path));
            return;
        }

        for (int j = 0; j < nums.Length; j++)
        {
            if (used[j]) continue;

            used[j] = true;
            path.Add(nums[j]);

            Go();

            used[j] = false;
            path.RemoveAt(path.Count - 1);
        }
    }

    Go();
    return result;
}
}
