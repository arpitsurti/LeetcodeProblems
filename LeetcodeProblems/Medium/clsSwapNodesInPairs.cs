using LeetcodeProblems.CommonClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Medium
{
    /*24. Swap Nodes in Pairs
     *** REF ***
     * Given a linked list, swap every two adjacent nodes and return its head. You must solve the problem without modifying the values in the list's nodes (i.e., only nodes themselves may be changed.)

        Example 1:
        Input: head = [1,2,3,4]
        Output: [2,1,4,3]

        Example 2:
        Input: head = []
        Output: []

        Example 3:
        Input: head = [1]
        Output: [1]
 
        Constraints:
        The number of nodes in the list is in the range [0, 100].
        0 <= Node.val <= 100
    */
    public class clsSwapNodesInPairs
    {
        public ListNode SwapPairs(ListNode head)
        {
            if (head == null || head.next == null)
                return head;
            ListNode p1 = head;
            ListNode p2 = head.next;
            ListNode p3 = head.next.next;
            p1.next = p3;
            p2.next = p1;
            if (p3 != null)
                p1.next = SwapPairs(p3);
            return p2;
        }
    }
}
