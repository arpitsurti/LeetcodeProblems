using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*917. Reverse Only Letters
     * Given a string s, reverse the string according to the following rules:

        All the characters that are not English letters remain in the same position.
        All the English letters (lowercase or uppercase) should be reversed.
        Return s after reversing it.

        Example 1:
        Input: s = "ab-cd"
        Output: "dc-ba"

        Example 2:
        Input: s = "a-bC-dEf-ghIj"
        Output: "j-Ih-gfE-dCba"

        Example 3:
        Input: s = "Test1ng-Leet=code-Q!"
        Output: "Qedo1ct-eeLg=ntse-T!"

        Constraints:
        1 <= s.length <= 100
        s consists of characters with ASCII values in the range [33, 122].
        s does not contain '\"' or '\\'.
    */
    public class clsReverseOnlyLetters
    {
        public string ReverseOnlyLetters(string s)
        {
            int left = 0;
            int right = s.Length - 1;
            char[] chArray = s.ToCharArray();
            while (left < right)
            {
                if (!((chArray[left] >= 'a' && chArray[left] <= 'z') || (chArray[left] >= 'A' && chArray[left] <= 'Z')))
                    left++;
                else if (!((chArray[right] >= 'a' && chArray[right] <= 'z') || (chArray[right] >= 'A' && chArray[right] <= 'Z')))
                    right--;
                else
                {
                    char temp = chArray[left];
                    chArray[left++] = chArray[right];
                    chArray[right--] = temp;
                }
            }
            return string.Join("", chArray);
        }
    }
}
