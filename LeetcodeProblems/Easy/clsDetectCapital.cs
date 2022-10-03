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
            //APPROACH 1
            /*
                int upperCount = 0;
                bool isLowerCase = false;
                for(int i = 0; i < word.Length; i++)
                {
                if(i > 0 && isLowerCase)
                {
                    if(char.IsUpper(word[i]))
                        return false;
                }
                if(upperCount > 1 && char.IsLower(word[i]))
                    return false;
                if(char.IsUpper(word[i]))
                    upperCount++;
                else
                    isLowerCase = true;
                }
                return true;
            */
            //APPROACH 2
            /*
                if(word.Length == 1)
                    return true;
                bool caseOne = false;
                bool caseTwo = false;
                bool caseThree = false;
                if((word[0] >= 'A' && word[0] <= 'Z') && (word[1] >= 'A' && word[1] <= 'Z'))
                    caseOne = true;
                else if((word[0] >= 'A' && word[0] <= 'Z') && (word[1] >= 'a' && word[1] <= 'z'))
                    caseThree = true;
                else
                    caseTwo = true;
                for(int i = 1; i < word.Length; i++)
                {
                    if(caseOne && !(word[i] >= 'A' && word[i] <= 'Z'))
                        return false;
                    else if((caseTwo || caseThree) && !(word[i] >= 'a' && word[i] <= 'z'))
                        return false;
                }
                return true;
             */
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
