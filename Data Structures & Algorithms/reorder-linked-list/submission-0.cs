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
    public void ReorderList(ListNode head)
{
    if (head == null || head.next == null) return;

    // Step 1: find the middle and cut the list
    ListNode slow = head;
    ListNode fast = head;
    while (fast != null && fast.next != null)
    {
        slow = slow.next;
        fast = fast.next.next;
    }
    ListNode second = slow.next;
    slow.next = null;

    // Step 2: reverse the second half
    ListNode prev = null;
    ListNode curr = second;
    while (curr != null)
    {
        ListNode next = curr.next;  // save
        curr.next = prev;           // flip
        prev = curr;                // move
        curr = next;                // move
    }

    // Step 3: merge the two halves by alternating
    ListNode first = head;
    ListNode sec = prev;
    while (sec != null)
    {
        ListNode tmp1 = first.next;  // save
        ListNode tmp2 = sec.next;    // save
        first.next = sec;            // flip
        sec.next = tmp1;             // flip
        first = tmp1;                // move
        sec = tmp2;                  // move
    }
}
}
