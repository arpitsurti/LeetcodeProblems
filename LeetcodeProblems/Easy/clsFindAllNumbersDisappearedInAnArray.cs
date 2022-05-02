using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*448. Find All Numbers Disappeared in an Array
     *** REF ***
     *** VERY IMP ***
     * Given an array nums of n integers where nums[i] is in the range [1, n], return an array of all the integers in the range [1, n] that do not appear in nums.

        Example 1:
        Input: nums = [4,3,2,7,8,2,3,1]
        Output: [5,6]

        Example 2:
        Input: nums = [1,1]
        Output: [2]
 
        Constraints:
        n == nums.length
        1 <= n <= 105
        1 <= nums[i] <= n
 
        Follow up: Could you do it without extra space and in O(n) runtime? You may assume the returned list does not count as extra space.
    */
    public class clsFindAllNumbersDisappearedInAnArray
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            IList<int> lstResult = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int index = Math.Abs(nums[i]) - 1;
                nums[index] = Math.Abs(nums[index]) * -1;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                    lstResult.Add(i + 1);
            }
            return lstResult;
        }
    }
}
