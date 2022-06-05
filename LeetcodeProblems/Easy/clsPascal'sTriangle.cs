using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*118. Pascal's Triangle
     * Given an integer numRows, return the first numRows of Pascal's triangle.

        In Pascal's triangle, each number is the sum of the two numbers directly above it as shown:

        Example 1:
        Input: numRows = 5
        Output: [[1],[1,1],[1,2,1],[1,3,3,1],[1,4,6,4,1]]

        Example 2:
        Input: numRows = 1
        Output: [[1]]
 
        Constraints:
        1 <= numRows <= 30
    */
    public class clsPascal_sTriangle
    {
        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> output = new List<IList<int>>();
            if (numRows == 0)
                return output;
            int index = 2;
            IList<int> lst = new List<int>();
            lst.Add(1);
            output.Add(lst);
            while (index <= numRows)
            {
                List<int> arr = new List<int>();
                for (int i = 0; i < index; i++)
                {
                    if (i == 0)
                        arr.Add(1);
                    else if (i == index - 1)
                    {
                        arr.Add(1);
                        output.Add(arr);
                    }
                    else
                    {
                        int prev1 = output[index - 2][i];
                        int prev2 = output[index - 2][i - 1];
                        arr.Add(prev1 + prev2);
                    }
                }
                index++;
            }
            return output;
        }

        /*
         * USING RECURSION
            public IList<IList<int>> Generate(int numRows) {
                IList<IList<int>> lstResult = new List<IList<int>>();
                Generate(numRows, lstResult);
                return lstResult;
            }
    
            private void Generate(int numRows, IList<IList<int>> lstResult)
            {
                IList<int> lstCurrent = new List<int>();
                if (numRows == 1)
                {
                    lstCurrent.Add(1);
                    lstResult.Add(lstCurrent);
                    return;
                }
                Generate(numRows - 1, lstResult);
                IList<int> lstPrevious = lstResult[numRows - 2];
                for (int i = 1; i <= numRows; i++)
                {
                    if (i == 1 || i == numRows)
                        lstCurrent.Add(1);
                    else
                        lstCurrent.Add(lstPrevious[i - 1] + lstPrevious[i - 2]);
                }
                lstResult.Add(lstCurrent);
            }
        */
    }
}
