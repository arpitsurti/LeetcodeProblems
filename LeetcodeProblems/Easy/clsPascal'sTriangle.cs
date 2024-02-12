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
            IList<IList<int>> lstResult = new List<IList<int>>();
            lstResult.Add(new List<int>() { 1 });
            for (int i = 1; i < numRows; i++)
            {
                IList<int> lstCurr = new List<int>();
                lstCurr.Add(1);
                for (int j = 1; j < i; j++)
                {
                    lstCurr.Add(lstResult[i - 1][j] + lstResult[i - 1][j - 1]);
                }
                lstCurr.Add(1);
                lstResult.Add(lstCurr);
            }
            return lstResult;
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
