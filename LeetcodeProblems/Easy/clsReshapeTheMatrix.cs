using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*566. Reshape the Matrix
     * In MATLAB, there is a handy function called reshape which can reshape an m x n matrix into a new one with a different size r x c keeping its original data.

        You are given an m x n matrix mat and two integers r and c representing the number of rows and the number of columns of the wanted reshaped matrix.

        The reshaped matrix should be filled with all the elements of the original matrix in the same row-traversing order as they were.

        If the reshape operation with given parameters is possible and legal, output the new reshaped matrix; Otherwise, output the original matrix.

        Example 1:
        Input: mat = [[1,2],[3,4]], r = 1, c = 4
        Output: [[1,2,3,4]]

        Example 2:
        Input: mat = [[1,2],[3,4]], r = 2, c = 4
        Output: [[1,2],[3,4]]
 
        Constraints:
        m == mat.length
        n == mat[i].length
        1 <= m, n <= 100
        -1000 <= mat[i][j] <= 1000
        1 <= r, c <= 300
    */
    public class clsReshapeTheMatrix
    {
        public int[][] MatrixReshape(int[][] mat, int r, int c)
        {
            if (mat.Length == 0 || (mat.Length * mat[0].Length != r * c))
                return mat;
            int[][] output = new int[r][];
            for (int i = 0; i < output.Length; i++)
            {
                output[i] = new int[c];
            }
            int tempR = 0;
            int tempC = 0;
            for (int i = 0; i < mat.Length; i++)
            {
                for (int j = 0; j < mat[i].Length; j++)
                {
                    if (tempC == c)
                    {
                        tempC = 0;
                        tempR++;
                    }
                    output[tempR][tempC++] = mat[i][j];
                }
            }
            return output;
        }
    }
}
