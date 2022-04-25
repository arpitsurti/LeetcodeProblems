using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*500. Keyboard Row
     * Given an array of strings words, return the words that can be typed using letters of the alphabet on only one row of American keyboard like the image below.

        In the American keyboard:
        the first row consists of the characters "qwertyuiop",
        the second row consists of the characters "asdfghjkl", and
        the third row consists of the characters "zxcvbnm".

        Example 1:
        Input: words = ["Hello","Alaska","Dad","Peace"]
        Output: ["Alaska","Dad"]

        Example 2:
        Input: words = ["omk"]
        Output: []

        Example 3:
        Input: words = ["adsdf","sfd"]
        Output: ["adsdf","sfd"]
 
        Constraints:
        1 <= words.length <= 20
        1 <= words[i].length <= 100
        words[i] consists of English letters (both lowercase and uppercase). 
    */
    public class clsKeyboardRow
    {
        public string[] FindWords(string[] words)
        {
            string[] str = new string[] { "qwertyuiop", "asdfghjkl", "zxcvbnm" };
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for (int i = 0; i < str.Length; i++)
            {
                foreach (var item in str[i].ToCharArray())
                {
                    dict.Add(item, i);
                }
            }
            List<string> lstOutput = new List<string>();
            foreach (var item in words)
            {
                int currentRow = -1;
                bool flgcontains = true;
                foreach (var item1 in item.ToCharArray())
                {
                    char lowerChar = item1;
                    if (lowerChar >= 'A' && lowerChar <= 'Z')
                        lowerChar = (char)((int)lowerChar + 32);
                    if (currentRow == -1)
                        currentRow = dict[lowerChar];
                    if (currentRow != dict[lowerChar])
                    {
                        flgcontains = false;
                        break;
                    }
                }
                if (flgcontains)
                    lstOutput.Add(item);
            }
            return lstOutput.ToArray();
        }
    }
}
