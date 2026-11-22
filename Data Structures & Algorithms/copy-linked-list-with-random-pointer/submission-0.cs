/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
   public Node copyRandomList(Node head)
{
    if (head == null) return null;

    // notebook: original node -> its clone
    Dictionary<Node, Node> map = new Dictionary<Node, Node>();

    // Round 1: create every clone (no arrows yet)
    Node curr = head;
    while (curr != null)
    {
        map[curr] = new Node(curr.val);
        curr = curr.next;
    }

    // Round 2: set the arrows of every clone using the notebook
    curr = head;                         // start again from the beginning
    while (curr != null)
    {
        if (curr.next != null)
            map[curr].next = map[curr.next];

        if (curr.random != null)
            map[curr].random = map[curr.random];

        curr = curr.next;
    }

    // the head of the copy is the clone of the original head
    return map[head];
}
}
