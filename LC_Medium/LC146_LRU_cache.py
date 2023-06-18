class Node:
    def __init__(self, key, val):
        self.key, self.val = key, val
        self.prev = self.next = None

class LRUCache:
    # cache implemented as a hashmap
    # track usage in a doubly linked list

    def __init__(self, capacity: int):
        self.cache = {}
        self.capacity = capacity
        self.head, self.tail = None, None

    def remove(self, node: Node) -> None:         
        node.next.prev = node.prev
        if node.prev != None:
            node.prev.next = node.next
        if self.head == node:
            self.head = node.next
        if self.tail == node:
            self.tail = node.prev
        node.prev = None
        node.next = None

    def insert(self, node: Node) -> None:
        if self.tail != None:
            self.tail.next = node
            node.prev = self.tail
        self.tail = node

    def get(self, key: int) -> int:
    # move node to tail of linkedlist
        if len(self.cache) == 0 or key not in self.cache:
            return -1
        node = self.cache[key]
        if node.next != None:            
            self.remove(node)            
            self.insert(node)
        return node.val

    def put(self, key: int, value: int) -> None:
        # Update value if it exists
        if key in self.cache:
            self.cache[key].val = value
            node = self.cache[key]
            if node.next != None:
                self.remove(node)
        # Otherwise, add the key value pair to the cache
        else:
            self.cache[key] = Node(key, value)
  
        node = self.cache[key]
        if self.head is None:
            self.head = node
        if self.tail != node:
            self.insert(node)

        # if cache reached capacity, remove head of linked list and associated entry in hashmap
        if len(self.cache) > self.capacity:
            temp = self.head
            self.remove(self.head)
            self.cache.pop(temp.key)


# Your LRUCache object will be instantiated and called as such:
# obj = LRUCache(capacity)
# param_1 = obj.get(key)
# obj.put(key,value)