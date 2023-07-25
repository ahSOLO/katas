/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    Dictionary<Node, Node> oldToNewDict = new Dictionary<Node, Node>();
    
    public Node CloneGraph(Node node) {
        return clone(node);
    }

    public Node clone(Node node) {
        if (node == null)
        {
            return null;
        }
        if (oldToNewDict.ContainsKey(node))
        {
            return oldToNewDict[node];
        }
        else
        {
            Node cpy = new Node(node.val);
            oldToNewDict[node] = cpy;
            foreach (Node neighbor in node.neighbors)
            {
                cpy.neighbors.Add(clone(neighbor));
            }
            return cpy;
        }
    }
}