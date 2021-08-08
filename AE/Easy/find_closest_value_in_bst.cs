using System;

// First Attempt

/*
public class Program {
	public static int FindClosestValueInBst(BST tree, int target) {
		int diff = Math.Abs(tree.value - target);
		int leftDiff = int.MaxValue;
		int rightDiff = int.MaxValue;
		if (tree.left != null)
			leftDiff = FindClosestDiff(tree.left, target);
		if (tree.right != null)
			rightDiff = FindClosestDiff(tree.right, target);
		if (Math.Min(diff, Math.Min(leftDiff, rightDiff)) == diff)
			return tree.value;
		else if (Math.Min(diff, Math.Min(leftDiff, rightDiff)) == leftDiff)
			return FindClosestValueInBst(tree.left, target);
		else
			return FindClosestValueInBst(tree.right, target);
	}
	
	public static int FindClosestDiff(BST node, int target) {
		var val = FindClosestValueInBst(node, target);
		return Math.Abs(val - target);
	}

	public class BST {
		public int value;
		public BST left;
		public BST right;

		public BST(int value) {
			this.value = value;
		}
	}
}
*/

// Most efficient solution

public class Program {
	public static int FindClosestValueInBst(BST tree, int target) {
		var node = tree;
		var closest = tree.value;
		while(node != null)
		{
			if (Math.Abs(node.value - target) < Math.Abs(closest - target))
				closest = node.value;
			if (target < node.value)
				node = node.left;
			else if (target > node.value)
				node = node.right;
			else 
				break;
		}
		return closest;
	}

	public class BST {
		public int value;
		public BST left;
		public BST right;

		public BST(int value) {
			this.value = value;
		}
	}
}
