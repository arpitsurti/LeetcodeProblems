using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Medium
{
    /*74. Search a 2D Matrix
     *** REF *** FOR UNDERSTANDING HOW MID IS CALCULATED FOR MATRIX
     * Write an efficient algorithm that searches for a value target in an m x n integer matrix matrix. This matrix has the following properties:

        Integers in each row are sorted from left to right.
        The first integer of each row is greater than the last integer of the previous row.

        Example 1:
        Input: matrix = [[1,3,5,7],[10,11,16,20],[23,30,34,60]], target = 3
        Output: true

        Example 2:
        Input: matrix = [[1,3,5,7],[10,11,16,20],[23,30,34,60]], target = 13
        Output: false
 
        Constraints:
        m == matrix.length
        n == matrix[i].length
        1 <= m, n <= 100
        -104 <= matrix[i][j], target <= 104
    */
    public class clsSearchA2DMatrix
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            int m = matrix.Length;
            int n = matrix[0].Length;
            int start = 0;
            int end = m * n - 1;
            while (start <= end)
            {
                int mid = (start + end) / 2;
                int midVal = matrix[mid / n][mid % n];
                if (midVal == target)
                    return true;
                else if (midVal < target)
                    start = mid + 1;
                else
                    end = mid - 1;
            }
            return false;
        }
    }
}
