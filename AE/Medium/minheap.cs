using System;
using System.Collections.Generic;

public class Program 
{
	public class MinHeap 
    {
		public List<int> heap = new List<int>();

		public int LeftChildIdx(int idx)
        {
			return (idx * 2) + 1;
        }

		public int RightChildIdx(int idx)
        {
			return (idx * 2) + 2;
        }

		public int ParentIdx(int idx)
        {
			return Math.floor((idx - 1) / 2);
        }

		public MinHeap(List<int> array) 
        {
			heap = BuildHeap(array);
		}

		public List<int> BuildHeap(List<int> array) 
        {
			// Write your code here.
			return new List<int>();
		}

		public void SiftDown(int currentIdx, int endIdx, List<int> heap) 
        {
			int lesserChildIdx = heap[LeftChildIdx(currentIdx)] < heap[RightChildIdx(currentIdx)] ? LeftChildIdx(currentIdx) : RightChildIdx(currentIdx);
			while (heap[currentIdx] > lesserChildIdx)
			{
				int temp = heap[currentIdx];
				heap[currentIdx] = heap[lesserChildIdx];
				heap[lesserChildIdx] = temp;
			}
		}

		public void SiftUp(int currentIdx, List<int> heap) 
        {
			while(heap[currentIdx] < heap[ParentIdx(currentIdx)])
            {
				int temp = heap[currentIdx];
				heap[currentIdx] = heap[parentIdx];
				heap[parentIdx] = temp;
			}
		}

		public int Peek() 
        {
			// Write your code here.
			return -1;
		}

		public int Remove() 
        {
			// Write your code here.
			return -1;
		}

		public void Insert(int value) 
        {
			// Write your code here.
		}
	}
}
