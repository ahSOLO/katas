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

            Node temp = nodeToInsert.Prev;
            nodeToInsert.Prev?.SetNext(nodeToInsert.Next);
            nodeToInsert.Next?.SetPrev(temp);

            nodeToInsert.SetPrev(prevNode);
            nodeToInsert.SetNext(node);
            node.SetPrev(nodeToInsert);
        }

        public void InsertAfter(Node node, Node nodeToInsert)
        {
            Node nextNode = node.Next ?? null;
            if (node == Tail) Tail = nodeToInsert;

            node.SetNext(nodeToInsert);
            nodeToInsert.Prev?.SetNext(nodeToInsert.Next ?? null);
            nodeToInsert.Next?.SetPrev(nodeToInsert.Prev ?? null);
            
            nodeToInsert.SetPrev(node);
            nodeToInsert.SetNext(nextNode);
            nextNode?.SetPrev(node);
        }

        public void InsertAtPosition(int position, Node nodeToInsert)
        {
            Node prevNode = Head;
            for (int i = 0; i < position; i++)
            {
                if (prevNode.Next == null) break;
                
                prevNode = prevNode.Next;
            }
            InsertAfter(prevNode, nodeToInsert);
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
            Node temp = node.Prev;
            node.Prev?.SetNext(node.Next ?? null);
            node.Next?.SetPrev(temp ?? null);
            node.SetPrev(null);
            node.SetNext(null);
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

        public void SetPrev(Node prev)
        {
            Prev = prev;
        }

        public void SetNext(Node next)
        {
            Next = next;
        }
    }
}
