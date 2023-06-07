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
    TreeNode found = null;
    public int KthSmallest(TreeNode root, int k) 
    {
        if (root.left == null && root.right == null)
        {
            return root.val;
        }

        KthSmallestByRef(root, ref k);

        return found.val;
    }

    public void KthSmallestByRef(TreeNode root, ref int k)
    {
        if (root == null)
        {
            return;
        }
        
        KthSmallestByRef(root.left, ref k);
        k--;
        if (k == 0)
        {
            found = root;
            return;
        }
        KthSmallestByRef(root.right, ref k);
    }
}