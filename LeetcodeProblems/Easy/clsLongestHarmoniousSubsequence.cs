using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*594. Longest Harmonious Subsequence
     *** REF ***
     * We define a harmonious array as an array where the difference between its maximum value and its minimum value is exactly 1.

        Given an integer array nums, return the length of its longest harmonious subsequence among all its possible subsequences.

        A subsequence of array is a sequence that can be derived from the array by deleting some or no elements without changing the order of the remaining elements.

        Example 1:
        Input: nums = [1,3,2,2,5,2,3,7]
        Output: 5
        Explanation: The longest harmonious subsequence is [3,2,2,2,3].

        Example 2:
        Input: nums = [1,2,3,4]
        Output: 2

        Example 3:
        Input: nums = [1,1,1,1]
        Output: 0
 
        Constraints:
        1 <= nums.length <= 2 * 104
        -109 <= nums[i] <= 109
    */
    public class clsLongestHarmoniousSubsequence
    {
        //APPROACH 1 
        public int FindLHS(int[] nums)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (!dict.ContainsKey(nums[i]))
                    dict.Add(nums[i], 0);
                dict[nums[i]]++;
            }
            foreach (var item in dict.Keys)
            {
                if (dict.ContainsKey(item + 1))
                    result = Math.Max(result, dict[item] + dict[item + 1]);
            }
            return result;
        }
        /*APPROACH 2 SORTING 
        public int FindLHS(int[] nums)
        {
            Array.Sort(nums);
            int result = 0;
            int left = 0;
            int right = 1;
            while (right < nums.Length)
            {
                int diff = nums[right] - nums[left];
                if (diff == 1)
                    result = Math.Max(result, right - left + 1);
                if (diff <= 1)
                    right++;
                else
                    left++;
            }
            return result;
        }
        */

    }
}
