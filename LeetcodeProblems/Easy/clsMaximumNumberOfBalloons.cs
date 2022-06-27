using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*1189. Maximum Number of Balloons
     * Given a string text, you want to use the characters of text to form as many instances of the word "balloon" as possible.

        You can use each character in text at most once. Return the maximum number of instances that can be formed.

        Example 1:
        Input: text = "nlaebolko"
        Output: 1

        Example 2:
        Input: text = "loonbalxballpoon"
        Output: 2

        Example 3:
        Input: text = "leetcode"
        Output: 0

        Constraints:
        1 <= text.length <= 104
        text consists of lower case English letters only.
    */
    public class clsMaximumNumberOfBalloons
    {
        public int MaxNumberOfBalloons(string text)
        {
            if (text.Length < 7)
                return 0;
            int[] ch = new int[26];
            for (int i = 0; i < text.Length; i++)
            {
                ch[text[i] - 'a']++;
            }
            int output = Math.Min(ch[0], ch[1]);
            output = Math.Min(output, ch['l' - 'a'] / 2);
            output = Math.Min(output, ch['o' - 'a'] / 2);
            output = Math.Min(output, ch['n' - 'a']);
            return output;
        }
    }
}
