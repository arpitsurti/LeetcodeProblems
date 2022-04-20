using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*1207. Unique Number of Occurrences
     * Given an array of integers arr, return true if the number of occurrences of each value in the array is unique, or false otherwise.

        Example 1:
        Input: arr = [1,2,2,1,1,3]
        Output: true
        Explanation: The value 1 has 3 occurrences, 2 has 2 and 3 has 1. No two values have the same number of occurrences.

        Example 2:
        Input: arr = [1,2]
        Output: false

        Example 3:
        Input: arr = [-3,0,1,-3,1,1,1,-3,10,0]
        Output: true

        Constraints:
        1 <= arr.length <= 1000
        -1000 <= arr[i] <= 1000
    */
    public class clsUniqueNumberOfOccurrences
    {
        public bool UniqueOccurrences(int[] arr)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (dict.ContainsKey(arr[i]))
                    dict[arr[i]]++;
                else
                    dict.Add(arr[i], 1);
            }
            HashSet<int> hs = new HashSet<int>();
            foreach (var item in dict.Values)
            {
                hs.Add(item);
            }
            return hs.Count == dict.Count;
        }
    }
}
