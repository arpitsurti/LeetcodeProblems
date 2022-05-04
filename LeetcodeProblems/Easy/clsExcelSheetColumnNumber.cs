using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*171. Excel Sheet Column Number
     * Given a string columnTitle that represents the column title as appear in an Excel sheet, return its corresponding column number.

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
        Input: columnTitle = "A"
        Output: 1

        Example 2:
        Input: columnTitle = "AB"
        Output: 28

        Example 3:
        Input: columnTitle = "ZY"
        Output: 701
 
        Constraints:
        1 <= columnTitle.length <= 7
        columnTitle consists only of uppercase English letters.
        columnTitle is in the range ["A", "FXSHRXW"].
    */
    public class clsExcelSheetColumnNumber
    {
        public int TitleToNumber(string columnTitle)
        {
            int output = 0;
            for (int i = 0; i < columnTitle.Length; i++)
            {
                output = output * 26 + (((int)(columnTitle[i])) - 65 + 1);
            }
            return output;
        }
    }
}
