using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*520. Detect Capital
     * We define the usage of capitals in a word to be right when one of the following cases holds:

        All letters in this word are capitals, like "USA".
        All letters in this word are not capitals, like "leetcode".
        Only the first letter in this word is capital, like "Google".
        Given a string word, return true if the usage of capitals in it is right.

        Example 1:
        Input: word = "USA"
        Output: true

        Example 2:
        Input: word = "FlaG"
        Output: false
 
        Constraints:
        1 <= word.length <= 100
        word consists of lowercase and uppercase English letters.
    */
    public class clsDetectCapital
    {
        public bool DetectCapitalUse(string word)
        {
            int left = 0;
            int right = word.Length;
            while (left < right && word[left] - 'A' < 26)
            {
                left++;
            }
            if (left == 0 || left == 1)
            {
                while (left < right && word[left] - 'a' >= 0 && word[left] - 'a' < 26)
                {
                    left++;
                }
            }
            return left == right;
        }
    }
}
