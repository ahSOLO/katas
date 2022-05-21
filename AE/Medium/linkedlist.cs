using System;
// Feel free to add new properties and methods to the class.
public class Program
{
    public class DoublyLinkedList
    {
        public Node Head;
        public Node Tail;

        public void SetHead(Node node)
        {
            if (Head == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                InsertBefore(Head, node);
            }
        }

        public void SetTail(Node node)
        {
            if (Tail == null)
            {
                SetHead(node);
            }
            else
            {
                InsertAfter(Tail, node);
            }
        }

        public void InsertBefore(Node node, Node nodeToInsert)
        {
            Node prevNode = node.Prev ?? null;
            if (node == Head) Head = nodeToInsert;

            Remove(nodeToInsert);

            SetPrev(nodeToInsert, prevNode);
            SetNext(nodeToInsert, node);
            if (prevNode != null) SetNext(prevNode, nodeToInsert);
            SetPrev(node, nodeToInsert);
        }

        public void InsertAfter(Node node, Node nodeToInsert)
        {
            Node nextNode = node.Next ?? null;
            if (node == Tail) Tail = nodeToInsert;

            Remove(nodeToInsert);
            
            SetPrev(nodeToInsert, node);
            SetNext(nodeToInsert, nextNode);
            if (nextNode != null) SetPrev(nextNode, nodeToInsert);
            SetNext(node, nodeToInsert);
        }

        public void InsertAtPosition(int position, Node nodeToInsert)
        {
            if (Head == null)
            {
                SetHead(nodeToInsert);
                return;
            }
            Node prevNode = Head;
            for (int i = 1; i < position; i++)
            {
                if (prevNode.Next == null) break;
                
                prevNode = prevNode.Next;
            }
            if (prevNode != nodeToInsert) InsertBefore(prevNode, nodeToInsert);
            Console.WriteLine($"After Insertion At Position: {nodeToInsert.ToString()}");
        }

        public void RemoveNodesWithValue(int value)
        {
            Node foundNode = SearchRecursive(Head, value);
            while (foundNode != null)
            {
                Node nextNode = foundNode.Next;
                Remove(foundNode);
                if (nextNode != null) foundNode = SearchRecursive(nextNode, value);
                else foundNode = null;
            }
        }

        public void Remove(Node node)
        {
            if (node == Head) Head = node.Next;
            if (node == Tail) Tail = node.Prev;
            var temp = node.Prev;
            if (node.Prev != null) SetNext(node.Prev, node.Next ?? null);
            if (node.Next != null) SetPrev(node.Next, temp ?? null);
            SetPrev(node, null);
            SetNext(node, null);
        }

        public bool ContainsNodeWithValue(int value)
        {
            return (SearchRecursive(Head, value) != null);
        }

        public Node SearchRecursive(Node node, int value)
        {
            if (node.Value == value)
                return node;
            if (node.Next == null)
                return null;
            return SearchRecursive(node.Next, value);
        }

        private void SetPrev(Node nodeToSet, Node prev)
        {
            if (nodeToSet == Head && prev != null) Head = prev;
            if (prev != null && prev == Tail && prev.Prev != null) Tail = prev.Prev;
            nodeToSet.Prev = prev;
        }

        private void SetNext(Node nodeToSet, Node next)
        {
            if (nodeToSet == Tail && next != null) Tail = next;
            if (next != null && next == Head && next.Next != null) Head = next.Next;
            nodeToSet.Next = next;
        }

    }

    // Do not edit the class below.
    public class Node
    {
        public int Value;
        public Node Prev;
        public Node Next;

        public Node(int value)
        {
            this.Value = value;
        }

        public override string ToString()
        {
            return $"Value: {Value}, Prev: {Prev?.Value}, Next: {Next?.Value}";
        }
    }
}
