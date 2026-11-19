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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
{
    ListNode dummy = new ListNode(0);   // placeholder, never returned
    ListNode tail = dummy;              // last node of the result so far

    while (list1 != null && list2 != null)
    {
        if (list1.val <= list2.val)
        {
            tail.next = list1;          // attach the smaller node
            list1 = list1.next;         // move list1 forward
        }
        else
        {
            tail.next = list2;          // attach the smaller node
            list2 = list2.next;  
        }
        tail = tail.next;               // tail moves to the node just attached
    }

    if (list1 != null) tail.next = list1;   // attach the leftover
    else tail.next = list2;

    return dummy.next;                  // skip the placeholder
}
}