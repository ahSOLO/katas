public class LRUCache {
    LinkedList<(int key, int value)> linkedList = new LinkedList<(int key, int value)>();
    Dictionary<int, LinkedListNode<(int key, int value)>> cache = 
        new Dictionary<int, LinkedListNode<(int key, int value)>>();
    int capacity;

    public LRUCache(int capacity) {
        this.capacity = capacity;
    }
    
    public int Get(int key) {
        if (cache.Count == 0 || !cache.ContainsKey(key))
        {
            return -1;
        }
        var node = cache[key];
        if (linkedList.Last.Value.key != key)
        {
            linkedList.Remove(node);
            linkedList.AddLast(node);
        }
        return node.Value.value;
    }
    
    public void Put(int key, int value) {
        if (cache.ContainsKey(key))
        {
            linkedList.Remove(cache[key]);
        }
        cache[key] = linkedList.AddLast((key, value));
        Console.WriteLine(linkedList.Count);

        if (linkedList.Count > capacity)
        {
            cache.Remove(linkedList.First.Value.key);
            linkedList.RemoveFirst();
        }
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */