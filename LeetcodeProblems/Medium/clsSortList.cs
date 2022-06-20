using LeetcodeProblems.CommonClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Medium
{
    /*148. Sort List
     *** REF ***
     *https://www.youtube.com/watch?v=pNTc1bM1z-4
     * Given the head of a linked list, return the list after sorting it in ascending order.

        Example 1:
        Input: head = [4,2,1,3]
        Output: [1,2,3,4]

        Example 2:
        Input: head = [-1,5,3,4,0]
        Output: [-1,0,3,4,5]

        Example 3:
        Input: head = []
        Output: []

        Constraints:
        The number of nodes in the list is in the range [0, 5 * 104].
        -105 <= Node.val <= 105
 
        Follow up: Can you sort the linked list in O(n logn) time and O(1) memory (i.e. constant space)?
    */
    class clsSortList
    {
        public ListNode SortList(ListNode head)
        {
            if (head == null || head.next == null)
                return head;
            ListNode leftTail = head;
            ListNode rightHead = head;//slow
            ListNode rightTail = head;//fast;
            while (rightTail != null && rightTail.next != null)
            {
                leftTail = rightHead;
                rightHead = rightHead.next;
                rightTail = rightTail.next.next;
            }
            leftTail.next = null;
            ListNode left = SortList(head);
            ListNode right = SortList(rightHead);
            return Merge(left, right);
        }

        private ListNode Merge(ListNode l1, ListNode l2)
        {
            ListNode newNode = new ListNode(0);
            ListNode currNode = newNode;
            while (l1 != null && l2 != null)
            {
                if (l1.val < l2.val)
                {
                    currNode.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    currNode.next = l2;
                    l2 = l2.next;
                }
                currNode = currNode.next;
            }
            if (l1 != null)
            {
                currNode.next = l1;
                l1 = l1.next;
            }
            if (l2 != null)
            {
                currNode.next = l2;
                l2 = l2.next;
            }
            return newNode.next;
        }
    }
}
