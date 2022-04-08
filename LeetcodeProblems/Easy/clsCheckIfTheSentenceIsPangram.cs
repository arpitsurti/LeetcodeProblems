using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*1832. Check if the Sentence Is Pangram
     * A pangram is a sentence where every letter of the English alphabet appears at least once.
        Given a string sentence containing only lowercase English letters, return true if sentence is a pangram, or false otherwise.

        Example 1:
        Input: sentence = "thequickbrownfoxjumpsoverthelazydog"
        Output: true
        Explanation: sentence contains at least one of every letter of the English alphabet.

        Example 2:
        Input: sentence = "leetcode"
        Output: false
 
        Constraints:
        1 <= sentence.length <= 1000
        sentence consists of lowercase English letters.
    */
    public class clsCheckIfTheSentenceIsPangram
    {
        public bool CheckIfPangram(string sentence)
        {
            HashSet<char> hs = new HashSet<char>();
            for (int i = 0; i < sentence.Length; i++)
            {
                hs.Add(sentence[i]);
            }
            if (hs.Count == 26)
                return true;
            return false;
        }
    }
}
