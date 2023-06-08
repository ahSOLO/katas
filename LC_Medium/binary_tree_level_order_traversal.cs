/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public IList<IList<int>> LevelOrder(TreeNode root) {
        var output = new List<IList<int>>();
        if (root == null)
        {
            return output;
        }
        
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);
        
        TreeNode cur = null;

        while (q.Count > 0)
        {
            var tempList = new List<int>();
            // Cache the initial length of the queue
            var qLen = q.Count;

            // Iterate through the initial length to ensure we only hit that level
            for (int i = 0; i < qLen; i++)
            {
                cur = q.Dequeue();
                tempList.Add(cur.val);
                if (cur.left != null)
                {
                    q.Enqueue(cur.left);
                }
                if (cur.right != null)
                {
                    q.Enqueue(cur.right);
                }
            }

            output.Add(tempList);
        }

        return output;
    }
}