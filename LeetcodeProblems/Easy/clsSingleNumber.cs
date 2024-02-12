using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*136. Single Number
        Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.
        You must implement a solution with a linear runtime complexity and use only constant extra space.

        Example 1:
        Input: nums = [2,2,1]
        Output: 1

        Example 2:
        Input: nums = [4,1,2,1,2]
        Output: 4

        Example 3:
        Input: nums = [1]
        Output: 1
 
        Constraints:
        1 <= nums.length <= 3 * 104
        -3 * 104 <= nums[i] <= 3 * 104
        Each element in the array appears twice except for one element which appears only once.
    */
    public class clsSingleNumber
    {
        /* EXTRA SPACE COMPLEXITY
        public int SingleNumber(int[] nums)
        {
            HashSet<int> hs = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (hs.Contains(nums[i]))
                    hs.Remove(nums[i]);
                else
                    hs.Add(nums[i]);
            }
            foreach (var item in hs)
            {
                return item;
            }
            return 0;
        }
        */
        
        //CONSTANT SPACE USING BIT MANIPULATION
        public int SingleNumber(int[] nums)
        {
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                result ^= nums[i];
            }
            return result;
        }
    }
}
