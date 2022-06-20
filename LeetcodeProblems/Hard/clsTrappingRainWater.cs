using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Hard
{
    /* 42. Trapping Rain Water
        Given n non-negative integers representing an elevation map where the width of each bar is 1, compute how much water it can trap after raining.

        Example 1:
        Input: height = [0,1,0,2,1,0,1,3,2,1,2,1]
        Output: 6
        Explanation: The above elevation map (black section) is represented by array [0,1,0,2,1,0,1,3,2,1,2,1]. In this case, 6 units of rain water (blue section) are being trapped.

        Example 2:
        Input: height = [4,2,0,3,2,5]
        Output: 9
 
        Constraints:
        n == height.length
        1 <= n <= 2 * 104
        0 <= height[i] <= 105
    */
    public class clsTrappingRainWater
    {
        public int Trap(int[] height)
        {
            int n = height.Length;
            int[] left = new int[n];
            int[] right = new int[n];
            int result = 0;
            left[0] = height[0];
            for (int i = 1; i < n; i++)
            {
                left[i] = Math.Max(left[i - 1], height[i]);
            }
            right[n - 1] = height[n - 1];
            for (int i = n - 2; i >= 0; i--)
            {
                right[i] = Math.Max(right[i + 1], height[i]);
            }
            for (int i = 0; i < n; i++)
            {
                result += (Math.Min(left[i], right[i]) - height[i]);
            }
            return result;
        }
    }
}
