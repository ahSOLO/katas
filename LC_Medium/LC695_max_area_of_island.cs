public class Solution {
    public int MaxAreaOfIsland(int[][] grid) 
    {
        int maxArea = 0;
        for (int i = 0; i < grid.Length; i ++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                if (grid[i][j] == 1)
                {
                    int count = 0;
                    DFSCountAndDelete(grid, (i, j), ref count);
                    if (count > maxArea)
                    {
                        maxArea = count;
                    }
                }
            }
        }
        return maxArea;
    }

    public void DFSCountAndDelete(int[][] grid, (int r, int c) position, ref int count)
    {
        if (position.r < 0 || position.c < 0 || position.r == grid.Length || position.c == grid[0].Length)
        {
            return;
        }
        else if (grid[position.r][position.c] == 0)
        {
            return;
        }
        count++;
        grid[position.r][position.c] = 0;
        DFSCountAndDelete(grid, (position.r + 1, position.c), ref count);
        DFSCountAndDelete(grid, (position.r, position.c + 1), ref count);
        DFSCountAndDelete(grid, (position.r - 1, position.c), ref count);
        DFSCountAndDelete(grid, (position.r, position.c - 1), ref count);
    }
}
