using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*461. Hamming Distance
     * The Hamming distance between two integers is the number of positions at which the corresponding bits are different.

        Given two integers x and y, return the Hamming distance between them.

        Example 1:
        Input: x = 1, y = 4
        Output: 2
        Explanation:
        1   (0 0 0 1)
        4   (0 1 0 0)
               ↑   ↑
        The above arrows point to positions where the corresponding bits are different.

        Example 2:
        Input: x = 3, y = 1
        Output: 1

        Constraints:
        0 <= x, y <= 231 - 1
    */
    public class clsHammingDistance
    {
        public int HammingDistance(int x, int y)
        {
            int answer = x ^ y;
            int count = 0;
            while (answer > 0)
            {
                if ((answer & 1) == 1)
                    count++;
                answer >>= 1;
            }
            return count;
        }
    }
}
