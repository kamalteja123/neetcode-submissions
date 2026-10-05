public class Solution {
   public bool IsValidSudoku(char[][] board)
{
    // Piece 1: 9 sets for rows, 9 for columns, 9 for boxes
    HashSet<char>[] rows = new HashSet<char>[9];
    HashSet<char>[] cols = new HashSet<char>[9];
    HashSet<char>[] boxes = new HashSet<char>[9];

    for (int i = 0; i < 9; i++)
    {
        rows[i] = new HashSet<char>();
        cols[i] = new HashSet<char>();
        boxes[i] = new HashSet<char>();
    }

    // Piece 2: visit every cell
    for (int r = 0; r < 9; r++)
    {
        for (int c = 0; c < 9; c++)
        {
            char v = board[r][c];
            if (v == '.') continue;          // empty cell, nothing to check

            int box = (r / 3) * 3 + (c / 3);

             if (rows[r].Contains(v) || cols[c].Contains(v) || boxes[box].Contains(v))
                return false;

            rows[r].Add(v);
            cols[c].Add(v);
            boxes[box].Add(v);
        }
    }

    return true;   // no duplicate found anywhere
}
}
