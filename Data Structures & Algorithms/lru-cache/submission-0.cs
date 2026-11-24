public class Node
{
    public int key;      // needed so we can delete the dictionary entry on eviction
    public int value;
    public Node prev;    // node on the left (older side)
    public Node next;    // node on the right (newer side)

    public Node(int key, int value)
    {
        this.key = key;
        this.value = value;
    }
}

public class LRUCache {

    private int capacity;
    private Dictionary<int, Node> map;   // key -> node (find in O(1))
    private Node left;                   // dummy L: oldest side
    private Node right;                  // dummy R: newest side

    public LRUCache(int capacity)
    {
        this.capacity = capacity;
        map = new Dictionary<int, Node>();
        left = new Node(0, 0);
        right = new Node(0, 0);

        // empty chain: L <-> R
        left.next = right;
        right.prev = left;
    }

     private void Remove(Node node)
    {
        Node before = node.prev;
        Node after = node.next;

        before.next = after;
        after.prev = before;
    }
     private void Insert(Node node)
    {
        Node last = right.prev;   // save BEFORE changing right.prev

        last.next = node;
        node.prev = last;
        node.next = right;
        right.prev = node;
    }
    public int Get(int key)
    {
        if (!map.TryGetValue(key, out Node node))
            return -1;

        Remove(node);       // using a key makes it the newest
        Insert(node);
        return node.value;
    }
    
    public void Put(int key, int value)
    {
        // Case 1: key exists -> update value, mark as newest
        if (map.TryGetValue(key, out Node node))
        {
            node.value = value;
            Remove(node);
            Insert(node);
            return;
        }

        // Case 2: key is new. If the shelf is full, throw out the oldest first.
        if (map.Count == capacity)
        {
            Node oldest = left.next;
            Remove(oldest);
            map.Remove(oldest.key);
        }

        Node newNode = new Node(key, value);
        map[key] = newNode;
        Insert(newNode);
    }
}
