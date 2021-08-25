using System;

public class Program {
	public static void InvertBinaryTree(BinaryTree tree) {
		if (tree == null)
			return;
		InvertBinaryTree(tree.left);
		InvertBinaryTree(tree.right);
		BinaryTree temp = tree.left;
		tree.left = tree.right;
		tree.right = temp;
		}

	public class BinaryTree {
		public int value;
		public BinaryTree left;
		public BinaryTree right;

		public BinaryTree(int value) {
			this.value = value;
		}
	}
}
