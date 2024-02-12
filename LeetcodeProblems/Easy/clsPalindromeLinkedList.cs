using LeetcodeProblems.CommonClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*234. Palindrome Linked List
     * Given the head of a singly linked list, return true if it is a palindrome.

        Example 1:
        Input: head = [1,2,2,1]
        Output: true

        Example 2:
        Input: head = [1,2]
        Output: false
 
        Constraints:
        The number of nodes in the list is in the range [1, 105].
        0 <= Node.val <= 9

        Follow up: Could you do it in O(n) time and O(1) space?
    */
    public class clsPalindromeLinkedList
    {
        public bool IsPalindrome(ListNode head)
        {
            Stack<int> st = new Stack<int>();
            ListNode curr = head;
            while (curr != null)
            {
                st.Push(curr.val);
                curr = curr.next;
            }
            while (head != null)
            {
                int popped = st.Pop();
                if (popped != head.val)
                    return false;
                head = head.next;
            }
            return true; ;
        }
    }
}
