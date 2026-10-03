public class Solution {
    public bool hasDuplicate(int[] nums) {
    var seen = new HashSet<int>();
    foreach (int x in nums)
    {
        //here insted of adding the contains and then add
        // we can combine in the one if the element already present
        //we will get the false or else true 
        if (!seen.Add(x))
            return true;
    }
    return false;
}
}