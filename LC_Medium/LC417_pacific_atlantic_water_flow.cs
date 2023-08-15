public class Solution {
    public IList<IList<int>> PacificAtlantic(int[][] heights) {
        var output = new List<IList<int>>();
        var dirs = new int[,] {{0, 1}, {1, 0}, {-1, 0}, {0, -1}};
        var isPacific = new bool[heights.Length, heights[0].Length];
        var isAtlantic = new bool[heights.Length, heights[0].Length];

        for (int r = 0; r < heights.Length; r++)
        {
            DFS(r, 0, isPacific);
            DFS(r, heights[0].Length - 1, isAtlantic);
        }

        for (int c = 0; c < heights[0].Length; c++)
        {
            DFS(0, c, isPacific);
            DFS(heights.Length - 1, c, isAtlantic);
        }

        for (int r = 0; r < heights.Length; r++)
        {
            for (int c = 0; c < heights[0].Length; c++)
            {
                if (isPacific[r, c] && isAtlantic[r, c])
                {
                    output.Add(new List<int>(){r, c});
                }
            }
        }

        return output;

        void DFS(int row, int col, bool[,] visited)
        {
            visited[row, col] = true;
            for (int i = 0; i < 4; i++)
            {
                var r = row + dirs[i, 0];
                var c = col + dirs[i, 1];

                if (r >= 0 && c >= 0 && r < heights.Length && c < heights[0].Length &&
                    visited[r, c] == false && heights[r][c] >= heights[row][col])
                {
                    DFS(r, c, visited);
                }
            }
        }
    }
}