using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Medium
{
    /*152. Maximum Product Subarray
     *** REF ***
     *** VERY IMP ***
     *  Given an integer array nums, find a contiguous non-empty subarray within the array that has the largest product, and return the product.
        The test cases are generated so that the answer will fit in a 32-bit integer.
        A subarray is a contiguous subsequence of the array.

        Example 1:
        Input: nums = [2,3,-2,4]
        Output: 6
        Explanation: [2,3] has the largest product 6.

        Example 2:
        Input: nums = [-2,0,-1]
        Output: 0
        Explanation: The result cannot be 2, because [-2,-1] is not a subarray.
 
        Constraints:
        1 <= nums.length <= 2 * 104
        -10 <= nums[i] <= 10
        The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.
    */
    public class clsMaximumProductSubarray
    {
        public int MaxProduct(int[] nums)
        {
            int maxProduct = nums[0];
            int maxSoFar = nums[0];
            int minSoFar = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                int temp = maxSoFar;
                maxSoFar = Math.Max(nums[i], Math.Max(maxSoFar * nums[i], minSoFar * nums[i]));
                minSoFar = Math.Min(nums[i], Math.Min(temp * nums[i], minSoFar * nums[i]));
                maxProduct = Math.Max(maxSoFar, maxProduct);
            }
            return maxProduct;
        }
    }
}
