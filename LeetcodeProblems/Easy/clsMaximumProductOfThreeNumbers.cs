﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*628. Maximum Product of Three Numbers
     * Given an integer array nums, find three numbers whose product is maximum and return the maximum product.

        Example 1:
        Input: nums = [1,2,3]
        Output: 6

        Example 2:
        Input: nums = [1,2,3,4]
        Output: 24

        Example 3:
        Input: nums = [-1,-2,-3]
        Output: -6

        Constraints:
        3 <= nums.length <= 104
        -1000 <= nums[i] <= 1000
    */
    public class clsMaximumProductOfThreeNumbers
    {
        public int MaximumProduct(int[] nums)
        {
            Array.Sort(nums);
            int n = nums.Length;
            return Math.Max(nums[0] * nums[1] * nums[n - 1],
                           nums[n - 1] * nums[n - 2] * nums[n - 3]);
        }
    }
}
