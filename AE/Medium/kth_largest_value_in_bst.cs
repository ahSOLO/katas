using System;
using System.Collections.Generic;

public class Program {
	// This is an input class. Do not edit.
	public class BST {
		public int value;
		public BST left = null;
		public BST right = null;

		public BST(int value) {
			this.value = value;
		}
	}

	public int FindKthLargestValueInBst(BST tree, int k) {
		List<int> array = new List<int>();
		return FindKthLargestValueInBst(tree, k, array);
	}

	public int FindKthLargestValueInBst(BST tree, int k, List<int> array) {
		int output = -1;
		if (tree.right != null) 
			output = FindKthLargestValueInBst(tree.right, k, array);
		array.Add(tree.value);
		if (k == array.Count)
			return tree.value;
		if (tree.left != null && output == -1)
			output = FindKthLargestValueInBst(tree.left, k, array);
		return output;
	}
}

