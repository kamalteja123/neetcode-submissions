public class Solution {
  public bool CheckInclusion(string s1, string s2)
{
    if (s1.Length > s2.Length) return false;

    int[] need = new int[26];
    int[] window = new int[26];

    for (int i = 0; i < s1.Length; i++)
    {
        need[s1[i] - 'a']++;
        window[s2[i] - 'a']++;      // first window: first s1.Length letters of s2
    }

    if (Matches(need, window)) return true;

    int left = 0;
    for (int right = s1.Length; right < s2.Length; right++)
    {
        window[s2[right] - 'a']++;  // new letter enters on the right
      window[s2[left] - 'a']-- ;   // BLANK: old letter leaves on the left
        left++;
        if (Matches(need, window)) return true;
    }
    return false;
}

private bool Matches(int[] a, int[] b)
{
    for (int i = 0; i < 26; i++)
        if (a[i] != b[i]) return false;
    return true;
}
}
