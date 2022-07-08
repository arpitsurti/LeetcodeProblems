using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*409. Longest Palindrome
     *** REF ***
     * Given a string s which consists of lowercase or uppercase letters, return the length of the longest palindrome that can be built with those letters.

        Letters are case sensitive, for example, "Aa" is not considered a palindrome here.

        Example 1:
        Input: s = "abccccdd"
        Output: 7
        Explanation: One longest palindrome that can be built is "dccaccd", whose length is 7.
        
        Example 2:
        Input: s = "a"
        Output: 1
        Explanation: The longest palindrome that can be built is "a", whose length is 1.

        Constraints:
        1 <= s.length <= 2000
        s consists of lowercase and/or uppercase English letters only.
    */
    public class clsLongestPalindrome
    {
        public int LongestPalindrome(string s)
        {
            //APPROACH 1 using HashSet
            HashSet<char> hs = new HashSet<char>();
            int length = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (hs.Contains(s[i]))
                {
                    length += 2;
                    hs.Remove(s[i]);
                }
                else
                    hs.Add(s[i]);
            }
            return hs.Count > 0 ? length + 1 : length;
            /*
            //APPROACH 2 using dictionary
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for(int i = 0; i < s.Length; i++)
            {
                if(!dict.ContainsKey(s[i]))
                    dict.Add(s[i], 0);
                dict[s[i]]++;
            }
            int oddCount = 0;
            int evenCount = 0;
            bool hasOdd = false;
            foreach(var item in dict.Values)
            {
                if(item % 2 == 0)
                    evenCount += item;
                else
                {
                    oddCount += (item - 1);
                    hasOdd = true;
                }
            }
            return evenCount + oddCount + (hasOdd ? 1 : 0);
            */
}
    }
}
