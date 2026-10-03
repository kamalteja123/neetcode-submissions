public class Solution {
    public bool IsAnagram(string s, string t) {
        int slen=s.Length;
        int tlen=t.Length;
        if(slen!=tlen)
        return false;
       var freq = new Dictionary<char, int>();
foreach (char c in s)
    freq[c] = freq.GetValueOrDefault(c, 0) + 1;
    foreach(char c in t)
    {
       if (!freq.TryGetValue(c, out int count) || count == 0)
        return false;              // missing, or no copies left

    freq[c] = count - 1;
    }
    return true;   
    }
}
