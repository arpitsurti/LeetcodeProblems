using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Medium
{
    /*238. Product of Array Except Self
     *** REF ***
     *https://www.youtube.com/watch?v=tSRFtR3pv74
     * Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].

        The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.

        You must write an algorithm that runs in O(n) time and without using the division operation.

        Example 1:
        Input: nums = [1,2,3,4]
        Output: [24,12,8,6]

        Example 2:
        Input: nums = [-1,1,0,-3,3]
        Output: [0,0,9,0,0]
 
        Constraints:
        2 <= nums.length <= 105
        -30 <= nums[i] <= 30
        The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.

        Follow up: Can you solve the problem in O(1) extra space complexity? (The output array does not count as extra space for space complexity analysis.)
    */
    public class clsProductOfArrayExceptSelf
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            // USING O(1) SPACE COMPLEXITY WHERE OUTPUT ARRAY IS NOT COUNTED AS EXTRA SPACE
            int[] output = new int[nums.Length];
            output[0] = 1;
            for (int i = 1; i < output.Length; i++)
            {
                output[i] = output[i - 1] * nums[i - 1];
            }
            int postfixProduct = 1;
            for (int i = output.Length - 1; i >= 0; i--)
            {
                output[i] = output[i] * postfixProduct;
                postfixProduct *= nums[i];
            }
            return output;

            /* 
             * APPROACH 2 USING DIVISION OPERATOR
            int product = 1;
            int zeroCount = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    zeroCount++;
                    continue;
                }
                product *= nums[i];
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0 && zeroCount == 1)
                    nums[i] = product;
                else
                    nums[i] = zeroCount > 0 ? 0 : product / nums[i];
            }
            return nums;
            */
}
    }
}
