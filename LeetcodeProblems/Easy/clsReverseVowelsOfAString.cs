using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*345. Reverse Vowels of a String
     * Given a string s, reverse only all the vowels in the string and return it.
        The vowels are 'a', 'e', 'i', 'o', and 'u', and they can appear in both cases.

        Example 1:
        Input: s = "hello"
        Output: "holle"
        
        Example 2:
        Input: s = "leetcode"
        Output: "leotcede"
 
        Constraints:
        1 <= s.length <= 3 * 105
        s consist of printable ASCII characters.
    */
    class clsReverseVowelsOfAString
    {
        public string ReverseVowels(string s)
        {
            int left = 0;
            int right = s.Length - 1;
            char[] arr = s.ToCharArray();
            while (left < right)
            {
                if (isVowels(arr[left]) && isVowels(arr[right]))
                {
                    char temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                    left++;
                    right--;
                }
                if (!isVowels(s[left]))
                    left++;
                if (!isVowels(s[right]))
                    right--;
            }
            return new string(arr);
            /* APPROACH 2
            HashSet<char> hs = new HashSet<char>();
            hs.Add('a');
            hs.Add('A');
            hs.Add('e');
            hs.Add('E');
            hs.Add('i');
            hs.Add('I');
            hs.Add('o');
            hs.Add('O');
            hs.Add('u');
            hs.Add('U');
            int left = 0;
            int right = s.Length - 1;
            char[] aCh = s.ToCharArray();
            while (left <= right)
            {
                if (hs.Contains(aCh[left]) && hs.Contains(aCh[right]))
                {
                    char temp = aCh[left];
                    aCh[left] = aCh[right];
                    aCh[right] = temp;
                    left++;
                    right--;
                }
                else if (!hs.Contains(aCh[left]))
                    left++;
                else if (!hs.Contains(aCh[right]))
                    right--;
            }
            return new string(aCh);
            */
        }

        private bool isVowels(char ch)
        {
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u'
              || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
                return true;
            return false;
        }
    }
}
