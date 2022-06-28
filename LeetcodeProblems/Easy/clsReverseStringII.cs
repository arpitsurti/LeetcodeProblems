using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*541. Reverse String II
     *** REF ***
     * Given a string s and an integer k, reverse the first k characters for every 2k characters counting from the start of the string.

        If there are fewer than k characters left, reverse all of them. If there are less than 2k but greater than or equal to k characters, then reverse the first k characters and leave the other as original.

        Example 1:
        Input: s = "abcdefg", k = 2
        Output: "bacdfeg"

        Example 2:
        Input: s = "abcd", k = 2
        Output: "bacd"
 
        Constraints:
        1 <= s.length <= 104
        s consists of only lowercase English letters.
        1 <= k <= 104
    */
    public class clsReverseStringII
    {
        public string ReverseStr(string s, int k)
        {
            char[] a = s.ToCharArray();
            for (int i = 0; i < s.Length; i += 2 * k)
            {
                int start = i;
                int end = Math.Min(a.Length - 1, i + k - 1);
                while (start < end)
                {
                    char temp = a[start];
                    a[start] = a[end];
                    a[end] = temp;
                    start++;
                    end--;
                }
            }
            return new string(a);
        }
    }
}
