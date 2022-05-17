using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Medium
{
    /*22. Generate Parentheses
     *** REF ***
     *https://www.youtube.com/watch?v=qBbZ3tS0McI
     * Given n pairs of parentheses, write a function to generate all combinations of well-formed parentheses.
     
        Example 1:
        Input: n = 3
        Output: ["((()))","(()())","(())()","()(())","()()()"]

        Example 2:
        Input: n = 1
        Output: ["()"]

        Constraints:
        1 <= n <= 8
    */
    public class clsGenerateParentheses
    {
        public IList<string> GenerateParenthesis(int n)
        {
            IList<string> lstResult = new List<string>();
            backTrack(lstResult, "", n, 0, 0);
            return lstResult;
        }

        private void backTrack(IList<string> lstResult, string currString, int n, int open, int close)
        {
            if (currString.Length == n * 2)
            {
                lstResult.Add(currString);
                return;
            }
            if (open < n)
                backTrack(lstResult, currString + "(", n, open + 1, close);
            if (close < open)
                backTrack(lstResult, currString + ")", n, open, close + 1);
        }
    }
}
