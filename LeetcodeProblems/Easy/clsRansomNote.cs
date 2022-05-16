using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*383. Ransom Note
     * Given two strings ransomNote and magazine, return true if ransomNote can be constructed from magazine and false otherwise.

        Each letter in magazine can only be used once in ransomNote.

        Example 1:
        Input: ransomNote = "a", magazine = "b"
        Output: false

        Example 2:
        Input: ransomNote = "aa", magazine = "ab"
        Output: false
    
        Example 3:
        Input: ransomNote = "aa", magazine = "aab"
        Output: true
 
        Constraints:
        1 <= ransomNote.length, magazine.length <= 105
        ransomNote and magazine consist of lowercase English letters.
    */
    public class clsRansomNote
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            int[] charCount = new int[26];
            for (int i = 0; i < magazine.Length; i++)
            {
                char c = magazine[i];
                charCount[c - 'a']++;
            }
            for (int i = 0; i < ransomNote.Length; i++)
            {
                char c = ransomNote[i];
                --charCount[c - 'a'];
                if (charCount[c - 'a'] < 0)
                    return false;
            }
            return true;
        }
    }
}
