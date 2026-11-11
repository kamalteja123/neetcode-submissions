public class Solution {
    public int CharacterReplacement(string s, int k) {
        int[] count= new int[26];
        int left=0,best=0;
        for(int right = 0; right < s.Length; right++ )
        {
            count[s[right]-'A']++;
            while((right-left+1)-MaxCount(count)>k)
            {
                count[s[left]-'A']--;
                left++;
            }
            best = Math.Max(best, right - left + 1);
        }
        return best;

    }
    private int MaxCount(int[] arr)
    {
        int max=0;
        for(int i=0;i<26;i++)
        {
            max=Math.Max(max,arr[i]);
        }
        return max;
    }
}
