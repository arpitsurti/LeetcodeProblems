using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Medium
{
    /*6. Zigzag Conversion
     * The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: (you may want to display this pattern in a fixed font for better legibility)

        P   A   H   N
        A P L S I I G
        Y   I   R
        And then read line by line: "PAHNAPLSIIGYIR"

        Write the code that will take a string and make this conversion given a number of rows:

        string convert(string s, int numRows);

        Example 1:
        Input: s = "PAYPALISHIRING", numRows = 3
        Output: "PAHNAPLSIIGYIR"

        Example 2:
        Input: s = "PAYPALISHIRING", numRows = 4
        Output: "PINALSIGYAHRPI"
        Explanation:
        P     I    N
        A   L S  I G
        Y A   H R
        P     I

        Example 3:
        Input: s = "A", numRows = 1
        Output: "A"
 
        Constraints:
        1 <= s.length <= 1000
        s consists of English letters (lower-case and upper-case), ',' and '.'.
        1 <= numRows <= 1000
    */
    public class clsZigzagConversion
    {
        /*6. Zigzag Conversion
         * The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: (you may want to display this pattern in a fixed font for better legibility)

            P   A   H   N
            A P L S I I G
            Y   I   R
            And then read line by line: "PAHNAPLSIIGYIR"

            Write the code that will take a string and make this conversion given a number of rows:

            string convert(string s, int numRows);

            Example 1:
            Input: s = "PAYPALISHIRING", numRows = 3
            Output: "PAHNAPLSIIGYIR"
            
            Example 2:
            Input: s = "PAYPALISHIRING", numRows = 4
            Output: "PINALSIGYAHRPI"
            Explanation:
            P     I    N
            A   L S  I G
            Y A   H R
            P     I
            
            Example 3:
            Input: s = "A", numRows = 1
            Output: "A"
 
            Constraints:
            1 <= s.length <= 1000
            s consists of English letters (lower-case and upper-case), ',' and '.'.
            1 <= numRows <= 1000
        */
        public string Convert(string s, int numRows)
        {
            if (numRows == 1)
                return s;
            StringBuilder sb = new StringBuilder();
            List<StringBuilder> lst = new List<StringBuilder>();
            for (int i = 0; i < numRows; i++)
            {
                lst.Add(new StringBuilder());
            }
            int rowIndex = 0;
            bool isInc = false;
            for (int i = 0; i < s.Length; i++)
            {
                lst[rowIndex].Append(s[i]);
                if (rowIndex == numRows - 1 || rowIndex == 0)
                    isInc = !isInc;
                if (isInc)
                    rowIndex++;
                else
                    rowIndex--;
            }
            foreach (var item in lst)
            {
                sb.Append(item.ToString());
            }
            return sb.ToString();
        }
    }
}
