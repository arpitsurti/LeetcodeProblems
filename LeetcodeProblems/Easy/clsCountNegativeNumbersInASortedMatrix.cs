using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*1351. Count Negative Numbers in a Sorted Matrix
     * Given a m x n matrix grid which is sorted in non-increasing order both row-wise and column-wise, return the number of negative numbers in grid.

        Example 1:
        Input: grid = [[4,3,2,-1],[3,2,1,-1],[1,1,-1,-2],[-1,-1,-2,-3]]
        Output: 8
        Explanation: There are 8 negatives number in the matrix.

        Example 2:
        Input: grid = [[3,2],[1,0]]
        Output: 0
 
        Constraints:
        m == grid.length
        n == grid[i].length
        1 <= m, n <= 100
        -100 <= grid[i][j] <= 100

        Follow up: Could you find an O(n + m) solution?
    */
    public class clsCountNegativeNumbersInASortedMatrix
    {
        public int CountNegatives(int[][] grid)
        {
            int output = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                output += BinarySearch(grid[i]);
            }
            return output;
        }

        private int BinarySearch(int[] input)
        {
            int left = 0;
            int right = input.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (input[mid] >= 0)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return input.Length - right - 1;
        }
    }
}
