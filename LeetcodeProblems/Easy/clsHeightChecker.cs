﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*1051. Height Checker
     * A school is trying to take an annual photo of all the students. The students are asked to stand in a single file line in non-decreasing order by height. Let this ordering be represented by the integer array expected where expected[i] is the expected height of the ith student in line.
        You are given an integer array heights representing the current order that the students are standing in. Each heights[i] is the height of the ith student in line (0-indexed).
        Return the number of indices where heights[i] != expected[i].

        Example 1:
        Input: heights = [1,1,4,2,1,3]
        Output: 3
        Explanation: 
        heights:  [1,1,4,2,1,3]
        expected: [1,1,1,2,3,4]
        Indices 2, 4, and 5 do not match.

        Example 2:
        Input: heights = [5,1,2,3,4]
        Output: 5
        Explanation:
        heights:  [5,1,2,3,4]
        expected: [1,2,3,4,5]
        All indices do not match.

        Example 3:
        Input: heights = [1,2,3,4,5]
        Output: 0
        Explanation:
        heights:  [1,2,3,4,5]
        expected: [1,2,3,4,5]
        All indices match.

        Constraints:
        1 <= heights.length <= 100
        1 <= heights[i] <= 100
    */
    public class clsHeightChecker
    {
        public int HeightChecker(int[] heights)
        {
            int[] count = new int[102];
            for (int i = 0; i < heights.Length; i++)
            {
                count[heights[i]]++;
            }
            for (int i = 1; i < count.Length; i++)
            {
                count[i] += count[i - 1];
            }
            int result = 0;
            int[] output = new int[heights.Length];
            for (int i = heights.Length - 1; i >= 0; i--)
            {
                output[count[heights[i]] - 1] = heights[i];
                int index = count[heights[i]] - 1;
                if (output[index] != heights[index])
                    result++;
                --count[heights[i]];
            }
            return result;
        }
    }
}
