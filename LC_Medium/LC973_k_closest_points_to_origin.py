class Solution:
    def kClosest(self, points: List[List[int]], k: int) -> List[List[int]]:
        def SqrdDistance(point: List[int]):
            return point[0]**2 + point[1]**2
        
        minHeap = []
        
        for point in points:
            minHeap.append([SqrdDistance(point), point[0], point[1]])
        #heap pushing each element is O(nlogn)
        #    heapq.heappush(minHeap, [SqrdDistance(point), point[0], point[1]])

        #heapify is O(n)
        heapq.heapify(minHeap)
        
        output = []
        for i in range(0, k):
            entry = heapq.heappop(minHeap)
            output.append([entry[1], entry[2]])

        return output