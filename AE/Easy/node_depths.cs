using System;

public class Program {
	public static int NodeDepths(BinaryTree root) {
		return NodeDepths(root, 0);
	}
	
	public static int NodeDepths(BinaryTree node, int currentDepth){
		int sumOfDepths = 0;
		sumOfDepths += currentDepth;
		if (node.left != null)
			sumOfDepths += NodeDepths(node.left, currentDepth + 1);
		if (node.right != null)
			sumOfDepths += NodeDepths(node.right, currentDepth + 1);
		return sumOfDepths;
	}

	public class BinaryTree {
		public int value;
		public BinaryTree left;
		public BinaryTree right;

		public BinaryTree(int value) {
			this.value = value;
			left = null;
			right = null;
		}
	}
}
