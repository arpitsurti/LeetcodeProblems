using LeetcodeProblems.CommonClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*83. Remove Duplicates from Sorted List
     *** REF ***
     * Given the head of a sorted linked list, delete all duplicates such that each element appears only once. Return the linked list sorted as well.

        Example 1:
        Input: head = [1,1,2]
        Output: [1,2]

        Example 2:
        Input: head = [1,1,2,3,3]
        Output: [1,2,3]

        Constraints:
        The number of nodes in the list is in the range [0, 300].
        -100 <= Node.val <= 100
        The list is guaranteed to be sorted in ascending order.
    */
    public class clsRemoveDuplicatesFromSortedList
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            ListNode curr = head;
            while (curr != null && curr.next != null)
            {
                if (curr.val == curr.next.val)
                    curr.next = curr.next.next;
                else
                    curr = curr.next;
            }
            return head;
        }
    }
}
