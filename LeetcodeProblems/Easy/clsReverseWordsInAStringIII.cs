using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*557. Reverse Words in a String III
     * Given a string s, reverse the order of characters in each word within a sentence while still preserving whitespace and initial word order.

        Example 1:
        Input: s = "Let's take LeetCode contest"
        Output: "s'teL ekat edoCteeL tsetnoc"

        Example 2:
        Input: s = "God Ding"
        Output: "doG gniD"
 
        Constraints:
        1 <= s.length <= 5 * 104
        s contains printable ASCII characters.
        s does not contain any leading or trailing spaces.
        There is at least one word in s.
        All the words in s are separated by a single space.
    */
    public class clsReverseWordsInAStringIII
    {
        public string ReverseWords(string s)
        {
            string[] strArr = s.Split(' ');
            for (int i = 0; i < strArr.Length; i++)
            {
                strArr[i] = reverse(strArr[i]);
            }
            return string.Join(" ", strArr);
        }

        private string reverse(string input)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                sb.Insert(0, input[i]);
            }
            return sb.ToString();
        }
    }
}
