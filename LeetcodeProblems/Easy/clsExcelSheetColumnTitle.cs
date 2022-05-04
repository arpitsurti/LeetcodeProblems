using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*168. Excel Sheet Column Title
     * Given an integer columnNumber, return its corresponding column title as it appears in an Excel sheet.

        For example:
        A -> 1
        B -> 2
        C -> 3
        ...
        Z -> 26
        AA -> 27
        AB -> 28 
        ...
 
        Example 1:
        Input: columnNumber = 1
        Output: "A"

        Example 2:
        Input: columnNumber = 28
        Output: "AB"

        Example 3:
        Input: columnNumber = 701
        Output: "ZY"
 
        Constraints:
        1 <= columnNumber <= 231 - 1
    */
    public class clsExcelSheetColumnTitle
    {
        public string ConvertToTitle(int columnNumber)
        {
            StringBuilder sb = new StringBuilder();
            while (columnNumber > 0)
            {
                sb.Insert(0, (char)(65 + (columnNumber - 1) % 26));
                columnNumber = (columnNumber - 1) / 26;
            }
            return sb.ToString();
        }
    }
}
