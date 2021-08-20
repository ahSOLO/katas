using System;

public class Program {
	public class BST {
		public int value;
		public BST left;
		public BST right;

		public BST(int value) {
			this.value = value;
		}

		public BST Insert(int value) {
			if (value < this.value)
				return this.left == null ? this.left = new BST(value) : this.left.Insert(value);
			if (value >= this.value)
				return this.right == null ? this.right = new BST(value) : this.right.Insert(value);
			return null;
		}

		public bool Contains(int value) {
			BST parentNode = this;
			if (TryGet(value, ref parentNode, this) != null)
				return true;
			return false;
		}

		public BST Remove(int value) {
			BST parentNode = this;
			BST node = TryGet(value, ref parentNode, this);
			if (node == null)
				return null;
			// If node to remove has no children
			if (node.left == null && node.right == null)
			{				
				if (parentNode.left == node)
					parentNode.left = null;
				else if (parentNode.right == node)
					parentNode.right = null;
				return parentNode;
			}
			// If node to remove has children
			else
			{
				BST replacementNode = node;
				while (replacementNode != null)
				{
					BST closestChild = replacementNode.GetClosestChild(ref parentNode);
					replacementNode.value = closestChild.value;
					if (closestChild.left != null || closestChild.right != null)
					{
						replacementNode = closestChild;
					}
					else
					{
						Console.Write(parentNode.value);
						if (parentNode.left == closestChild)
							parentNode.left = null;
						else if (parentNode.right == closestChild)
							parentNode.right = null;
						replacementNode = null;
						return parentNode;
					}
				}
			}
			return null;
		}
		
		private BST TryGet(int value, ref BST parentNode, BST currentParent){
			if (this.value == value)
			{
				parentNode = currentParent;
				return this;
			}
			if (this.left != null && value < this.value)
			{
				BST leftResult = this.left.TryGet(value, ref parentNode, this);
				return leftResult;
			}
			if (this.right != null && value > this.value)
			{
				BST rightResult = this.right.TryGet(value, ref parentNode, this);
				return rightResult;
			}
			return null;
		}
		
		private BST GetClosest(int value, ref BST parentNode, int diff){
			BST closest = this;
			if (this.left != null && value < this.value)
			{
				BST leftClosest = this.left.GetClosest(value, ref parentNode, diff);
				int currentDiff = Math.Abs(leftClosest.value - value);
				if (currentDiff < diff)
				{
					diff = currentDiff;
					parentNode = this.left;
					closest = leftClosest;
				}
			}
			if (this.right != null && value > this.value)
			{
				BST rightClosest = this.right.GetClosest(value, ref parentNode, diff);
				int currentDiff = Math.Abs(rightClosest.value - value);
				if (currentDiff < diff)
				{
					diff = currentDiff;
					parentNode = this.right;
					closest = rightClosest;					
				}
			}
			return closest;
		}
		
		private BST GetClosestChild(ref BST parentNode)
		{
			BST leftParent = this;
			BST rightParent = this;
			BST leftClosest = null;
			BST rightClosest = null;
			int diff = int.MaxValue;
			if (this.left != null)
				leftClosest = this.left.GetClosest(this.value, ref leftParent, diff);
			if (this.right != null)
				rightClosest = this.right.GetClosest(this.value, ref rightParent, diff);
			if (leftClosest != null && rightClosest != null)			
			{
				if (Math.Abs(leftClosest.value - value) < Math.Abs(rightClosest.value - value))
				{
					parentNode = leftParent;
					return leftClosest;
				}
				else
				{
					parentNode = rightParent;
					return rightClosest;
				}
			}
			else if (leftClosest != null)
			{
				parentNode = leftParent;
				return leftClosest;
			}
			else
			{
				parentNode = rightParent;
				return rightClosest;
			}
		}
	}
}
