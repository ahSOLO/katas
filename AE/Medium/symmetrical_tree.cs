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

	public bool SymmetricalTree(BinaryTree tree) {
		if (tree.left == null && tree.right == null)
            return true;
        else if (tree.left == null || tree.right == null)
            return false;

        return SymmetryCheck(tree.left, tree.right);
	}

    public bool SymmetryCheck(BinaryTree node1, BinaryTree node2)
    {
        if (node1 == null && node2 == null)
            return true;
        else if (node1 == null || node2 == null || node1?.value != node2?.value)
        {
            return false;
        }

        return (SymmetryCheck(node1?.left, node2?.right) && SymmetryCheck(node1?.right, node2?.left));
    }
}

