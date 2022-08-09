using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Medium
{
    /*1338. Reduce Array Size to The Half
     * You are given an integer array arr. You can choose a set of integers and remove all the occurrences of these integers in the array.

        Return the minimum size of the set so that at least half of the integers of the array are removed.

        Example 1:
        Input: arr = [3,3,3,3,5,5,5,2,2,7]
        Output: 2
        Explanation: Choosing {3,7} will make the new array [5,5,5,2,2] which has size 5 (i.e equal to half of the size of the old array).
        Possible sets of size 2 are {3,5},{3,2},{5,2}.
        Choosing set {2,7} is not possible as it will make the new array [3,3,3,3,5,5,5] which has a size greater than half of the size of the old array.

        Example 2:
        Input: arr = [7,7,7,7,7,7]
        Output: 1
        Explanation: The only possible set you can choose is {7}. This will make the new array empty.
 
        Constraints:
        2 <= arr.length <= 105
        arr.length is even.
        1 <= arr[i] <= 105
    */
    public class clsReduceArraySizeToTheHalf
    {
        public int MinSetSize(int[] arr)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (!dict.ContainsKey(arr[i]))
                    dict.Add(arr[i], 0);
                dict[arr[i]]++;
            }
            int halfLen = arr.Length / 2;
            List<int> lst = dict.Values.ToList();
            lst.Sort();
            int sum = 0;
            int output = 0;
            for (int i = lst.Count - 1; i >= 0; i--)
            {
                sum += lst[i];
                output++;
                if (sum >= halfLen)
                    break;
            }
            return output;
        }
    }
}
