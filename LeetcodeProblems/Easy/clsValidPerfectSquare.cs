﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*367. Valid Perfect Square
     * Given a positive integer num, write a function which returns True if num is a perfect square else False.

        Follow up: Do not use any built-in library function such as sqrt.

        Example 1:
        Input: num = 16
        Output: true

        Example 2:
        Input: num = 14
        Output: false

        Constraints:
        1 <= num <= 2^31 - 1
    */
    public class clsValidPerfectSquare
    {
        public bool IsPerfectSquare(int num)
        {
            if (num == 1)
                return true;
            long left = 1;///Long is important here as we are dealing with multiplications
            long right = num / 2;
            while (left <= right)
            {
                long mid = left + (right - left) / 2;
                if (mid * mid == num)
                    return true;
                else if (mid * mid > num)
                    right = mid - 1;
                else
                    left = mid + 1;
            }
            return false;
        }
    }
}
