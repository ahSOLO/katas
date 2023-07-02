class Solution:
    def shortestPathBinaryMatrix(self, grid: List[List[int]]) -> int:
        ROWS, COLS = len(grid), len(grid[0])
        if (grid[0][0] == 1 or grid[ROWS - 1][COLS - 1] == 1):
            return -1
            
        queue = deque([(0,0)])
        visited = set()
        directions = [(0, 1), (1, 1), (1, 0), (1, -1), (0, -1), (-1, -1), (-1, 0), (-1, 1)]
        
        length = 1
        while (len(queue) > 0):
            for i in range(len(queue)):
                r, c = queue.popleft()
                if r == ROWS - 1 and c == COLS - 1:
                    return length
                for direction in directions:
                    next_visit = (r + direction[0], c + direction[1])
                    if (next_visit[0] >= ROWS or next_visit[1] >= COLS or 
                        next_visit[0] < 0 or next_visit[1] < 0 or
                        grid[next_visit[0]][next_visit[1]] == 1 or
                        next_visit in visited):
                        continue
                    queue.append(next_visit)
                    visited.add(next_visit)
            length += 1
        return -1