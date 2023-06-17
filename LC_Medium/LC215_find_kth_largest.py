class Solution:
    def findKthLargest(self, nums: List[int], k: int) -> int:
        maxHeap = []
        for num in nums:
            maxHeap.append(-num)
        heapq.heapify(maxHeap)
        
        output = 1
        while k > 0:
            output = heapq.heappop(maxHeap)
            k -= 1
        
        return -output