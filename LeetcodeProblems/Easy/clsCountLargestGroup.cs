using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*1399. Count Largest Group
     * You are given an integer n.

        Each number from 1 to n is grouped according to the sum of its digits.

        Return the number of groups that have the largest size.

        Example 1:
        Input: n = 13
        Output: 4
        Explanation: There are 9 groups in total, they are grouped according sum of its digits of numbers from 1 to 13:
        [1,10], [2,11], [3,12], [4,13], [5], [6], [7], [8], [9].
        There are 4 groups with largest size.

        Example 2:
        Input: n = 2
        Output: 2
        Explanation: There are 2 groups [1], [2] of size 1.
 
        Constraints:
        1 <= n <= 104
    */
    public class clsCountLargestGroup
    {
        public int CountLargestGroup(int n)
        {
            Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
            int output = 0;
            for (int i = 1; i <= n; i++)
            {
                int num = i;
                if (num >= 10)
                {
                    num = sum(num);
                }
                if (!dict.ContainsKey(num))
                    dict.Add(num, new List<int>());
                dict[num].Add(i);
                output = Math.Max(output, dict[num].Count);
            }
            return output;
        }

        private int sum(int n)
        {
            int sum = 0;
            while (n > 9)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum + n;
        }
    }
}
