public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int left = 0;                          // finger on the first (smallest) number
int right = numbers.Length - 1;        // finger on the last (biggest) number

while (left < right)                   // stop when the fingers meet: one position can't be used twice
{
    int sum = numbers[left] + numbers[right];

    if(sum==target) return new int [] {left+1,right+1};
    else if (sum>target) right--;
    else left++;
   
}

return new int[0];                     // never reached, because NeetCode guarantees one answer,
                                       // but C# needs every path to return something
    }
}
