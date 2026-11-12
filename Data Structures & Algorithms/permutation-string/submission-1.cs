public class Solution {
 public bool CheckInclusion(string s1, string s2)
{
    int[] need = new int[26];
    foreach (char c in s1) need[c - 'a']++;          // fill need first

    int[] window = new int[26];
    for (int right = 0; right < s2.Length; right++)
    {
        window[s2[right] - 'a']++;                   // enters
        if (right >= s1.Length)
            window[s2[right - s1.Length] - 'a']--;   // leaves (the old left)
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
