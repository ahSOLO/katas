using System;
using System.Collections.Generic;

public class Program {
	// This is the class of the input root. Do not edit it.
	public class BinaryTree {
		public int value;
		public BinaryTree left;
		public BinaryTree right;

		public BinaryTree(int value) {
			this.value = value;
			this.left = null;
			this.right = null;
		}
	}

	public static List<int> BranchSums(BinaryTree root) {
		var sums = new List<int>();
		return BranchSums(root, 0, sums);
	}
	
	public static List<int> BranchSums(BinaryTree node, int currentSum, List<int> sums) {
		currentSum += node.value;
		if (node.left == null && node.right == null)
			sums.Add(currentSum);
		if (node.left != null)
			BranchSums(node.left, currentSum, sums);
		if (node.right != null)
			BranchSums(node.right, currentSum, sums);
		return sums;
	}
}
