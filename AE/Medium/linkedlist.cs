using System;
// Feel free to add new properties and methods to the class.
public class Program
{
    public class DoublyLinkedList
    {
        public Node Head;
        public Node Tail;
        
        public void PrintList(Node node = null)
        {
            if (node == null)
            {
                if (Head == null)
                {
                    Console.WriteLine("List is empty.");
                    return;
                }
                else node = Head;
            }
            Console.WriteLine(node);
            if (node.Next != null) PrintList(node.Next);
            else Console.WriteLine("List end.");
        }

        public void SetHead(Node node)
        {
            Console.WriteLine($"Setting Head to {node.Value}");
            if (Head == node) return;
            
            if (Head == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                InsertBefore(Head, node);
            }

            PrintList();
        }

        public void SetTail(Node node)
        {
            Console.WriteLine($"Setting Tail to {node.Value}");
            if (Tail == node) return;

            if (Tail == null)
            {
                SetHead(node);
            }
            else
            {
                InsertAfter(Tail, node);
            }

            PrintList();
        }

        public void InsertBefore(Node node, Node nodeToInsert)
        {
            Console.WriteLine($"Inserting {nodeToInsert.Value} before {node.Value}");
            if (node.Prev == nodeToInsert) return; // Return if the nodes are already in the correct place.
            
            Node prevNode = node.Prev;

            Remove(nodeToInsert);

            if (node == Head) Head = nodeToInsert;
            SetPrev(nodeToInsert, prevNode);
            SetNext(nodeToInsert, node);
            if (prevNode != null) SetNext(prevNode, nodeToInsert);
            SetPrev(node, nodeToInsert);

            PrintList();
        }

        public void InsertAfter(Node node, Node nodeToInsert)
        {
            Console.WriteLine($"Inserting {nodeToInsert.Value} after {node.Value}");
            if (node.Next == nodeToInsert) return; // Return if the nodes are already in the correct place.

            Node nextNode = node.Next;
            Remove(nodeToInsert);
            
            if (node == Tail) Tail = nodeToInsert;
            SetPrev(nodeToInsert, node);
            SetNext(nodeToInsert, nextNode);
            if (nextNode != null) SetPrev(nextNode, nodeToInsert);
            SetNext(node, nodeToInsert);

            PrintList();
        }

        public void InsertAtPosition(int position, Node nodeToInsert)
        {
            Console.WriteLine($"Inserting {nodeToInsert.Value} at position {position}");

            if (Head == null || position <= 1)
            {
                SetHead(nodeToInsert);
            }
            Node nthNode = GetNodeAtPosition(position);
            if (nthNode == null)
            {
                SetTail(nodeToInsert);
            }
            else if (nthNode != nodeToInsert)
            {
                InsertBefore(nthNode, nodeToInsert);
            }

            PrintList();
        }

        public Node GetNodeAtPosition(int position)
        {
            Node node = Head;
            for (int i = 1; i < position; i++)
            {
                node = node?.Next;
            }
            return node;
        }

        public void RemoveNodesWithValue(int value)
        {
            Console.WriteLine($"Removing nodes with value {value}");
            Node foundNode = SearchRecursive(Head, value);
            while (foundNode != null)
            {
                Node nextNode = foundNode.Next;
                Remove(foundNode);
                if (nextNode != null) foundNode = SearchRecursive(nextNode, value);
                else foundNode = null;
            }

            PrintList();
        }

        public void Remove(Node node)
        {
            Console.WriteLine($"Removing node {node} from list");

            if (node == Head) Head = node.Next;
            if (node == Tail) Tail = node.Prev;
            var temp = node.Prev;
            if (node.Prev != null) SetNext(node.Prev, node.Next ?? null);
            if (node.Next != null) SetPrev(node.Next, temp ?? null);
            SetPrev(node, null);
            SetNext(node, null);

            PrintList();
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
