using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Medium
{
    /*79. Word Search
     *** REF ***
     *https://www.youtube.com/watch?v=vYYNp0Jrdv0
     * Given an m x n grid of characters board and a string word, return true if word exists in the grid.

        The word can be constructed from letters of sequentially adjacent cells, where adjacent cells are horizontally or vertically neighboring. The same letter cell may not be used more than once.

        Example 1:
        Input: board = [["A","B","C","E"],["S","F","C","S"],["A","D","E","E"]], word = "ABCCED"
        Output: true

        Example 2:
        Input: board = [["A","B","C","E"],["S","F","C","S"],["A","D","E","E"]], word = "SEE"
        Output: true

        Example 3:
        Input: board = [["A","B","C","E"],["S","F","C","S"],["A","D","E","E"]], word = "ABCB"
        Output: false
 
        Constraints:
        m == board.length
        n = board[i].length
        1 <= m, n <= 6
        1 <= word.length <= 15
        board and word consists of only lowercase and uppercase English letters.

        Follow up: Could you use search pruning to make your solution faster with a larger board?
    */
    public class clsWordSearch
    {
        public bool Exist(char[][] board, string word)
        {
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (board[i][j] == word[0] && search(word, board, i, j, 0))
                        return true;
                }
            }
            return false;
        }

        private bool search(string word, char[][] board, int i, int j, int count)
        {
            if (count == word.Length)
                return true;
            if (i < 0 || i >= board.Length || j < 0 || j >= board[i].Length ||
              board[i][j] != word[count])
                return false;
            char temp = board[i][j];
            board[i][j] = ' ';
            if (search(word, board, i + 1, j, count + 1) ||
              search(word, board, i - 1, j, count + 1) ||
              search(word, board, i, j - 1, count + 1) ||
              search(word, board, i, j + 1, count + 1))
                return true;
            board[i][j] = temp;
            return false;
        }
    }
}
