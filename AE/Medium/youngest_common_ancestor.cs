using System;
using System.Collections.Generic;

public class Program {
	public static AncestralTree GetYoungestCommonAncestor(
		AncestralTree topAncestor,
		AncestralTree descendantOne,
		AncestralTree descendantTwo
		) {
		if (descendantOne.ancestor == null)
			return descendantOne;
		if (descendantTwo.ancestor == null)
			return descendantTwo;
		List<AncestralTree> ancestorList1 = CreateAncestorList(descendantOne);
		List<AncestralTree> ancestorList2 = CreateAncestorList(descendantTwo);
		var longerList = ancestorList1.Count > ancestorList2.Count ? ancestorList1 : ancestorList2 ;
		var shorterList = longerList == ancestorList1 ? ancestorList2 : ancestorList1 ;
		
		var diff = longerList.Count - shorterList.Count;
		for (int i = 0; i < shorterList.Count; i++)
		{
			if (shorterList[i] == longerList[diff + i])
				return shorterList[i];
		}		
		
		return null;
	}
	
	public static List<AncestralTree> CreateAncestorList(AncestralTree descendant)
	{
		List<AncestralTree> ancestorList = new List<AncestralTree>();
		var current = descendant;
		while (current != null)
		{
			ancestorList.Add(current);
			current = current.ancestor;
		}
		return ancestorList;
	}

	public class AncestralTree {
		public char name;
		public AncestralTree ancestor;

		public AncestralTree(char name) {
			this.name = name;
			this.ancestor = null;
		}

		// This method is for testing only.
		public void AddAsAncestor(AncestralTree[] descendants) {
			foreach (AncestralTree descendant in descendants) {
				descendant.ancestor = this;
			}
		}
	}
}
