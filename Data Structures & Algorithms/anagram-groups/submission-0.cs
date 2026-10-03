public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dict =new Dictionary<string,List<string>>();
        foreach(string str in strs)
        {
            char[] currEle=str.ToCharArray();
            Array.Sort(currEle);
            string key=new string(currEle);
            if(!dict.TryGetValue(key, out var lists))
            {
                 lists=new List<string>();
                dict[key]=lists;
            }
            lists.Add(str);
        }
        return dict.Values.ToList();
    }
}
