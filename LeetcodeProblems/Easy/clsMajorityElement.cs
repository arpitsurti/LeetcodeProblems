using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*169. Majority Element
     * Given an array nums of size n, return the majority element.
        The majority element is the element that appears more than ⌊n / 2⌋ times. You may assume that the majority element always exists in the array.

        Example 1:
        Input: nums = [3,2,3]
        Output: 3

        Example 2:
        Input: nums = [2,2,1,1,1,2,2]
        Output: 2
 
        Constraints:
        n == nums.length
        1 <= n <= 5 * 104
        -109 <= nums[i] <= 109

        Follow-up: Could you solve the problem in linear time and in O(1) space?
    */
    public class clsMajorityElement
    {
        public int MajorityElement(int[] nums)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!dict.ContainsKey(nums[i]))
                    dict.Add(nums[i], 0);
                dict[nums[i]]++;
                if (dict[nums[i]] > nums.Length / 2)
                    return nums[i];
            }
            return 0;
        }
    }
}
