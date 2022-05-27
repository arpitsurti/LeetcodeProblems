using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*1287. Element Appearing More Than 25% In Sorted Array
     * Given an integer array sorted in non-decreasing order, there is exactly one integer in the array that occurs more than 25% of the time, return that integer.

        Example 1:
        Input: arr = [1,2,2,6,6,6,6,7,10]
        Output: 6

        Example 2:
        Input: arr = [1,1]
        Output: 1
 
        Constraints:
        1 <= arr.length <= 104
        0 <= arr[i] <= 105
    */
    public class clsElementAppearingMoreThan25PercentInSortedArray
    {
        public int FindSpecialInteger(int[] arr)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            decimal repeatCount = arr.Length / 4;

            for (int i = 0; i < arr.Length; i++)
            {
                if (!dict.ContainsKey(arr[i]))
                    dict.Add(arr[i], 0);
                dict[arr[i]]++;
                if (dict[arr[i]] > repeatCount)
                    return arr[i];
            }
            return -1;
        }
    }
}
