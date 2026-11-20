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
    public bool HasCycle(ListNode head) {
    ListNode slow = head;                         // tortoise: 1 house per round
    ListNode fast = head;                         // hare: 2 houses per round

    while (fast != null && fast.next != null) {   // both houses exist, so the jump is safe
        slow = slow.next;                         // move 1
        fast = fast.next.next;                    // move 2
        if (slow == fast) {                       // same HOUSE (reference), not same val
            return true;                          // fast lapped slow: cycle
        }
    }
    return false;                                 // fast reached null: no cycle
}
}
