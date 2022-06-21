using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Medium
{
    /*54. Spiral Matrix
     *** REF ***
     *https://www.youtube.com/watch?v=BdQ2AkaTgOA
     * Given an m x n matrix, return all elements of the matrix in spiral order.

        Example 1:
        Input: matrix = [[1,2,3],[4,5,6],[7,8,9]]
        Output: [1,2,3,6,9,8,7,4,5]
        
        Example 2:
        Input: matrix = [[1,2,3,4],[5,6,7,8],[9,10,11,12]]
        Output: [1,2,3,4,8,12,11,10,9,5,6,7]

        Constraints:
        m == matrix.length
        n == matrix[i].length
        1 <= m, n <= 10
        -100 <= matrix[i][j] <= 100
    */
    class clsSpiralMatrix
    {
        public IList<int> SpiralOrder(int[][] matrix)
        {
            int left = 0;
            int right = matrix[0].Length - 1;
            int top = 0;
            int bottom = matrix.Length - 1;
            int size = matrix[0].Length * matrix.Length;
            IList<int> lstResult = new List<int>();
            while (lstResult.Count < size)
            {
                for (int i = left; i <= right && lstResult.Count < size; i++)
                {
                    lstResult.Add(matrix[top][i]);
                }
                top++;
                for (int i = top; i <= bottom && lstResult.Count < size; i++)
                {
                    lstResult.Add(matrix[i][right]);
                }
                right--;
                for (int i = right; i >= left && lstResult.Count < size; i--)
                {
                    lstResult.Add(matrix[bottom][i]);
                }
                bottom--;
                for (int i = bottom; i >= top && lstResult.Count < size; i--)
                {
                    lstResult.Add(matrix[i][left]);
                }
                left++;
            }
            return lstResult;
        }
    }
}
