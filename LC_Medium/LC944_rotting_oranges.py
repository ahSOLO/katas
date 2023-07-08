class Solution:
    def orangesRotting(self, grid: List[List[int]]) -> int:
        rows = len(grid)
        cols = len(grid[0])
        
        fresh_cnt = 0
        
        rotten = collections.deque()

        for r in range(rows):
            for c in range(cols):
                if grid[r][c] == 2:
                    rotten.append((r, c))
                elif grid[r][c] == 1:
                    fresh_cnt += 1

        minutes_passed = 0
        directions = [[0, 1], [1, 0], [0, -1], [-1, 0]]

        while (len(rotten) > 0 and fresh_cnt > 0):
            minutes_passed += 1
            for i in range(len(rotten)):
                (r, c) = rotten.popleft()
                for d in directions:
                    if (min(r + d[0],c + d[1]) < 0 or r + d[0] >= rows or c + d[1] >= cols):
                        continue
                    elif grid[r + d[0]][c + d[1]] == 1:
                        grid[r + d[0]][c + d[1]] = 2
                        rotten.append((r + d[0], c + d[1]))
                        fresh_cnt -= 1

        if fresh_cnt > 0:
            return -1
        else:
            return minutes_passed