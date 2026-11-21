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
    // Pass 1: count the length
    int length = 0;
    ListNode curr = head;
    while (curr != null)
    {
        length++;
        curr = curr.next;
    }

    // Dummy node in front of head (handles removing the head)
    ListNode dummy = new ListNode(0);
    dummy.next = head;

    // Pass 2: walk (length - n) steps from the dummy
    ListNode walker = dummy;               // separate pointer, dummy stays put
    for (int i = 0; i < length - n; i++)
    {
        walker = walker.next;
    }

    // walker is the node BEFORE the one to remove
    walker.next = walker.next.next;

    return dummy.next;                     // real head
}
}
