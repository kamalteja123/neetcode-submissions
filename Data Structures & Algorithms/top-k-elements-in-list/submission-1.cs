public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        // 1. count (same as before)
        var dict = new Dictionary<int, int>();
        foreach (int num in nums)
            dict[num] = dict.GetValueOrDefault(num, 0) + 1;
         
        // 2. boxes: one per frequency, 0 to nums.Length
        List<int>[] buckets = new List<int>[nums.Length + 1];

        foreach (var kv in dict)
        {
            int freq = kv.Value;                  // the count: Key or Value?
            if (buckets[freq] == null)
                buckets[freq] = new List<int>(); // create the box the first time
            buckets[freq].Add(kv.Key);          // drop in the number: Key or Value?
        }

        // 3. read from the highest frequency down
        var result = new List<int>();
        for (int f = nums.Length; f >= 1; f--)          // where does the highest box start?
        {
            if (buckets[f] == null) continue;    // skip empty boxes
            result.AddRange(buckets[f]);
            if (result.Count >= k)
                return result.ToArray();
        }
        return result.ToArray();
    }
}