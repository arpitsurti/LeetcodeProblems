using LeetcodeProblems.CommonClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Medium
{
    /*19. Remove Nth Node From End of List
     *** REF ***
     * Given the head of a linked list, remove the nth node from the end of the list and return its head.

        Example 1:
        Input: head = [1,2,3,4,5], n = 2
        Output: [1,2,3,5]

        Example 2:
        Input: head = [1], n = 1
        Output: []

        Example 3:
        Input: head = [1,2], n = 1
        Output: [1]
 
        Constraints:
        The number of nodes in the list is sz.
        1 <= sz <= 30
        0 <= Node.val <= 100
        1 <= n <= sz
 
        Follow up: Could you do this in one pass?
    */
    class clsRemoveNthNodeFromEndOfList
    {
        /* APPROACH 1
         FIND LENGTH OF THE LINKED LIST AND DO INDEXING
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            //Find the length of the List
            ListNode curr = head;
            int length = 0;
            while (curr != null)
            {
                length++;
                curr = curr.next;
            }
            if (length == n)
            {
                return head.next;
            }
            curr = head;
            //Do indexing and remove the node once you reach the index
            int index = 0;
            while (index + 1 < length - n)
            {
                curr = curr.next;
                index++;
            }
            curr.next = curr.next.next;
            return head;
        }
        */
    public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode curr = new ListNode(0);
            curr.next = head;
            ListNode slowPointer = curr;
            ListNode fastPointer = curr;
            for (int i = 0; i <= n; i++)
            {
                fastPointer = fastPointer.next;
            }
            while (fastPointer != null)
            {
                slowPointer = slowPointer.next;
                fastPointer = fastPointer.next;
            }
            slowPointer.next = slowPointer.next.next;
            return curr.next;
        }
    }
}
