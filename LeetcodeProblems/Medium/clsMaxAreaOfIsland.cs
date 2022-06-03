using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Medium
{
    /*695. Max Area of Island
     *** REF ***
     *https://leetcode.com/problems/max-area-of-island/solution/
     * You are given an m x n binary matrix grid. An island is a group of 1's (representing land) connected 4-directionally (horizontal or vertical.) You may assume all four edges of the grid are surrounded by water.

        The area of an island is the number of cells with a value 1 in the island.

        Return the maximum area of an island in grid. If there is no island, return 0.

        Example 1:
        Input: grid = [[0,0,1,0,0,0,0,1,0,0,0,0,0],[0,0,0,0,0,0,0,1,1,1,0,0,0],[0,1,1,0,1,0,0,0,0,0,0,0,0],[0,1,0,0,1,1,0,0,1,0,1,0,0],[0,1,0,0,1,1,0,0,1,1,1,0,0],[0,0,0,0,0,0,0,0,0,0,1,0,0],[0,0,0,0,0,0,0,1,1,1,0,0,0],[0,0,0,0,0,0,0,1,1,0,0,0,0]]
        Output: 6
        Explanation: The answer is not 11, because the island must be connected 4-directionally.

        Example 2:
        Input: grid = [[0,0,0,0,0,0,0,0]]
        Output: 0
 
        Constraints:
        m == grid.length
        n == grid[i].length
        1 <= m, n <= 50
        grid[i][j] is either 0 or 1.
    */
    public class clsMaxAreaOfIsland
    {
        public int MaxAreaOfIsland(int[][] grid)
        {
            bool[][] seen = new bool[grid.Length][];
            for (int i = 0; i < grid.Length; i++)
            {
                seen[i] = new bool[grid[i].Length];
            }
            int maxArea = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    maxArea = Math.Max(maxArea, dfs(grid, seen, i, j));
                }
            }

            return maxArea;
        }

        private int dfs(int[][] grid, bool[][] seen, int i, int j)
        {
            if (i < 0 || j < 0 || i >= grid.Length || j >= grid[0].Length || seen[i][j]
              || grid[i][j] == 0)
                return 0;
            seen[i][j] = true;
            return 1 + dfs(grid, seen, i + 1, j) +
            dfs(grid, seen, i - 1, j) +
            dfs(grid, seen, i, j + 1) +
            dfs(grid, seen, i, j - 1);
        }
    }
}
