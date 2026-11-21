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
public ListNode RemoveNthFromEnd(ListNode head, int n)
{
    ListNode dummy = new ListNode(0);
    dummy.next = head;

    ListNode fast = dummy;
    ListNode slow = dummy;

    // Head start: fast moves n steps first
    for (int i = 0; i < n; i++)
    {
        fast = fast.next;
    }

    // Move both until fast is on the LAST node
    while (fast.next != null)
    {
        fast = fast.next;
        slow = slow.next;
    }

    // slow is the node BEFORE the one to remove
    slow.next = slow.next.next;

    return dummy.next;
}
}
