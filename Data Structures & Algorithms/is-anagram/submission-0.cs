public class Solution {
    public bool IsAnagram(string s, string t) {
        int slen=s.Length;
        int tlen=t.Length;
        if(slen!=tlen)
        return false;
        char[] sarr = s.ToCharArray();    
        Array.Sort(sarr); 
        char[] tarr = t.ToCharArray();    
        Array.Sort(tarr);     
        for(int i=0;i<slen;i++)
        {
            char selem=sarr[i]; char telem=tarr[i];
            if(selem!=telem)
            return false;
        }  
        return true;
        // return sarr.SequenceEqual(tarr);   
        // replaces the for loop and the final return true
    }
}
