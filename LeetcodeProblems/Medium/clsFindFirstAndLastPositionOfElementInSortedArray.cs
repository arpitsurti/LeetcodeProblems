using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Medium
{
    /*34. Find First and Last Position of Element in Sorted Array
     *** REF ***
     * Given an array of integers nums sorted in non-decreasing order, find the starting and ending position of a given target value.

        If target is not found in the array, return [-1, -1].

        You must write an algorithm with O(log n) runtime complexity.

        Example 1:
        Input: nums = [5,7,7,8,8,10], target = 8
        Output: [3,4]

        Example 2:
        Input: nums = [5,7,7,8,8,10], target = 6
        Output: [-1,-1]

        Example 3:
        Input: nums = [], target = 0
        Output: [-1,-1]

        Constraints:
        0 <= nums.length <= 105
        -109 <= nums[i] <= 109
        nums is a non-decreasing array.
        -109 <= target <= 109
    */
    class clsFindFirstAndLastPositionOfElementInSortedArray
    {
        public int[] SearchRange(int[] nums, int target)
        {
            int[] result = new int[2];
            result[0] = findStartingIndex(nums, target);
            result[1] = findEndingIndex(nums, target);
            return result;
        }

        private int findStartingIndex(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            int index = -1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] >= target)
                    right = mid - 1;
                else
                    left = mid + 1;
                if (nums[mid] == target)
                    index = mid;
            }
            return index;
        }

        private int findEndingIndex(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            int index = -1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] <= target)
                    left = mid + 1;
                else
                    right = mid - 1;
                if (nums[mid] == target)
                    index = mid;
            }
            return index;
        }
    }
}
