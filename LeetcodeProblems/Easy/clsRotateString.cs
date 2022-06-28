using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*796. Rotate String
     *** REF ***
     *https://www.youtube.com/watch?v=kP2cpOPNYRc
     * Given two strings s and goal, return true if and only if s can become goal after some number of shifts on s.

        A shift on s consists of moving the leftmost character of s to the rightmost position.

        For example, if s = "abcde", then it will be "bcdea" after one shift.
 
        Example 1:
        Input: s = "abcde", goal = "cdeab"
        Output: true
    
        Example 2:
        Input: s = "abcde", goal = "abced"
        Output: false

        Constraints:
        1 <= s.length, goal.length <= 100
        s and goal consist of lowercase English letters.
    */
    public class clsRotateString
    {
        public bool RotateString(string s, string goal)
        {
            return s.Length == goal.Length && (s + s).Contains(goal);
        }
    }
}
