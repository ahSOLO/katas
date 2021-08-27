using System;
using System.Collections.Generic;

public class Program {
	public int BinaryTreeDiameter(BinaryTree tree) {
		int maxDiam = 0;
		CheckPotentialDiameter(tree, ref maxDiam);
		return maxDiam;
	}
	
	public int CheckPotentialDiameter(BinaryTree tree, ref int maxDiam) {
		int diam = 0;
		if (tree.left == null && tree.right == null)
		{
			return diam;
		}
		if (tree.left != null)
		{
			int leftDepth = 0;
			diam += BinaryTreeDepth(tree.left, ref leftDepth);
			CheckPotentialDiameter(tree.left, ref maxDiam);
		}
		if (tree.right != null)
		{
			int rightDepth = 0;
			diam += BinaryTreeDepth(tree.right, ref rightDepth);
			CheckPotentialDiameter(tree.right, ref maxDiam);
		}
		maxDiam = Math.Max(diam, maxDiam);
		return diam;
	}
																
	public int BinaryTreeDepth(BinaryTree tree, ref int depth) {
		depth++;
		if (tree.left == null && tree.right == null)
			return depth;
		int leftDepth = 0;
		int rightDepth = 0;
		if (tree.left != null)
		{
			leftDepth = BinaryTreeDepth(tree.left, ref leftDepth);
		}
		if (tree.right != null)
		{
			rightDepth = BinaryTreeDepth(tree.right, ref rightDepth);
		}
		return depth += Math.Max(leftDepth, rightDepth);
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

