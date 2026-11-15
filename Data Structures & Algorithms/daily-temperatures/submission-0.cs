public class Solution {
  public int[] DailyTemperatures(int[] temperatures) {
    int n = temperatures.Length;
    int[] answer = new int[n];                 // all 0 at the start
    Stack<int> stack = new Stack<int>();       // holds DAY NUMBERS still waiting

    for (int i = 0; i < n; i++) {              // i = the day that just arrived
        while (stack.Count > 0 && temperatures[i] > temperatures[stack.Peek()]) {
            int prev = stack.Pop();            // a waiting day whose wait just ended
           answer[prev] = i-prev;              // the blank
        }
        stack.Push(i);                         // today joins the waiting list
    }
    return answer;
}
}
