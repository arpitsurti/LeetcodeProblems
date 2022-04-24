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
            StringBuilder sb = new StringBuilder();
            int aIndex = a.Length - 1;
            int bIndex = b.Length - 1;
            int carry = 0;
            while (aIndex >= 0 || bIndex >= 0)
            {
                int num1 = aIndex >= 0 ? a[aIndex] - '0' : 0;
                int num2 = bIndex >= 0 ? b[bIndex] - '0' : 0;
                int sum = num1 + num2 + carry;
                carry = sum / 2;
                aIndex--;
                bIndex--;
                sb.Insert(0, sum % 2);
            }
            if (carry > 0)
                sb.Insert(0, carry);
            return sb.ToString();
        }
    }
}
