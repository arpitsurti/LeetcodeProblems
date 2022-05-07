using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Medium
{
    /*1209. Remove All Adjacent Duplicates in String II
     *** REF ***
     *** VERY IMP ***
     *https://www.youtube.com/watch?v=w6LcypDgC4w
     * You are given a string s and an integer k, a k duplicate removal consists of choosing k adjacent and equal letters from s and removing them, causing the left and the right side of the deleted substring to concatenate together.

        We repeatedly make k duplicate removals on s until we no longer can.

        Return the final string after all such duplicate removals have been made. It is guaranteed that the answer is unique.

        Example 1:
        Input: s = "abcd", k = 2
        Output: "abcd"
        Explanation: There's nothing to delete.

        Example 2:
        Input: s = "deeedbbcccbdaa", k = 3
        Output: "aa"
        Explanation: 
        First delete "eee" and "ccc", get "ddbbbdaa"
        Then delete "bbb", get "dddaa"
        Finally delete "ddd", get "aa"

        Example 3:
        Input: s = "pbbcggttciiippooaais", k = 2
        Output: "ps"
 

        Constraints:
        1 <= s.length <= 105
        2 <= k <= 104
        s only contains lower case English letters.
    */
    public class clsRemoveAllAdjacentDuplicatesInStringII
    {
        public string RemoveDuplicates(string s, int k)
        {
            Stack<char> stChar = new Stack<char>();
            Stack<int> stCounts = new Stack<int>();
            stChar.Push(s[0]);
            stCounts.Push(1);
            for (int i = 1; i < s.Length; i++)
            {
                char currChar = stChar.Count != 0 ? stChar.Peek() : ' ';
                if (currChar != s[i])
                {
                    stChar.Push(s[i]);
                    stCounts.Push(1);
                }
                else
                {
                    if (stCounts.Peek() != k)
                    {
                        int count = stCounts.Pop();
                        stCounts.Push(count + 1);
                    }
                    if (stCounts.Peek() == k)
                    {
                        stChar.Pop();
                        stCounts.Pop();
                    }
                }
            }
            StringBuilder sb = new StringBuilder();
            while (stChar.Count != 0)
            {
                char currChar = stChar.Pop();
                int currCount = stCounts.Pop();
                while (currCount != 0)
                {
                    sb.Insert(0, currChar);
                    currCount--;
                }

            }
            return sb.ToString();
        }
    }
}
