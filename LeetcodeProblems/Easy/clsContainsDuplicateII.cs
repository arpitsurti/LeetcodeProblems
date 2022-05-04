using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*219. Contains Duplicate II
     * Given an integer array nums and an integer k, return true if there are two distinct indices i and j in the array such that nums[i] == nums[j] and abs(i - j) <= k.

        Example 1:
        Input: nums = [1,2,3,1], k = 3
        Output: true

        Example 2:
        Input: nums = [1,0,1,1], k = 1
        Output: true

        Example 3:
        Input: nums = [1,2,3,1,2,3], k = 2
        Output: false
 
        Constraints:
        1 <= nums.length <= 105
        -109 <= nums[i] <= 109
        0 <= k <= 105
    */
    public class clsContainsDuplicateII
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!dict.ContainsKey(nums[i]))
                    dict.Add(nums[i], i);
                else
                {
                    if (i - dict[nums[i]] <= k)
                        return true;
                    else
                        dict[nums[i]] = i;
                }
            }
            return false;
        }
    }
}
