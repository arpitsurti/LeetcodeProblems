using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Hard
{
    /*41. First Missing Positive
     * Given an unsorted integer array nums, return the smallest missing positive integer.

        You must implement an algorithm that runs in O(n) time and uses constant extra space.

        Example 1:
        Input: nums = [1,2,0]
        Output: 3

        Example 2:
        Input: nums = [3,4,-1,1]
        Output: 2

        Example 3:
        Input: nums = [7,8,9,11,12]
        Output: 1
 
        Constraints:
        1 <= nums.length <= 5 * 105
        -231 <= nums[i] <= 231 - 1
    */
    class clsFirstMissingPositive
    {
        public int FirstMissingPositive(int[] nums)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            HashSet<int> hs = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] >= 0)
                    min = Math.Min(min, nums[i]);
                max = Math.Max(max, nums[i]);
                hs.Add(nums[i]);
            }
            if (min == int.MaxValue)
                return 1;
            if (max < 0)
                return 0;
            if (min > 1)
                return 1;
            for (int i = min; i <= max; i++)
            {
                if (!hs.Contains(i))
                    return i;
            }
            return max + 1;
        }
    }
}
