using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Medium
{
    /* 15. 3Sum
     *** REF ***
     *** VERY IMP ***
     *Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.

        Notice that the solution set must not contain duplicate triplets.

        Example 1:
        Input: nums = [-1,0,1,2,-1,-4]
        Output: [[-1,-1,2],[-1,0,1]]

        Example 2:
        Input: nums = []
        Output: []

        Example 3:
        Input: nums = [0]
        Output: []
 
        Constraints:
        0 <= nums.length <= 3000
        -105 <= nums[i] <= 105
    */
    public class cls3Sum
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);
            IList<IList<int>> lstResult = new List<IList<int>>();
            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                    continue;
                int left = i + 1;
                int right = nums.Length - 1;
                int sum = 0 - nums[i];
                while (left < right)
                {
                    if (nums[left] + nums[right] == sum)
                    {
                        lstResult.Add(new List<int> { nums[i], nums[left], nums[right] });
                        while (left < right && nums[left] == nums[left + 1])
                            left++;
                        while (left < right && nums[right] == nums[right - 1])
                            right--;
                        left++;
                        right--;
                    }
                    else if (nums[left] + nums[right] > sum)
                        right--;
                    else
                        left++;
                }
            }
            return lstResult;
        }
    }
}
