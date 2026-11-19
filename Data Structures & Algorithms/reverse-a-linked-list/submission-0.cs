/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
 
public class Solution {
   public ListNode ReverseList(ListNode head)
{
    ListNode prev = null;
    ListNode curr = head;

    while (curr != null)
    {
        ListNode nextNode = curr.next;  // 1. save
        curr.next = prev;               // 2. turn the arrow
        prev = curr;                    // 3. prev moves forward
        curr = nextNode;                // 4. curr moves forward
    }

    return prev;
}
}
