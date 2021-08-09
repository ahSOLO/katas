using System.Collections.Generic;
using System;


public class Program {

	public bool ClassPhotos(List<int> redShirtHeights, List<int> blueShirtHeights) {
		if (redShirtHeights.Count != blueShirtHeights.Count)
			return false;
		if (redShirtHeights.Count == 1)
			return redShirtHeights[0] != blueShirtHeights[0];
		
		redShirtHeights.Sort();
		blueShirtHeights.Sort();
		
		bool redIsLower = redShirtHeights[0] < blueShirtHeights[0] ? true : false;
		for (int i = 1; i < redShirtHeights.Count; i++)
		{
			if (redIsLower)
			{
				if (redShirtHeights[i] >= blueShirtHeights[i])
					return false;
			}
			else
			{
				if (blueShirtHeights[i] >= redShirtHeights[i])
					return false;
			}
		}
		return true;
	}
}