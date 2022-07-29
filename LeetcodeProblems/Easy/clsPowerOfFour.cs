using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*342. Power of Four
     *** REF ***
     *https://www.youtube.com/watch?v=KwtRRZN6loU
     * Given an integer n, return true if it is a power of four. Otherwise, return false.

        An integer n is a power of four, if there exists an integer x such that n == 4x.

        Example 1:
        Input: n = 16
        Output: true
        
        Example 2:
        Input: n = 5
        Output: false
    
        Example 3:
        Input: n = 1
        Output: true
 
        Constraints:
        -231 <= n <= 231 - 1
 
        Follow up: Could you solve it without loops/recursion?
    */
    public class clsPowerOfFour
    {
        public bool IsPowerOfFour(int n)
        {
            //APPRIACH 1 return n > 0 && (n & (n - 1)) == 0 && n % 3 == 1;
            //APPROACH 2
            if (n < 1)
                return false;
            int tempN = n, count = 0;
            while (tempN > 1)
            {
                tempN >>= 2;
                count += 2;
            }
            return (tempN << count) == n;
        }
    }
}
