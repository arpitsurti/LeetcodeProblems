using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*1588. Sum of All Odd Length Subarrays
     * Given an array of positive integers arr, calculate the sum of all possible odd-length subarrays.
        A subarray is a contiguous subsequence of the array.
        Return the sum of all odd-length subarrays of arr.

        Example 1:
        Input: arr = [1,4,2,5,3]
        Output: 58
        Explanation: The odd-length subarrays of arr and their sums are:
        [1] = 1
        [4] = 4
        [2] = 2
        [5] = 5
        [3] = 3
        [1,4,2] = 7
        [4,2,5] = 11
        [2,5,3] = 10
        [1,4,2,5,3] = 15
        If we add all these together we get 1 + 4 + 2 + 5 + 3 + 7 + 11 + 10 + 15 = 58

        Example 2:
        Input: arr = [1,2]
        Output: 3
        Explanation: There are only 2 subarrays of odd length, [1] and [2]. Their sum is 3.

        Example 3:
        Input: arr = [10,11,12]
        Output: 66
 
        Constraints:
        1 <= arr.length <= 100
        1 <= arr[i] <= 1000
    */
    public class clsSumOfAllOddLengthSubarrays
    {
        public int SumOddLengthSubarrays(int[] arr)
        {
            int output = 0;
            int[] runningSum = new int[arr.Length];
            output = runningSum[0] = arr[0];
            //Get running sum and 1 odd length
            for (int i = 1; i < arr.Length; i++)
            {
                runningSum[i] = runningSum[i - 1] + arr[i];
                output += arr[i];
            }
            //sub array sum
            int length = 3;
            while (length <= arr.Length)
            {
                for (int i = 0; i <= arr.Length - length; i++)
                {
                    output += getSubArraySum(i, i + length - 1, runningSum);
                }
                length = length + 2;
            }
            return output;
        }

        private int getSubArraySum(int start, int end, int[] runningSum)
        {
            return runningSum[end] - (start == 0 ? 0 : runningSum[start - 1]);
        }
    }
}
