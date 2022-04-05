using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*1678. Goal Parser Interpretation
     * You own a Goal Parser that can interpret a string command. The command consists of an alphabet of "G", "()" and/or "(al)" in some order. The Goal Parser will interpret "G" as the string "G", "()" as the string "o", and "(al)" as the string "al". The interpreted strings are then concatenated in the original order.
        Given the string command, return the Goal Parser's interpretation of command.

        Example 1:
        Input: command = "G()(al)"
        Output: "Goal"
        Explanation: The Goal Parser interprets the command as follows:
        G -> G
        () -> o
        (al) -> al
        The final concatenated result is "Goal".

        Example 2:
        Input: command = "G()()()()(al)"
        Output: "Gooooal"

        Example 3:
        Input: command = "(al)G(al)()()G"
        Output: "alGalooG"
 
        Constraints:
        1 <= command.length <= 100
        command consists of "G", "()", and/or "(al)" in some order.
    */
    public class clsGoalParserInterpretation
    {
        public string Interpret(string command)
        {
            StringBuilder sb = new StringBuilder();
            int index = 0;
            while (index < command.Length)
            {
                if (command[index] == 'G')
                {
                    sb.Append("G");
                    index++;
                }
                else if (index + 1 < command.Length && command[index] == '(' && command[index + 1] == ')')
                {
                    sb.Append("o");
                    index += 2;
                }
                else
                {
                    sb.Append("al");
                    index += 4;
                }
            }
            return sb.ToString();
        }
    }
}
