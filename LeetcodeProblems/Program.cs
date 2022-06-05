using LeetcodeProblems.Easy;
using LeetcodeProblems.Medium;
using System;
using System.Collections.Generic;

namespace LeetcodeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Generate(5);
        }

        public static IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> lstResult = new List<IList<int>>();
            Generate(numRows, lstResult);
            return lstResult;
        }

        private static void Generate(int numRows, IList<IList<int>> lstResult)
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
    }
}
