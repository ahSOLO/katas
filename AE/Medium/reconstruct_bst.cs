using System.Collections.Generic;
using System;


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


	public BST ReconstructBst(List<int> preOrderTraversalValues) {
		int idx = 0;
		return ReconstructBst(preOrderTraversalValues, ref idx, int.MinValue, int.MaxValue);
	}
	
	public BST ReconstructBst(List<int> preOrderTraversalValues, ref int idx, int min, int max) {
		BST node = new BST(preOrderTraversalValues[idx]);
		if (idx + 1 < preOrderTraversalValues.Count 
				&& preOrderTraversalValues[idx + 1] < node.value
			 	&& preOrderTraversalValues[idx + 1] >= min
			 	&& preOrderTraversalValues[idx + 1] < max)
		{
			idx++;
			node.left = ReconstructBst(preOrderTraversalValues, ref idx, min, node.value);
		}
		if (idx + 1 < preOrderTraversalValues.Count 
				&& preOrderTraversalValues[idx + 1] >= node.value
				&& preOrderTraversalValues[idx + 1] >= min
			 	&& preOrderTraversalValues[idx + 1] < max)
		{
			idx++;
			node.right = ReconstructBst(preOrderTraversalValues, ref idx, node.value, max);
		}			
		return node;
	}

}

