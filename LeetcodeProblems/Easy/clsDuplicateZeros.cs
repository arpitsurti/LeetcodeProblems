using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*1089. Duplicate Zeros
     *** REF ***
     *** VERY IMP ***
     * Given a fixed-length integer array arr, duplicate each occurrence of zero, shifting the remaining elements to the right.

        Note that elements beyond the length of the original array are not written. Do the above modifications to the input array in place and do not return anything.

        Example 1:
        Input: arr = [1,0,2,3,0,4,5,0]
        Output: [1,0,0,2,3,0,0,4]
        Explanation: After calling your function, the input array is modified to: [1,0,0,2,3,0,0,4]

        Example 2:
        Input: arr = [1,2,3]
        Output: [1,2,3]
        Explanation: After calling your function, the input array is modified to: [1,2,3]
 
        Constraints:
        1 <= arr.length <= 104
        0 <= arr[i] <= 9
    */
    class clsDuplicateZeros
    {
        public void DuplicateZeros(int[] arr)
        {
            int countZero = 0;
            for (int k = 0; k < arr.Length; k++)
            {
                if (arr[k] == 0)
                    countZero++;
            }
            int i = arr.Length - 1;
            int j = arr.Length + countZero - 1;
            while (i != j)
            {
                insert(arr, i, j--);
                if (arr[i] == 0)
                    insert(arr, i, j--);
                i--;
            }
        }

        private void insert(int[] arr, int i, int j)
        {
            if (j < arr.Length)
                arr[j] = arr[i];
        }
    }
}
