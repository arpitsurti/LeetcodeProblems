﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*389. Find the Difference
     * You are given two strings s and t.

        String t is generated by random shuffling string s and then add one more letter at a random position.
        Return the letter that was added to t.

        Example 1:
        Input: s = "abcd", t = "abcde"
        Output: "e"
        Explanation: 'e' is the letter that was added.

        Example 2:
        Input: s = "", t = "y"
        Output: "y"
 
        Constraints:
        0 <= s.length <= 1000
        t.length == s.length + 1
        s and t consist of lowercase English letters.
    */
    public class clsFindTheDifference
    {
        public char FindTheDifference(string s, string t)
        {
            int asciiS = 0;
            int asciiT = 0;
            for (int i = 0; i < s.Length; i++)
                asciiS += (int)s[i];
            for (int i = 0; i < t.Length; i++)
                asciiT += (int)t[i];
            return (char)(asciiT - asciiS);
        }
    }
}