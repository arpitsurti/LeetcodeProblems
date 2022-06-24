using LeetcodeProblems.CommonClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*206. Reverse Linked List
     *** REF ***
     * Given the head of a singly linked list, reverse the list, and return the reversed list.

    Example 1:
    Input: head = [1,2,3,4,5]
    Output: [5,4,3,2,1]

    Example 2:
    Input: head = [1,2]
    Output: [2,1]

    Example 3:
    Input: head = []
    Output: []
 
    Constraints:
    The number of nodes in the list is the range [0, 5000].
    -5000 <= Node.val <= 5000
 
    Follow up: A linked list can be reversed either iteratively or recursively. Could you implement both?
    */
    class clsReverseLinkedList
    {
        //ITERATIVE APPROACH
        public ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;
            while (head != null)
            {
                ListNode nextNode = head.next;
                head.next = prev;
                prev = head;
                head = nextNode;
            }
            return prev;
        }

        /*RECURSIVE APPROACH
        public ListNode ReverseList(ListNode head)
        {
            if (head == null || head.next == null)
                return head;
            ListNode newHead = ReverseList(head.next);
            ListNode headNext = head.next;
            headNext.next = head;
            head.next = null;
            return newHead;
        }
        */
    }
}
