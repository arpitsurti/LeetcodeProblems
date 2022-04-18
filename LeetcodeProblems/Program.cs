using LeetcodeProblems.CommonClass;
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
            clsMergeTwoSortedLists obj = new clsMergeTwoSortedLists();

            ListNode lst1 = new ListNode(1);
            lst1.next = new ListNode(2);
            lst1.next.next = new ListNode(4);

            ListNode lst2 = new ListNode(1);
            lst2.next = new ListNode(3);
            lst2.next.next = new ListNode(4);
            obj.MergeTwoLists(lst1,lst2);
        }
    }
}
