using System;
using System.Collections.Generic;

public class Program {
	public static BST MinHeightBst(List<int> array) {
		return MinHeightBst(array, null, 0, array.Count - 1);
	}
	
	public static BST MinHeightBst(List<int> array, BST node, int startIdx, int endIdx) {
		if (startIdx > endIdx)
			return null;
		int midIdx = (startIdx + endIdx) / 2;
		node = new BST(array[midIdx]);		
		node.left = MinHeightBst(array, node.left, startIdx, midIdx - 1);
		node.right = MinHeightBst(array, node.right, midIdx + 1, endIdx);
		return node;
	}
	

	public class BST {
		public int value;
		public BST left;
		public BST right;

		public BST(int value) {
			this.value = value;
			left = null;
			right = null;
		}

		public void insert(int value) {
			if (value < this.value) {
				if (left == null) {
					left = new BST(value);
				} else {
					left.insert(value);
				}
			} else {
				if (right == null) {
					right = new BST(value);
				} else {
					right.insert(value);
				}
			}
		}
	}
}
