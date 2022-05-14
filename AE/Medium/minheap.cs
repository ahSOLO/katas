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

		public int LesserChildIdx(int idx)
        {
			int leftChildIdx = LeftChildIdx(idx);
			int rightChildIdx = RightChildIdx(idx);
			return heap.Count - 1 < leftChildIdx ? -1
				: heap.Count - 1 == leftChildIdx ? leftChildIdx 
				: heap[leftChildIdx] < heap[rightChildIdx] ? leftChildIdx : rightChildIdx;
		}

		public int ParentIdx(int idx)
        {
			return idx == 0 ? -1 : ((idx - 1) / 2);
        }

		public MinHeap(List<int> array) 
        {
			heap = BuildHeap(array);
		}

		public List<int> BuildHeap(List<int> array) 
        {
			foreach (int number in array)
            {
				Insert(number);
            }
			return heap;
		}

		public void SiftDown(ref int currentIdx, int endIdx, List<int> heap) 
        {
			while (heap[currentIdx] > heap[endIdx])
			{
				Swap(currentIdx, endIdx);
				currentIdx = endIdx;
			}
		}

		public void SiftUp(ref int currentIdx, List<int> heap) 
        {
			var parentIdx = ParentIdx(currentIdx);
			while (heap[currentIdx] < heap[parentIdx])
            {
				Swap(currentIdx, parentIdx);
				currentIdx = parentIdx;
			}
		}

		public int Peek() 
        {
			return heap.Count > 0 ? heap[0] : -1 ;
		}

		public int Remove() 
        {
			if (heap.Count == 0) return -1;

			int minValue = heap[0];
			heap[0] = int.MaxValue;
			if (heap.Count > 1)
            {
				int currentIdx = 0;
				int childIdx = LesserChildIdx(currentIdx);
				while (childIdx != -1 && heap[currentIdx] > heap[childIdx])
				{
					SiftDown(ref currentIdx, childIdx, heap);
					childIdx = LesserChildIdx(currentIdx);
				}
            }
			heap.RemoveAt(heap.Count - 1);
			return minValue;
		}

		public void Insert(int value) 
        {
			heap.Add(value);
			if (heap.Count == 1) return;
			int currentIdx = heap.Count - 1;
			int parentIdx = ParentIdx(currentIdx);
			while (parentIdx != -1 && heap[currentIdx] < heap[parentIdx])
            {
				SiftUp(ref currentIdx, heap);
				parentIdx = ParentIdx(currentIdx);
			}
		}

		private void Swap(int idx1, int idx2)
        {
			int temp = heap[idx1];
			heap[idx1] = heap[idx2];
			heap[idx2] = temp;
        }
	}
}
