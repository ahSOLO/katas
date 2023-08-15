public class Solution {
    int[,] dir = new int[,] { {0, 1}, {1, 0}, {-1, 0}, {0, -1} };

    public bool Exist(char[][] board, string word) {
        var visited = new bool[board.Length, board[0].Length];
        for (int r = 0; r < board.Length; r++)
        {
            for (int c = 0; c < board[0].Length; c++)
            {
                if (board[r][c] == word[0])
                {
                    if (Search(r, c, 0, visited))
                    {
                        return true;
                    }
                }
            }
        }
        return false;
    
        bool Search(int row, int col, int letter, bool[,] visited)
        {
            letter++;
            if (letter == word.Length)
            {
                return true;
            }

            visited[row,col] = true;
            
            for (int d = 0; d < 4; d++)
            {
                int r = row + dir[d, 0];
                int c = col + dir[d, 1];
                if (r >= 0 && r < board.Length && c >= 0 && c < board[0].Length
                    && !visited[r,c])
                {
                    if (board[r][c] == word[letter])
                    {
                        if (Search(r, c, letter, visited))
                        {
                            return true;
                        }
                        else
                        {
                            visited[r,c] = false;
                        }
                    }
                }
            }
            
            visited[row,col] = false;
            return false;
        }
        
        return false;
    }

}