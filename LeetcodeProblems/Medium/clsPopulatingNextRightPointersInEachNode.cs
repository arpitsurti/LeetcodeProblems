using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Medium
{
    /*116. Populating Next Right Pointers in Each Node
     *** REF ***
     *https://leetcode.com/problems/populating-next-right-pointers-in-each-node/discuss/529917/Simple-Iterative
     * You are given a perfect binary tree where all leaves are on the same level, and every parent has two children. The binary tree has the following definition:

        struct Node {
          int val;
          Node *left;
          Node *right;
          Node *next;
        }
        Populate each next pointer to point to its next right node. If there is no next right node, the next pointer should be set to NULL.

        Initially, all next pointers are set to NULL.

        Example 1:
        Input: root = [1,2,3,4,5,6,7]
        Output: [1,#,2,3,#,4,5,6,7,#]
        Explanation: Given the above perfect binary tree (Figure A), your function should populate each next pointer to point to its next right node, just like in Figure B. The serialized output is in level order as connected by the next pointers, with '#' signifying the end of each level.

        Example 2:
        Input: root = []
        Output: []
 
        Constraints:
        The number of nodes in the tree is in the range [0, 212 - 1].
        -1000 <= Node.val <= 1000
 
        Follow-up:
        You may only use constant extra space.
        The recursive approach is fine. You may assume implicit stack space does not count as extra space for this problem.
    */
    public class clsPopulatingNextRightPointersInEachNode
    {
        public Node Connect(Node root)
        {
            if (root == null)
                return null;
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                int size = queue.Count;
                Node prev = null;
                for (int i = 0; i < size; i++)
                {
                    Node curr = queue.Dequeue();
                    curr.next = prev;
                    prev = curr;
                    if (curr.right != null)
                        queue.Enqueue(curr.right);
                    if (curr.left != null)
                        queue.Enqueue(curr.left);
                }
            }
            return root;
        }
    }

    public class Node
    {
        public int val;
        public Node left;
        public Node right;
        public Node next;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, Node _left, Node _right, Node _next)
        {
            val = _val;
            left = _left;
            right = _right;
            next = _next;
        }
    }
}
