public class Solution {
   public bool SearchMatrix(int[][] matrix, int target) {
    int rows = matrix.Length;
    int cols = matrix[0].Length;

    int top = 0, bottom = rows - 1;
    while (top <= bottom) {
        int mid = top + (bottom - top) / 2;      // mid is a ROW number here

        if (target > matrix[mid][cols - 1]) {
           top=mid+1;                       // <- your blank
        } else if (target < matrix[mid][0]) {
            bottom = mid - 1;
        } else {
            int left = 0, right = cols - 1;       // plain binary search in row `mid`
            while (left <= right) {
                int m = left + (right - left) / 2;   // m is a COLUMN number
                if (matrix[mid][m] == target) return true;
                if (matrix[mid][m] < target) left = m + 1;
                else right = m - 1;
            }
            return false;                         // the only possible row had no match
        }
    }
    return false;                                 // no row could hold the target
}
}
