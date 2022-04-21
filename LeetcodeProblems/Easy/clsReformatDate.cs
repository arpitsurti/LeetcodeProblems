using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*1507. Reformat Date
     * Given a date string in the form Day Month Year, where:
        Day is in the set {"1st", "2nd", "3rd", "4th", ..., "30th", "31st"}.
        Month is in the set {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"}.
        Year is in the range [1900, 2100].
        Convert the date string to the format YYYY-MM-DD, where:

        YYYY denotes the 4 digit year.
        MM denotes the 2 digit month.
        DD denotes the 2 digit day.
 
        Example 1:
        Input: date = "20th Oct 2052"
        Output: "2052-10-20"

        Example 2:
        Input: date = "6th Jun 1933"
        Output: "1933-06-06"

        Example 3:
        Input: date = "26th May 1960"
        Output: "1960-05-26"
 
        Constraints:
        The given dates are guaranteed to be valid, so no error handling is necessary.
    */
    public class clsReformatDate
    {
        public string ReformatDate(string date)
        {
            Dictionary<string, string> months = new Dictionary<string, string>();
            months.Add("Jan", "01");
            months.Add("Feb", "02");
            months.Add("Mar", "03");
            months.Add("Apr", "04");
            months.Add("May", "05");
            months.Add("Jun", "06");
            months.Add("Jul", "07");
            months.Add("Aug", "08");
            months.Add("Sep", "09");
            months.Add("Oct", "10");
            months.Add("Nov", "11");
            months.Add("Dec", "12");

            StringBuilder sb = new StringBuilder();
            string[] dates = date.Split(' ');
            sb.Append(dates[2] + "-");
            sb.Append(months[dates[1]] + "-");
            sb.Append(dates[0].Length == 3 ? "0" + dates[0].Substring(0, 1) : dates[0].Substring(0, 2));
            return sb.ToString();
        }
    }
}
