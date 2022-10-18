using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*500. Keyboard Row
     ### REF ###
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
        /*USING 3 HASHSET
        public string[] FindWords(string[] words) {
        HashSet<char> hs1 = new HashSet<char>();
        string row1 = "qwertyuiop";
        foreach(char ch in row1)
        {
            hs1.Add(ch);
        }
        HashSet<char> hs2 = new HashSet<char>();
        string row2 = "asdfghjkl";
        foreach(char ch in row2)
        {
            hs2.Add(ch);
        }
        HashSet<char> hs3 = new HashSet<char>();
        string row3 = "zxcvbnm";
        foreach(char ch in row3)
        {
            hs3.Add(ch);
        }
        List<string> lstResult = new List<string>();
        foreach(string str in words)
        {
            string word = str.ToLower();
            int rowNum = -1;
            bool sameRow = true;
            foreach(char ch in word)
            {
                if(rowNum == -1)
                {
                    if(hs1.Contains(ch))
                        rowNum = 1;
                    else if(hs2.Contains(ch))
                        rowNum = 2;
                    else
                        rowNum = 3;
                }
                else
                {
                    if((rowNum == 1 && !hs1.Contains(ch)) || (rowNum == 2 && !hs2.Contains(ch)) ||
                    (rowNum == 3 && !hs3.Contains(ch)))
                    {
                        sameRow = false;
                        break;
                    }
                }
            }
            if(sameRow)
                lstResult.Add(str);
        }
        return lstResult.ToArray();
    }
        */
        public string[] FindWords(string[] words)
        {
            string[] inputStr = new string[] { "qwertyuiop", "asdfghjkl", "zxcvbnm" };
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for (int i = 0; i < inputStr.Length; i++)
            {
                foreach (var item in inputStr[i].ToCharArray())
                {
                    dict.Add(item, i);
                }
            }
            List<string> lstResult = new List<string>();
            foreach (string str in words)
            {
                string input = str.ToLower();
                int rowNum = dict[input[0]];
                bool isValid = true;
                foreach (char c in input)
                {
                    if (rowNum != dict[c])
                    {
                        isValid = false;
                        break;
                    }
                }
                if (isValid)
                    lstResult.Add(str);
            }
            return lstResult.ToArray();
            /*
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
            */
        }
    }
}
