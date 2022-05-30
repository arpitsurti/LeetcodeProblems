using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Medium
{
    /*78. Subsets
     *** REF ***
     *https://www.youtube.com/watch?v=LdtQAYdYLcE
     * Given an integer array nums of unique elements, return all possible subsets (the power set).

        The solution set must not contain duplicate subsets. Return the solution in any order.

        Example 1:
        Input: nums = [1,2,3]
        Output: [[],[1],[2],[1,2],[3],[1,3],[2,3],[1,2,3]]

        Example 2:
        Input: nums = [0]
        Output: [[],[0]]

        Constraints:
        1 <= nums.length <= 10
        -10 <= nums[i] <= 10
        All the numbers of nums are unique.
    */
    public class clsSubsets
    {
        IList<IList<int>> lstResult = new List<IList<int>>();
        public IList<IList<int>> Subsets(int[] nums)
        {
            GetSubsets(nums, new List<int>(), 0);
            return lstResult;
        }

        private void GetSubsets(int[] nums, IList<int> lstCurr, int index)
        {
            if (index == nums.Length)
            {
                lstResult.Add(new List<int>(lstCurr));
                return;
            }
            lstCurr.Add(nums[index]);
            GetSubsets(nums, lstCurr, index + 1);
            lstCurr.RemoveAt(lstCurr.Count - 1);
            GetSubsets(nums, lstCurr, index + 1);
        }
    }
}
