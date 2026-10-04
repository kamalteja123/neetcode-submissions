public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder str=new StringBuilder();
        foreach(string s in strs)
        {
            str.Append(s.Length);
            str.Append('#');
            str.Append(s);
        }
        return str.ToString();
    }

    public List<string> Decode(string s) {
     var dec=new List<string>();
     int i=0;
     while(i<s.Length)
     {
        int hash=s.IndexOf('#',i);
        int subLen=int.Parse(s.Substring(i,hash-i));
        string word=s.Substring(hash+1,subLen);
        dec.Add(word);
        i=hash+1+subLen;
     }
     return dec;
   }
}
