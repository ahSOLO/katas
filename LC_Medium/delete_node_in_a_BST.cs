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
    public TreeNode GetMinimumNode(TreeNode root)
    {
        while (root?.left != null)
        {
            root = root.left;
        }

        return root;
    }

    public TreeNode DeleteNode(TreeNode root, int key) 
    {
        if (root == null)
        {
            return null;
        }
        
        if (root.val > key)
        {
            if (root.left != null)
            {
                root.left = DeleteNode(root.left, key);
            }
            else
            {
                // Not found in BST
                return root;
            }
        }
        else if (root.val < key)
        {
            if (root.right != null)
            {
                root.right = DeleteNode(root.right, key);
            }   
            else
            {
                // Not found in BST
                return root;
            }
        }
        else
        {
            // Node found
            if (root.right == null)
            {
                return root.left;
            } 
            else if (root.left == null)
            {
                return root.right;
            }
            else 
            {
                TreeNode minNode = GetMinimumNode(root.right);
                root.val = minNode.val;
                root.right = DeleteNode(root.right, minNode.val);
            }
        }

        return root;
    }
}