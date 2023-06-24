public class Solution {
    public int NumIslands(char[][] grid) 
    {
        int count = 0;
        for (int i = 0; i < grid.Length; i ++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                if (grid[i][j] == '1')
                {
                    count++;
                    BFSDelete(grid, (i, j));
                }
            }
        }
        return count;
    }

    public void BFSDelete(char[][] grid, (int r, int c) position)
    {
        if (position.r < 0 || position.c < 0 || position.r == grid.Length || position.c == grid[0].Length)
        {
            return;
        }
        else if (grid[position.r][position.c] == '0')
        {
            return;
        }
        grid[position.r][position.c] = '0';
        BFSDelete(grid, (position.r + 1, position.c));
        BFSDelete(grid, (position.r, position.c + 1));
        BFSDelete(grid, (position.r - 1, position.c));
        BFSDelete(grid, (position.r, position.c - 1));
    }
}
