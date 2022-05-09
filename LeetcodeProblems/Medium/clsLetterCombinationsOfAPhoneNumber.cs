using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Medium
{
    /*17. Letter Combinations of a Phone Number
     *** REF ***
     *https://www.youtube.com/watch?v=21OuwqIC56E&t=639s
     * Given a string containing digits from 2-9 inclusive, return all possible letter combinations that the number could represent. Return the answer in any order.

        A mapping of digit to letters (just like on the telephone buttons) is given below. Note that 1 does not map to any letters.

        Example 1:
        Input: digits = "23"
        Output: ["ad","ae","af","bd","be","bf","cd","ce","cf"]

        Example 2:
        Input: digits = ""
        Output: []

        Example 3:
        Input: digits = "2"
        Output: ["a","b","c"]
 
        Constraints:
        0 <= digits.length <= 4
        digits[i] is a digit in the range ['2', '9'].
    */
    public class clsLetterCombinationsOfAPhoneNumber
    {
        public IList<string> LetterCombinations(string digits)
        {
            IList<string> lstResult = new List<string>();
            if (digits == null || digits.Length == 0)
                return lstResult;
            string[] map = new string[]{ "0", "1", "abc", "def", "ghi", "jkl", "mno",
                                   "pqrs", "tuv", "wxyz"};

            getCombinations(digits, map, 0, lstResult, "");
            return lstResult;
        }

        private void getCombinations(string digits, string[] map, int index, IList<string> lstResult, string currString)
        {
            if (index == digits.Length)
            {
                lstResult.Add(currString);
                return;
            }
            string letters = map[digits[index] - '0'];
            for (int i = 0; i < letters.Length; i++)
            {
                getCombinations(digits, map, index + 1, lstResult, currString + letters[i]);
            }
        }
    }
}
