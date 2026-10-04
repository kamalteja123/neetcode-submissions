public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var dict=new Dictionary<int,int>();
        foreach (int num in nums)
            dict[num] = dict.GetValueOrDefault(num, 0) + 1;
        var entries=dict.ToList();
        entries.Sort((a,b)=>b.Value.CompareTo(a.Value));
        int[] result=new int[k];
        for (int i = 0; i < k; i++)
         result[i] = entries[i].Key;
        return  result;
    }
}
