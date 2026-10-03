public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dict = new Dictionary<string, List<string>>();

        foreach (string str in strs)
        {
            int[] count = new int[26];            // fresh 26 boxes for EACH word

            foreach (char c in str)
                count[c - 'a']++;                 // count this word's letters

            string key = string.Join("#", count); // e.g. "1#0#1#0#...#1#...#0"

            if (!dict.TryGetValue(key, out var list))
            {
                list = new List<string>();
                dict[key] = list;
            }
            list.Add(str);
        }
        return dict.Values.ToList();
    }
}