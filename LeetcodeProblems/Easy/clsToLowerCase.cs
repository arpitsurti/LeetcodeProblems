using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*709. To Lower Case
     * Given a string s, return the string after replacing every uppercase letter with the same lowercase letter.
        Example 1:
        Input: s = "Hello"
        Output: "hello"

        Example 2:
        Input: s = "here"
        Output: "here"

        Example 3:
        Input: s = "LOVELY"
        Output: "lovely"

        Constraints:
        1 <= s.length <= 100
        s consists of printable ASCII characters.
    */
    public class clsToLowerCase
    {
        public string ToLowerCase(string s)
        {
            char[] chArr = s.ToCharArray();
            for (int i = 0; i < chArr.Count(); i++)
            {
                if (chArr[i] >= 'A' && chArr[i] <= 'Z')
                    chArr[i] = (char)(chArr[i] + 32);
            }
            return string.Join("", chArr);
        }
    }
}
