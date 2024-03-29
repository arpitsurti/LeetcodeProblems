﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*28. Implement strStr()
     *** REF ***
     * Implement strStr().
        Given two strings needle and haystack, return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.

        Clarification:
        What should we return when needle is an empty string? This is a great question to ask during an interview.
        For the purpose of this problem, we will return 0 when needle is an empty string. This is consistent to C's strstr() and Java's indexOf().

        Example 1:
        Input: haystack = "hello", needle = "ll"
        Output: 2

        Example 2:
        Input: haystack = "aaaaa", needle = "bba"
        Output: -1
 
        Constraints:
        1 <= haystack.length, needle.length <= 104
        haystack and needle consist of only lowercase English characters.
    */
    public class clsImplementstrStr
    {
        //APPROACH 1
        public int StrStr(string haystack, string needle)
        {
            int hLen = haystack.Length;
            int nLen = needle.Length;
            if (needle.Length == 0 || (hLen == nLen && haystack == needle))
                return 0;

            for (int haystackIndex = 0; haystackIndex < hLen; haystackIndex++)
            {
                if (needle[0] == haystack[haystackIndex])
                {
                    int tempIndex = haystackIndex;
                    int needleIndex = 0;
                    while (tempIndex < hLen && needleIndex < nLen && needle[needleIndex] == haystack[tempIndex])
                    {
                        needleIndex++;
                        tempIndex++;
                    }
                    if (needleIndex == nLen)
                        return haystackIndex;
                }
            }
            return -1;
        }
        /* APPROACH 2
        public int StrStr(string haystack, string needle)
        {
            if (haystack.Length < needle.Length)
                return -1;
            if (haystack == needle)
                return 0;
            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                if (haystack.Substring(i, needle.Length) == needle)
                    return i;
            }
            return -1;
        }
        */
    }
}
