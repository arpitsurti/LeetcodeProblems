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
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                    st.Push(')');
                else if (s[i] == '{')
                    st.Push('}');
                else if (s[i] == '[')
                    st.Push(']');
                else if (st.Count == 0 || st.Pop() != s[i])
                    return false;
            }
            return st.Count == 0;
            /*APPROACH 3
            Stack<char> st = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ')' && st.Count > 0 && st.Peek() == '(')
                    st.Pop();
                else if (s[i] == '}' && st.Count > 0 && st.Peek() == '{')
                    st.Pop();
                else if (s[i] == ']' && st.Count > 0 && st.Peek() == '[')
                    st.Pop();
                else
                    st.Push(s[i]);
            }
            return st.Count == 0;

            APPROACH 2
             * Stack<char> st = new Stack<char>();
                for(int i = 0; i < s.Length; i++)
                {
                    if(s[i] == '(' || s[i] == '{' || s[i] == '[')
                        st.Push(s[i]);
                    else
                    {
                        if(st.Count == 0)
                            return false;
                        if(s[i] == ')' && st.Peek() == '(')
                            st.Pop();
                        else if(s[i] == '}' && st.Peek() == '{')
                            st.Pop();
                        else if(s[i] == ']' && st.Peek() == '[')
                            st.Pop();
                        else
                            return false;
                    }
                }
                return st.Count == 0;
             */
        }
    }
}
