using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*67. Add Binary
     * Given two binary strings a and b, return their sum as a binary string.

        Example 1:
        Input: a = "11", b = "1"
        Output: "100"

        Example 2:
        Input: a = "1010", b = "1011"
        Output: "10101"
 
        Constraints:
        1 <= a.length, b.length <= 104
        a and b consist only of '0' or '1' characters.
        Each string does not contain leading zeros except for the zero itself.
    */
    public class clsAddBinary
    {
        public string AddBinary(string a, string b)
        {
            int lenA = a.Length;
            int lenB = b.Length;
            int n = Math.Max(lenA, lenB) - 1;
            StringBuilder sb = new StringBuilder();
            int carry = 0;
            lenA--;
            lenB--;
            while (lenA >= 0 || lenB >= 0)
            {
                int A = lenA >= 0 ? a[lenA] - '0' : 0;
                int B = lenB >= 0 ? b[lenB] - '0' : 0;
                int sum = A + B + carry;

                sb.Append((sum % 2) + "");
                carry = sum >> 1;
                lenA--;
                lenB--;
            }
            if (carry == 1)
                sb.Append("1");
            return new string(sb.ToString().Reverse().ToArray());
        }
    }
}
