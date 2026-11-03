public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (s.Length==0)
        return 0;
         HashSet<char> window = new HashSet<char>();
         int bestLen=0,left=0;
        for (int i=0;i<s.Length;i++)
        {
            while(window.Contains(s[i]))
            {
                window.Remove(s[left]);
                left+=1;
            }
             window.Add(s[i]);
             bestLen=Math.Max(bestLen, i - left + 1);
        }
return bestLen;
    }
}
