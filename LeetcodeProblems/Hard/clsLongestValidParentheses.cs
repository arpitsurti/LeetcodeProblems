using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Hard
{
    /*32. Longest Valid Parentheses
     *** REF ***
     *https://www.youtube.com/watch?v=VdQuwtEd10M
     * Given a string containing just the characters '(' and ')', find the length of the longest valid (well-formed) parentheses substring.

        Example 1:
        Input: s = "(()"
        Output: 2
        Explanation: The longest valid parentheses substring is "()".

        Example 2:
        Input: s = ")()())"
        Output: 4
        Explanation: The longest valid parentheses substring is "()()".

        Example 3:
        Input: s = ""
        Output: 0
 
        Constraints:
        0 <= s.length <= 3 * 104
        s[i] is '(', or ')'
    */
    public class clsLongestValidParentheses
    {
        public int LongestValidParentheses(string s)
        {
            Stack<int> st = new Stack<int>();
            st.Push(-1);//Adding dummy value
            int maxLength = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                    st.Push(i);
                else
                {
                    st.Pop();
                    if (st.Count == 0)
                    {
                        st.Push(i);
                    }
                    else
                    {
                        int len = i - st.Peek();
                        maxLength = Math.Max(maxLength, len);
                    }
                }
            }
            return maxLength;
        }
    }
}
