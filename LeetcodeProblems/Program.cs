using LeetcodeProblems.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            ToLowerCase("Hello@[]");
        }

        public static string ToLowerCase(string s)
        {
            char[] chArr = s.ToCharArray();
            for (int i = 0; i < chArr.Count(); i++)
            {
                if (chArr[i] >= 65 && chArr[i] < 91)
                    chArr[i] = (char)((int)chArr[i] + 32);
            }
            return string.Join("", chArr);
        }
    }
}
