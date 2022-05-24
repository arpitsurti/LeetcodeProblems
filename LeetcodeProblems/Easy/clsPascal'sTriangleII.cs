using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*119. Pascal's Triangle II
     * Given an integer rowIndex, return the rowIndexth (0-indexed) row of the Pascal's triangle.

        In Pascal's triangle, each number is the sum of the two numbers directly above it as shown:

        Example 1:
        Input: rowIndex = 3
        Output: [1,3,3,1]

        Example 2:
        Input: rowIndex = 0
        Output: [1]

        Example 3:
        Input: rowIndex = 1
        Output: [1,1]

        Constraints:
        0 <= rowIndex <= 33
 
        Follow up: Could you optimize your algorithm to use only O(rowIndex) extra space?
    */
    public class clsPascal_sTriangleII
    {
        public IList<int> GetRow(int rowIndex)
        {
            IList<int> prev = new List<int>();
            int index = 0;
            while (index <= rowIndex)
            {
                IList<int> curr = new List<int>();
                for (int i = 0; i <= index; i++)
                {
                    if (i == 0 || i == index)
                        curr.Add(1);
                    else
                        curr.Add(prev[i] + prev[i - 1]);
                }
                prev = curr;
                index++;
            }
            return prev;
        }
    }
}
