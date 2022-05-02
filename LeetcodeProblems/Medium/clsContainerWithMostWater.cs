﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Medium
{
    /*11. Container With Most Water
     *** REF ***
     *Failed to use two pointer got TLE with n^2 solution
     * You are given an integer array height of length n. There are n vertical lines drawn such that the two endpoints of the ith line are (i, 0) and (i, height[i]).

        Find two lines that together with the x-axis form a container, such that the container contains the most water.
        Return the maximum amount of water a container can store.
        Notice that you may not slant the container.

        Example 1:
        Input: height = [1,8,6,2,5,4,8,3,7]
        Output: 49
        Explanation: The above vertical lines are represented by array [1,8,6,2,5,4,8,3,7]. In this case, the max area of water (blue section) the container can contain is 49.

        Example 2:
        Input: height = [1,1]
        Output: 1

        Constraints:
        n == height.length
        2 <= n <= 105
        0 <= height[i] <= 104
    */
    class clsContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {
            int maxArea = int.MinValue;
            int left = 0;
            int right = height.Length - 1;
            while (left < right)
            {
                int minHeight = Math.Min(height[left], height[right]);
                maxArea = Math.Max(maxArea, minHeight * (right - left));
                if (height[left] < height[right])
                    left++;
                else
                    right--;
            }
            return maxArea;
        }
    }
}
