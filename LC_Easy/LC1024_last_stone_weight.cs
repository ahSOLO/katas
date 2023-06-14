public class Solution {

    public int LastStoneWeight(int[] stones) {
        // Heapify stones
        MaxHeap maxHeap = new MaxHeap(stones);

        while (maxHeap.Count > 1)
        {
            // Smash stones
            int stone1 = maxHeap.ExtractMax();
            int stone2 = maxHeap.ExtractMax();
            int diff = stone1 - stone2;
            if (diff != 0)
            {
                maxHeap.Add(diff);
            }
        }
        if (maxHeap.Count == 0)
        {
            return 0;
        }
        return stones[0];
    }
}

public class MaxHeap
{
    private int[] heap;
    public int Count { get; private set; } 

    public MaxHeap(int[] initialArray)
    {
        heap = initialArray;
        Count = initialArray.Length;
        Heapify();
    }

    public void Add(int value)
    {
        if(Count - 1 < heap.Length)
        {
            heap[Count] = value;
            SiftUp(Count);
            Count++;
        }
    }

    public int ExtractMax()
    {   
        var max = heap[0];
        if(Count > 0)
        {
            Switch(0, Count - 1);
            Count--;
            SiftDown(0);             
        }
        return max;
    }
    
    private void Heapify()
    {
        for(int i = Count - 1; i > -1; i--)
            SiftDown(i);
    }

    private void SiftUp(int index)
    {
        while(index > 0)
        {
            var parentIndex = GetParentIndex(index);
            if(heap[index] > heap[parentIndex])
            {
                Switch(index, parentIndex);
                index = parentIndex;
            }
            else
                break;
        }
    }

    private void SiftDown(int index)
    {
        var n = Count;
        while(index < n)
        {
            var result = index; 
            
            // Get greater child index
            var left = GetLeftIndex(index);
            if(left < n)
                result = left;
            var rightChildIndex = GetRightIndex(index);
            if (rightChildIndex < n && heap[rightChildIndex] > heap[result])
                result = rightChildIndex;
            
            // Switch if current is lower than greater child
            if(heap[result] > heap[index])
            {
                Switch(result, index);
                index = result;
            }
            else
                break;
        }
    }

    private int GetParentIndex(int childIndex) => (childIndex - 1) / 2;
    private int GetLeftIndex(int parentIndex) => parentIndex * 2 + 1;
    private int GetRightIndex(int parentIndex) => parentIndex * 2 + 2;

    private void Switch(int index1, int index2)
    {
        var temp = heap[index1];
        heap[index1] = heap[index2];
        heap[index2] = temp;
    }
}