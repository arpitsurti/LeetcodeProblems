using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*1592. Rearrange Spaces Between Words
     * You are given a string text of words that are placed among some number of spaces. Each word consists of one or more lowercase English letters and are separated by at least one space. It's guaranteed that text contains at least one word.

        Rearrange the spaces so that there is an equal number of spaces between every pair of adjacent words and that number is maximized. If you cannot redistribute all the spaces equally, place the extra spaces at the end, meaning the returned string should be the same length as text.

        Return the string after rearranging the spaces.

        Example 1:
        Input: text = "  this   is  a sentence "
        Output: "this   is   a   sentence"
        Explanation: There are a total of 9 spaces and 4 words. We can evenly divide the 9 spaces between the words: 9 / (4-1) = 3 spaces.
        
        Example 2:
        Input: text = " practice   makes   perfect"
        Output: "practice   makes   perfect "
        Explanation: There are a total of 7 spaces and 3 words. 7 / (3-1) = 3 spaces plus 1 extra space. We place this extra space at the end of the string.
 
        Constraints:
        1 <= text.length <= 100
        text consists of lowercase English letters and ' '.
        text contains at least one word.
    */
    class clsRearrangeSpacesBetweenWords
    {
        public string ReorderSpaces(string text)
        {
            if (text == null || text.Length <= 1)
                return text;
            int spaceCount = 0;
            int wordCount = 0;
            List<string> lstStr = new List<string>();
            int wordStart = -1;
            int length = text.Length;
            for (int i = 0; i < length; i++)
            {
                var current = text[i];
                var isSpace = current == ' ';
                if (isSpace)
                {
                    spaceCount++;
                    continue;
                }
                if (i == 0 || text[i - 1] == ' ')
                {
                    wordCount++;
                    wordStart = i;
                }
                if (i == (length - 1) || text[i + 1] == ' ')
                    lstStr.Add(text.Substring(wordStart, i - wordStart + 1));
            }

            StringBuilder sb = new StringBuilder();
            int allowSpaceCount = wordCount <= 1 ? spaceCount : spaceCount / (wordCount - 1);
            int temp = 0;
            for (int i = 0; i < lstStr.Count; i++)
            {
                sb.Append(lstStr[i]);
                temp = allowSpaceCount;
                while (temp-- != 0 && i != lstStr.Count - 1)
                {
                    sb.Append(" ");
                }
            }
            temp = wordCount <= 1 ? spaceCount : spaceCount % (wordCount - 1);
            while (temp-- != 0)
            {
                sb.Append(" ");
            }
            return sb.ToString();
        }
    }
}
