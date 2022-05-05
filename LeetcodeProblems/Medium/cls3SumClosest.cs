using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Medium
{
    /*16. 3Sum Closest
     *** REF ***
     * Given an integer array nums of length n and an integer target, find three integers in nums such that the sum is closest to target.

        Return the sum of the three integers.
        You may assume that each input would have exactly one solution.

        Example 1:
        Input: nums = [-1,2,1,-4], target = 1
        Output: 2
        Explanation: The sum that is closest to the target is 2. (-1 + 2 + 1 = 2).

        Example 2:
        Input: nums = [0,0,0], target = 1
        Output: 0
 
        Constraints:
        3 <= nums.length <= 1000
        -1000 <= nums[i] <= 1000
        -104 <= target <= 104
    */
    public class cls3SumClosest
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            int result = nums[0] + nums[1] + nums[2];
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                int left = i + 1;
                int right = nums.Length - 1;
                while (left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];
                    if (sum > target)
                        right--;
                    else
                        left++;
                    if (Math.Abs(sum - target) < Math.Abs(result - target))
                        result = sum;
                }
            }
            return result;
        }
    }
}
