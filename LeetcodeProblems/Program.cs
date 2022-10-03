using LeetcodeProblems.Easy;
using LeetcodeProblems.Medium;
using System;
using System.Collections.Generic;

namespace LeetcodeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            DetectCapitalUse("Google");
        }

        public static bool DetectCapitalUse(string word)
        {
            if (word.Length == 1)
                return true;
            bool caseOne = false;
            bool caseTwo = false;
            bool caseThree = false;
            if ((word[0] >= 'A' && word[0] <= 'Z') || (word[1] >= 'A' && word[1] <= 'Z'))
                caseOne = true;
            else if ((word[0] >= 'A' && word[0] <= 'Z') || (word[1] >= 'a' && word[1] <= 'z'))
                caseThree = true;
            else
                caseTwo = true;
            for (int i = 1; i < word.Length; i++)
            {
                if (caseOne && !(word[i] >= 'A' && word[i] <= 'Z'))
                    return false;
                else if ((caseTwo || caseThree) && !(word[i] >= 'a' && word[i] <= 'z'))
                    return false;
            }
            return true;
        }
    }
}
