using LeetcodeProblems.CommonClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*100. Same Tree
     *  Given the roots of two binary trees p and q, write a function to check if they are the same or not.

        Two binary trees are considered the same if they are structurally identical, and the nodes have the same value.

        Example 1:
        Input: p = [1,2,3], q = [1,2,3]
        Output: true

        Example 2:
        Input: p = [1,2], q = [1,null,2]
        Output: false

        Example 3:
        Input: p = [1,2,1], q = [1,1,2]
        Output: false
 
        Constraints:
        The number of nodes in both trees is in the range [0, 100].
        -104 <= Node.val <= 104
    */
    public class clsSameTree
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
                return true;
            if ((p == null || q == null) || (p.val != q.val))
                return false;
            return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
        }
        /*
        public boolean isSameTree(TreeNode p, TreeNode q) 
        {
            Queue<TreeNode> queue = new LinkedList<>();
            if (p == null && q == null)
                return true;
            else if (p == null || q == null)
                return false;
            if (p != null && q != null) 
            {
                queue.offer(p);
                queue.offer(q);
            }
            while (!queue.isEmpty()) 
            {
                TreeNode first = queue.poll();
                TreeNode second = queue.poll();
                if (first == null && second == null)
                    continue;
                if (first == null || second == null)
                    return false;
                if (first.val != second.val)
                    return false;
                queue.offer(first.left);
                queue.offer(second.left);
                queue.offer(first.right);
                queue.offer(second.right);
            }
            return true;
        }
         */
    }
}
