using System;


public class Program {
	// This is an input class. Do not edit.
	public class BinaryTree {
		public int value;
		public BinaryTree left = null;
		public BinaryTree right = null;

		public BinaryTree(int value) {
			this.value = value;
		}
	}


	public BinaryTree MergeBinaryTrees(BinaryTree tree1, BinaryTree tree2) {
		var mergedTree = MergeNode(tree1, tree2);
		return mergedTree;
	}

    public BinaryTree MergeNode(BinaryTree node1, BinaryTree node2)
    {
        if (node1 == null)
        {
            if (node2 == null)
            {
                return null;                
            }
            var output = new BinaryTree(node2.value);
            output.left = node2.left;
            output.right = node2.right;
            return output;
        }
        else if (node2 == null)
        {
            var output = new BinaryTree(node1.value);
            output.left = node1.left;
            output.right = node1.right;
            return output;
        }
        else
        {
            var output = new BinaryTree(node1.value + node2.value);
            output.left = MergeNode(node1.left, node2.left);
            output.right = MergeNode(node1.right, node2.right);
            return output;
        }
    }
}

