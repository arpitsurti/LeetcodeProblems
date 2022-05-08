using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*744. Find Smallest Letter Greater Than Target
     *** REF ***
     * Given a characters array letters that is sorted in non-decreasing order and a character target, return the smallest character in the array that is larger than target.

        Note that the letters wrap around.

        For example, if target == 'z' and letters == ['a', 'b'], the answer is 'a'.

        Example 1:
        Input: letters = ["c","f","j"], target = "a"
        Output: "c"
    
        Example 2:
        Input: letters = ["c","f","j"], target = "c"
        Output: "f"
    
        Example 3:
        Input: letters = ["c","f","j"], target = "d"
        Output: "f"

        Constraints:
        2 <= letters.length <= 104
        letters[i] is a lowercase English letter.
        letters is sorted in non-decreasing order.
        letters contains at least two different characters.
        target is a lowercase English letter.
    */
    public class clsFindSmallestLetterGreaterThanTarget
    {
        public char NextGreatestLetter(char[] letters, char target)
        {
            int left = 0;
            int right = letters.Length;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (letters[mid] <= target)
                    left = mid + 1;
                else
                    right = mid;
            }
            return letters[left % letters.Length];
        }
    }
}
