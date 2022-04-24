using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*20. Valid Parentheses
     * Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
        An input string is valid if:
        Open brackets must be closed by the same type of brackets.
        Open brackets must be closed in the correct order.
 
        Example 1:
        Input: s = "()"
        Output: true

        Example 2:
        Input: s = "()[]{}"
        Output: true

        Example 3:
        Input: s = "(]"
        Output: false
 
        Constraints:
        1 <= s.length <= 104
        s consists of parentheses only '()[]{}'.
    */
    public class clsValidParentheses
    {
        public bool IsValid(string s)
        {
            Stack<char> st = new Stack<char>();
            st.Push(s[0]);
            int index = 1;
            while (index < s.Length)
            {
                if (st.Count() == 0)
                {
                    st.Push(s[index++]);//missed index ++;
                    continue;
                }
                if (s[index] == ')' && st.Peek() == '(')
                    st.Pop();
                else if (s[index] == ']' && st.Peek() == '[')
                    st.Pop();
                else if (s[index] == '}' && st.Peek() == '{')
                    st.Pop();
                else
                    st.Push(s[index]);
                index++;
            }
            return st.Count() == 0;
        }
    }
}
