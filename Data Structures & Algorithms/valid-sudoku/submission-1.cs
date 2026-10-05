public class Solution {
 public bool IsValidSudoku(char[][] board)
{
    int[] rows = new int[9];     // each int is a row's 9 switches
    int[] cols = new int[9];
    int[] boxes = new int[9];

    for (int r = 0; r < 9; r++)
    {
        for (int c = 0; c < 9; c++)
        {
            char v = board[r][c];
            if (v == '.') continue;

            int bit = 1 << (v - '1');
            int box = (r / 3) * 3 + (c / 3);

            if ((rows[r] & bit) != 0 || (cols[c] & bit) != 0 || (boxes[box] & bit) != 0)
                return false;

            rows[r] |= bit;
            cols[c] |= bit;
            boxes[box] |= bit;
        }
    }
    return true;
}
}
