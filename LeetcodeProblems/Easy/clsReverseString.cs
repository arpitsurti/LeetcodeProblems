using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*344. Reverse String
     * Write a function that reverses a string. The input string is given as an array of characters s.
        You must do this by modifying the input array in-place with O(1) extra memory.

        Example 1:
        Input: s = ["h","e","l","l","o"]
        Output: ["o","l","l","e","h"]

        Example 2:
        Input: s = ["H","a","n","n","a","h"]
        Output: ["h","a","n","n","a","H"]
 
        Constraints:
        1 <= s.length <= 105
        s[i] is a printable ascii character.
    */
    public class clsReverseString
    {
        public void ReverseString(char[] s)
        {
            int endIndex = s.Length - 1;
            for (int i = 0; i < s.Length / 2; i++)
            {
                char temp = s[i];
                s[i] = s[endIndex - i];
                s[endIndex - i] = temp;
            }
        }
    }
}
