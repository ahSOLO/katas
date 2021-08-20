using System;

public class Program {
	public static bool ValidateBst(BST tree) {
		return ValidateBstNode(tree);
	}
	
	static bool ValidateBstNode(BST node, int min = int.MinValue, int max = int.MaxValue)
	{
		if (node.left == null && node.right == null)
		{
			return true;
		}
		bool leftResult = true;
		bool rightResult = true;
		if (node.left != null)
		{
			if (node.left.value < node.value && node.left.value >= min && node.left.value < max)
				leftResult = ValidateBstNode(node.left, min, node.value);
			else
				return false;
		}
		if (node.right != null)
		{
			if (node.right.value >= node.value && node.right.value >= min && node.right.value < max)
				rightResult = ValidateBstNode(node.right, node.value, max);
			else
				return false;
		}
		return leftResult && rightResult;
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
